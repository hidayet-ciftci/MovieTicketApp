using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult getAllUser()
        {
            try
            {
                var result = _userService.ListAll();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult getOneUser(int id)
        {
            try
            {
                var result = _userService.getOneById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult addUser(User user)
        {
            try
            {
                var result = _userService.Add(user);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult deleteUser(User user)
        {
            try
            {
                var result = _userService.Delete(user);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult updateUser(User user)
        {
            try
            {
                var result = _userService.Update(user);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
