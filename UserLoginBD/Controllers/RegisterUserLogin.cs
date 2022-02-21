using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UserLoginBD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterUserLogin : Controller
    {
        public SqlOper sqlOper;


        [HttpPost]
        public StatusCodeResult AddUser(string login, string email, DateTime bday, string password)
        {
            
            
        }
        
    }
}
