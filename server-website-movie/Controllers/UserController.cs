using Microsoft.AspNetCore.Mvc;
using server_website_movie.Models;
using server_website_movie.Services.UserService;

namespace server_website_movie.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    private readonly IUserService _service;
    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpPost("add-new")]
    public async Task<IActionResult> AddNewUser([FromBody] UserAccount user)
    {
        await _service.AddNewUser(user);
        return Ok(user);
    }
}
