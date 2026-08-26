using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LabelController : ControllerBase
    {
        private readonly ILabelService _labelService;

        // service injected here
        public LabelController(ILabelService labelService)
        {
            _labelService = labelService;
        }

        // reads userId from jwt token claims
        private int GetUserId()
        {
            return Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value);
        }

        [HttpPost("create")]
        public IActionResult CreateLabel(LabelRequestDto labelRequestDto)
        {
            try
            {
                int userId = GetUserId();
                var result = _labelService.CreateLabel(labelRequestDto, userId);
                return Ok(new ApiResponseDto<LabelModel> { Success = true, Message = "Label created successfully", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllLabels()
        {
            try
            {
                int userId = GetUserId();
                var result = _labelService.GetAllLabels(userId);
                return Ok(new ApiResponseDto<List<LabelModel>> { Success = true, Message = "Labels retrieved successfully", Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPut("{labelId}")]
        public IActionResult EditLabel(int labelId, LabelRequestDto labelRequestDto)
        {
            try
            {
                int userId = GetUserId();
                var result = _labelService.EditLabel(labelId, labelRequestDto, userId);
                return Ok(new ApiResponseDto<LabelModel> { Success = true, Message = "Label updated successfully", Data = result });
            }
            catch (LabelNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpDelete("{labelId}")]
        public IActionResult DeleteLabel(int labelId)
        {
            try
            {
                int userId = GetUserId();
                string message = _labelService.DeleteLabel(labelId, userId);
                return Ok(new ApiResponseDto<string> { Success = true, Message = message });
            }
            catch (LabelNotFoundException ex)
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