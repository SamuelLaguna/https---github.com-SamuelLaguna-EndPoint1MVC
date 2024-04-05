using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniCH1MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet("/sayHello")]
        public string sayHello(string name){
            string result = "Hello my name is " + name;
            return result; 
        }
    }
}