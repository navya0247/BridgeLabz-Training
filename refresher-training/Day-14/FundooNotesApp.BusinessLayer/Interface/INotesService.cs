using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;

namespace FundooNotesApp.BusinessLayer.Interface
{
    public interface INotesService
    {
        NotesResponseDto CreateNote(NotesRequestDto notesRequestDto, int userId);
        List<NotesResponseDto> GetAllNotes(int userId);
        string DeleteNote(long noteId, int userId);
    }
}