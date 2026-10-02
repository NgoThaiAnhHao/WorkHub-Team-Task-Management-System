using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkHub.Application.Users.Queries.GetUsers;
using WorkHub.Domain.Entities;

namespace WorkHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        // GET USERS
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _mediator.Send(new GetUsersQuery());
            return Ok(users);
        }
    }
}
