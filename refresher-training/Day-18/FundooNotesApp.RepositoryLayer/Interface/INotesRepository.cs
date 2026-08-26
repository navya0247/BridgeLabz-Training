using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface INotesRepository
    {
        NotesEntity AddNote(NotesEntity note);
        List<NotesEntity> GetAllNotes(int userId);
        NotesEntity? GetNoteById(long noteId, int userId);
        bool DeleteNote(long noteId, int userId);
        NotesEntity? TogglePin(long noteId, int userId);
        NotesEntity? ToggleArchive(long noteId, int userId);
        NotesEntity? ToggleTrash(long noteId, int userId);
        List<NotesEntity> SearchNotes(int userId, string keyword);
        List<NotesEntity> FilterNotes(int userId, bool? pin, bool? archive, bool? trash);

        // sets or updates the reminder datetime on a note
        NotesEntity? SetReminder(long noteId, int userId, DateTime reminderTime);
    }
}