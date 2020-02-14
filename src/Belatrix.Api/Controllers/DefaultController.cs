﻿using Microsoft.AspNetCore.Mvc;

namespace Belatrix.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Running";
        }
    }
}
