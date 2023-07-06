using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebAppTestAPI.DBModels;
using MVCWebAppTestAPI.Models;
using System.Security.Cryptography;

namespace MVCWebAppTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly ICandidateContext _db;
        
        public UserController() 
        { 
       
        }

       
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
      
        }

        [HttpGet("UserDashboard")]
        public async Task<IActionResult> UserDashboard()
        {
           
        }
    }
}
