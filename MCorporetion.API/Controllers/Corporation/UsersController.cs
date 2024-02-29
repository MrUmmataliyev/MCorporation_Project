using MCorporation.API.Attributes;
using MCorporation.Application.Services.Users;
using MCorporation.Domain.Entities.Models;
using MCorporation.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCorporation.API.Controllers.Corporation
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [IdentityFilter(Permission.GetAllUsers)]
        public IActionResult GetAllUsers()
        {
            var res = _usersService.GetAllUsers();
            return Ok(res);
        }
        [HttpGet]
        [IdentityFilter(Permission.GetUsersById)]
        public IActionResult GetUsersById(int id)
        {
            var res = _usersService.GetUserById(id);
            return Ok(res);
        }
        [HttpPost]
        [IdentityFilter(Permission.CreateUser)]
        public IActionResult CreateUser(User user)
        {
           var res =  _usersService.CreateUser(user);
           return Ok(res);
        }
        [HttpPut]
        [IdentityFilter(Permission.UpdateUser)]
        public IActionResult UpdateUser(int id,User user)
        {
            var res = _usersService.UpdateUser(id,user);
            return Ok(res);
        }
        [HttpDelete]
        [IdentityFilter(Permission.DeleteUser)]
        public IActionResult DeleteUser(int id)
        {
            var res = _usersService.DeleteUser(id);
            return Ok(res);
        }
    }
}
