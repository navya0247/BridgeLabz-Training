using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.RepositoryLayer.Interface;

namespace FundooNotesApp.BusinessLayer.Service
{
    public class NotesService : INotesService
    {
        private readonly INotesRepository _repository;

        // repository injected here
        public NotesService(INotesRepository repository)
        {
            _repository = repository;
        }

        // maps entity to response dto, reused across methods
        private NotesResponseDto MapToDto(NotesEntity note)
        {
            return new NotesResponseDto
            {
                NoteId = note.NoteId,
                Title = note.Title,
                Description = note.Description,
                Pin = note.Pin,
                Archive = note.Archive,
                Trash = note.Trash
            };
        }

        public NotesResponseDto CreateNote(NotesRequestDto notesRequestDto, int userId)
        {
            NotesEntity note = new NotesEntity
            {
                Title = notesRequestDto.Title,
                Description = notesRequestDto.Description ?? string.Empty,
                Reminder = notesRequestDto.Reminder,
                Backgroundcolor = notesRequestDto.Backgroundcolor ?? string.Empty,
                UserId = userId,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };
            var saved = _repository.AddNote(note);
            return MapToDto(saved);
        }

        public List<NotesResponseDto> GetAllNotes(int userId)
        {
            var notes = _repository.GetAllNotes(userId);
            return notes.Select(MapToDto).ToList();
        }

        public NotesResponseDto GetNoteById(long noteId, int userId)
        {
            var note = _repository.GetNoteById(noteId, userId);
            if (note == null)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return MapToDto(note);
        }

        public string DeleteNote(long noteId, int userId)
        {
            bool deleted = _repository.DeleteNote(noteId, userId);
            if (!deleted)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return "Note deleted successfully";
        }

        public NotesResponseDto TogglePin(long noteId, int userId)
        {
            var note = _repository.TogglePin(noteId, userId);
            if (note == null)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return MapToDto(note);
        }

        public NotesResponseDto ToggleArchive(long noteId, int userId)
        {
            var note = _repository.ToggleArchive(noteId, userId);
            if (note == null)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return MapToDto(note);
        }

        public NotesResponseDto ToggleTrash(long noteId, int userId)
        {
            var note = _repository.ToggleTrash(noteId, userId);
            if (note == null)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return MapToDto(note);
        }

        public List<NotesResponseDto> SearchNotes(int userId, string keyword)
        {
            var notes = _repository.SearchNotes(userId, keyword);
            return notes.Select(MapToDto).ToList();
        }

        public List<NotesResponseDto> FilterNotes(int userId, bool? pin, bool? archive, bool? trash)
        {
            var notes = _repository.FilterNotes(userId, pin, archive, trash);
            return notes.Select(MapToDto).ToList();
        }
    }
}