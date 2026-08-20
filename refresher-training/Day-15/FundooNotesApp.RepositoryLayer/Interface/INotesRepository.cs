using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface INotesRepository
    {
        NotesEntity AddNote(NotesEntity note);
        List<NotesEntity> GetAllNotes(int userId);
        NotesEntity? GetNoteById(long noteId, int userId);
        bool DeleteNote(long noteId, int userId);

        // toggles pin status, returns updated entity
        NotesEntity? TogglePin(long noteId, int userId);

        // toggles archive status, returns updated entity
        NotesEntity? ToggleArchive(long noteId, int userId);

        // toggles trash status, returns updated entity
        NotesEntity? ToggleTrash(long noteId, int userId);

        // searches notes by title or description keyword
        List<NotesEntity> SearchNotes(int userId, string keyword);

        // filters notes by pin, archive, or trash status
        List<NotesEntity> FilterNotes(int userId, bool? pin, bool? archive, bool? trash);
    }
}