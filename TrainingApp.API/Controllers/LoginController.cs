using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public List<string> GetUsers()
        {
            return new List<string>() 
            {
                "coquito 1",
                "coquito 2",
                "coquito 3",
                "coquito 4",
                "coquito 5",
                "coquito 6",
                "coquito 7",
                "coquito 8",
            };
        }
    }
}
