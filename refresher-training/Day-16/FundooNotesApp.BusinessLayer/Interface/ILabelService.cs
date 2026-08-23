using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.BusinessLayer.Interface
{
    public interface ILabelService
    {
        LabelModel CreateLabel(LabelRequestDto labelRequestDto, int userId);
        List<LabelModel> GetAllLabels(int userId);
        LabelModel EditLabel(int labelId, LabelRequestDto labelRequestDto, int userId);
        string DeleteLabel(int labelId, int userId);
    }
}