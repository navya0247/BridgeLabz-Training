using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface ILabelRepository
    {
        LabelEntity CreateLabel(LabelEntity label);
        LabelEntity? GetLabelById(int labelId, int userId);
        List<LabelEntity> GetAllLabels(int userId);
        LabelEntity? EditLabel(int labelId, int userId, string newLabelName);
        bool DeleteLabel(int labelId, int userId);
    }
}