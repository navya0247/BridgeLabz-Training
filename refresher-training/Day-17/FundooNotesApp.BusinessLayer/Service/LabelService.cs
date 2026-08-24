using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.BusinessLayer.Service
{
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository _repository;

        // repository injected here
        public LabelService(ILabelRepository repository)
        {
            _repository = repository;
        }

        // maps entity to model, reused across methods
        private LabelModel MapToModel(LabelEntity label)
        {
            return new LabelModel
            {
                LabelId = label.LabelId,
                LabelName = label.LabelName,
                NoteId = label.NoteId
            };
        }

        public LabelModel CreateLabel(LabelRequestDto labelRequestDto, int userId)
        {
            LabelEntity label = new LabelEntity
            {
                LabelName = labelRequestDto.LabelName,
                NoteId = labelRequestDto.NoteId,
                UserId = userId
            };

            var saved = _repository.CreateLabel(label);
            return MapToModel(saved);
        }

        public List<LabelModel> GetAllLabels(int userId)
        {
            var labels = _repository.GetAllLabels(userId);
            return labels.Select(MapToModel).ToList();
        }

        public LabelModel EditLabel(int labelId, LabelRequestDto labelRequestDto, int userId)
        {
            var label = _repository.EditLabel(labelId, userId, labelRequestDto.LabelName);
            if (label == null)
                throw new LabelNotFoundException("Label not found or you do not have access");

            return MapToModel(label);
        }

        public string DeleteLabel(int labelId, int userId)
        {
            bool deleted = _repository.DeleteLabel(labelId, userId);
            if (!deleted)
                throw new LabelNotFoundException("Label not found or you do not have access");

            return "Label deleted successfully";
        }
    }
}