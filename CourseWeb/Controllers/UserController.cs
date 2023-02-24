using System;
using System.Threading.Tasks;
using CourseProject.DAL.Interfaces;
using CourseProject.Domain.Entity;
using CourseProject.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace CourseWeb.Controllers
{
    public class UserController : Controller
    { 
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var response = await _userService.GetUsers();
            if (response.StatusCode == CourseProject.Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }
    }
}
