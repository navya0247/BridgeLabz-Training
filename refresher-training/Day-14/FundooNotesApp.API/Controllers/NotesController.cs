using System.Security.Claims;
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
    }
}