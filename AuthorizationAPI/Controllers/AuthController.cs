﻿using AuthorizationAPI.Model;
using AuthorizationAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AuthorizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthController));
        private readonly IPensionRepo repo;
        

        public AuthController(IConfiguration config,IPensionRepo _repo)
        {
            _config = config;
            repo = _repo;
        }

        /// <summary>
        /// Post method for Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns> Authnetication Token </returns>

        [HttpPost]
        public IActionResult Login([FromBody] PensionCredentials login)
        {
            AuthRepo auth_repo = new AuthRepo(_config,repo);
            _log4net.Info("Login initiated!");
            IActionResult response = Unauthorized();
            //login.FullName = "user1";
            var user = auth_repo.AuthenticateUser(login);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                var tokenString = auth_repo.GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }
       
    }
}
