using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;

namespace FundooNotesApp.BusinessLayer.Interface
{
    public interface INotesService
    {
        NotesResponseDto CreateNote(NotesRequestDto notesRequestDto, int userId);
        List<NotesResponseDto> GetAllNotes(int userId);
        NotesResponseDto GetNoteById(long noteId, int userId);
        string DeleteNote(long noteId, int userId);

        // toggle methods for pin, archive, trash
        NotesResponseDto TogglePin(long noteId, int userId);
        NotesResponseDto ToggleArchive(long noteId, int userId);
        NotesResponseDto ToggleTrash(long noteId, int userId);

        // search and filter methods
        List<NotesResponseDto> SearchNotes(int userId, string keyword);
        List<NotesResponseDto> FilterNotes(int userId, bool? pin, bool? archive, bool? trash);
    }
}