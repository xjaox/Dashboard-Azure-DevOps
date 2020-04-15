using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DashboardDevOps.Models;
using DashboardDevOps.Interface;
using DashboardDevOps.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace DashboardDevOps.Controllers
{    public class LoginController : Controller
    {
        
        private readonly ILogger<LoginController> _logger;
        private readonly ILogin _login;
        
        
        public LoginController(ILogger<LoginController> logger, ILogin login)
        {
            this._logger = logger;
            this._login = login;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login([FromBody]VLogin data)
        {  
            return Json(this._login.CheckAccess(data.user, data.pass));
        }
    }
}
