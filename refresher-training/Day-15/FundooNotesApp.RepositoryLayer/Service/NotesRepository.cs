using FundooNotesApp.ModelLayer.Entities;
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

        public NotesEntity AddNote(NotesEntity note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note;
        }

        public List<NotesEntity> GetAllNotes(int userId)
        {
            // only notes belonging to this user, not trashed
            return _context.Notes.Where(n => n.UserId == userId && !n.Trash).ToList();
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

        public NotesEntity? TogglePin(long noteId, int userId)
        {
            var note = GetNoteById(noteId, userId);
            if (note == null) return null;

            // flip pin value
            note.Pin = !note.Pin;
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public NotesEntity? ToggleArchive(long noteId, int userId)
        {
            var note = GetNoteById(noteId, userId);
            if (note == null) return null;

            // flip archive value
            note.Archive = !note.Archive;
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public NotesEntity? ToggleTrash(long noteId, int userId)
        {
            var note = GetNoteById(noteId, userId);
            if (note == null) return null;

            // flip trash value
            note.Trash = !note.Trash;
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public List<NotesEntity> SearchNotes(int userId, string keyword)
        {
            // matches keyword in title or description
            return _context.Notes
                .Where(n => n.UserId == userId && !n.Trash &&
                    (n.Title.Contains(keyword) || n.Description.Contains(keyword)))
                .ToList();
        }

        public List<NotesEntity> FilterNotes(int userId, bool? pin, bool? archive, bool? trash)
        {
            var query = _context.Notes.Where(n => n.UserId == userId);

            // apply filters only if provided
            if (pin.HasValue) query = query.Where(n => n.Pin == pin.Value);
            if (archive.HasValue) query = query.Where(n => n.Archive == archive.Value);
            if (trash.HasValue) query = query.Where(n => n.Trash == trash.Value);

            return query.ToList();
        }
    }
}