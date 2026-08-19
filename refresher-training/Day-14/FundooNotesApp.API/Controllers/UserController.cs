using Microsoft.AspNetCore.Mvc;
using FundooNotesApp.BusinessLayer.Interface;
using FundooNotesApp.ModelLayer.Dtos.Request;
using FundooNotesApp.ModelLayer.Dtos.Response;
using FundooNotesApp.ModelLayer.Exceptions;

namespace FundooNotesApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        // service injected here
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequestDto registerRequestDto)
        {
            try
            {
                string message = _userService.Register(registerRequestDto);
                return Ok(new ApiResponseDto<string> { Success = true, Message = message });
            }
            catch (UserAlreadyExistsException ex)
            {
                return Conflict(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto loginRequestDto)
        {
            try
            {
                string token = _userService.Login(loginRequestDto);
                return Ok(new ApiResponseDto<string> { Success = true, Message = "Login successful", Data = token });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (InvalidCredentialsException ex)
            {
                return Unauthorized(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword(ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            try
            {
                string resetToken = _userService.ForgotPassword(forgotPasswordRequestDto);
                return Ok(new ApiResponseDto<string> { Success = true, Message = "Reset token generated", Data = resetToken });
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }

        [HttpPost("reset-password")]
        public IActionResult ResetPassword(ResetPasswordRequestDto resetPasswordRequestDto)
        {
            try
            {
                string message = _userService.ResetPassword(resetPasswordRequestDto);
                return Ok(new ApiResponseDto<string> { Success = true, Message = message });
            }
            catch (InvalidCredentialsException ex)
            {
                return BadRequest(new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponseDto<string> { Success = false, Message = ex.Message });
            }
        }
    }
}