using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Exceptions;

namespace FundooNotesApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly INotesService _notesService;

        // service injected here
        public NotesController(INotesService notesService)
        {
            _notesService = notesService;
        }

        // reads userId from jwt token claims
        private int GetUserId()
        {
            return Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value);
        }

        [HttpPost("create")]
        public IActionResult CreateNote(NotesRequestDto notesRequestDto)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.CreateNote(notesRequestDto, userId);
                return Ok(new ApiResponseDto<NotesResponseDto> { Success = true, Message = "Note created successfully", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllNotes()
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.GetAllNotes(userId);
                return Ok(new ApiResponseDto<List<NotesResponseDto>> { Success = true, Message = "Notes retrieved successfully", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("{noteId}")]
        public IActionResult GetNoteById(long noteId)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.GetNoteById(noteId, userId);
                return Ok(new ApiResponseDto<NotesResponseDto> { Success = true, Message = "Note retrieved successfully", Data = result });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpDelete("{noteId}")]
        public IActionResult DeleteNote(long noteId)
        {
            try
            {
                int userId = GetUserId();
                string message = _notesService.DeleteNote(noteId, userId);
                return Ok(new ApiResponseDto<string> { Success = true, Message = message });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        // patch used here, only one field is being toggled, not full note replaced
        [HttpPatch("pin/{noteId}")]
        public IActionResult TogglePin(long noteId)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.TogglePin(noteId, userId);
                return Ok(new ApiResponseDto<NotesResponseDto> { Success = true, Message = "Pin status updated", Data = result });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPatch("archive/{noteId}")]
        public IActionResult ToggleArchive(long noteId)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.ToggleArchive(noteId, userId);
                return Ok(new ApiResponseDto<NotesResponseDto> { Success = true, Message = "Archive status updated", Data = result });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPatch("trash/{noteId}")]
        public IActionResult ToggleTrash(long noteId)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.ToggleTrash(noteId, userId);
                return Ok(new ApiResponseDto<NotesResponseDto> { Success = true, Message = "Trash status updated", Data = result });
            }
            catch (NoteNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("search")]
        public IActionResult SearchNotes([FromQuery] string keyword)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.SearchNotes(userId, keyword);
                return Ok(new ApiResponseDto<List<NotesResponseDto>> { Success = true, Message = "Search results", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("filter")]
        public IActionResult FilterNotes([FromQuery] bool? pin, [FromQuery] bool? archive, [FromQuery] bool? trash)
        {
            try
            {
                int userId = GetUserId();
                var result = _notesService.FilterNotes(userId, pin, archive, trash);
                return Ok(new ApiResponseDto<List<NotesResponseDto>> { Success = true, Message = "Filtered notes", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }
    }
}