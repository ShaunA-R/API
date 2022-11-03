using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MiniChallenge1Controller : ControllerBase
    {
        
        [HttpGet]
        [Route("MiniChallenge1/{name}")]
        public string minichallenge1(string name)
        {
            return $"Hello {name}";
        }
    }
