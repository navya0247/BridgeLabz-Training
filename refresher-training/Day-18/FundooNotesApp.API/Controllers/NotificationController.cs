using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Exceptions;

namespace FundooNotesApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        // service injected here
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        // reads userId from jwt token claims
        private int GetUserId()
        {
            return Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value);
        }

        [HttpGet("all")]
        public IActionResult GetAllNotifications()
        {
            try
            {
                int userId = GetUserId();
                var result = _notificationService.GetAllNotifications(userId);
                return Ok(new ApiResponseDto<List<NotificationResponseDto>> { Success = true, Message = "Notifications retrieved", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPatch("read/{notificationId}")]
        public IActionResult MarkAsRead(long notificationId)
        {
            try
            {
                int userId = GetUserId();
                var result = _notificationService.MarkAsRead(notificationId, userId);
                return Ok(new ApiResponseDto<NotificationResponseDto> { Success = true, Message = "Marked as read", Data = result });
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