using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.RepositoryLayer.Interface
{
    public interface INotesRepository
    {
        // creates note for given user
        NotesModel AddNote(NotesEntity note);

        // gets all notes belonging to user
        List<NotesModel> GetAllNotes(int userId);

        // finds single note by id and user, ensures ownership
        NotesEntity? GetNoteById(long noteId, int userId);

        // deletes note, returns true if deleted
        bool DeleteNote(long noteId, int userId);
    }
}