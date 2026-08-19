using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.RepositoryLayer.Service
{
    public class NotesRepository : INotesRepository
    {
        private readonly AppDbContext _context;

        // db context injected here
        public NotesRepository(AppDbContext context)
        {
            _context = context;
        }

        public NotesModel AddNote(NotesEntity note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();

            // build safe model to return
            return new NotesModel
            {
                NoteId = note.NoteId,
                Title = note.Title,
                Description = note.Description,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash
            };
        }

        public List<NotesModel> GetAllNotes(int userId)
        {
            // only notes belonging to this user, not trashed
            return _context.Notes
                .Where(n => n.UserId == userId && !n.Trash)
                .Select(n => new NotesModel
                {
                    NoteId = n.NoteId,
                    Title = n.Title,
                    Description = n.Description,
                    Pin = n.Pin,
                    Archive = n.Archive,
                    Trash = n.Trash
                })
                .ToList();
        }

        public NotesEntity? GetNoteById(long noteId, int userId)
        {
            return _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
        }

        public bool DeleteNote(long noteId, int userId)
        {
            var note = GetNoteById(noteId, userId);
            if (note == null) return false;

            _context.Notes.Remove(note);
            _context.SaveChanges();
            return true;
        }
    }
}