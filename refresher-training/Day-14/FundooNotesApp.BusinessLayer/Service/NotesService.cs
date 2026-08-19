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

        public NotesResponseDto CreateNote(NotesRequestDto notesRequestDto, int userId)
        {
            // map request dto to entity
            NotesEntity note = new NotesEntity
            {
                Title = notesRequestDto.Title,
                Description = notesRequestDto.Description,
                Reminder = notesRequestDto.Reminder,
                Backgroundcolor = notesRequestDto.Backgroundcolor,
                UserId = userId,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            var saved = _repository.AddNote(note);

            return new NotesResponseDto
            {
                NoteId = saved.NoteId,
                Title = saved.Title,
                Description = saved.Description,
                Pin = saved.Pin,
                Archive = saved.Archive,
                Trash = saved.Trash
            };
        }

        public List<NotesResponseDto> GetAllNotes(int userId)
        {
            var notes = _repository.GetAllNotes(userId);

            // map each model to response dto
            return notes.Select(n => new NotesResponseDto
            {
                NoteId = n.NoteId,
                Title = n.Title,
                Description = n.Description,
                Pin = n.Pin,
                Archive = n.Archive,
                Trash = n.Trash
            }).ToList();
        }

        public string DeleteNote(long noteId, int userId)
        {
            bool deleted = _repository.DeleteNote(noteId, userId);
            if (!deleted)
                throw new NoteNotFoundException("Note not found or you do not have access");

            return "Note deleted successfully";
        }
    }
}