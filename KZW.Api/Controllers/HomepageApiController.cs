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
    public class HomepageApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IHomepage _homepage;
        public HomepageApiController(IHomepage homepage)
        {
            _homepage = homepage;
        }
    }
}
