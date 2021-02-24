using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KZW.IPort;

namespace KZW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonageApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IPersonage _personage;
        public PersonageApiController(IPersonage personage)
        {
            _personage = personage;
        }
    }
}
