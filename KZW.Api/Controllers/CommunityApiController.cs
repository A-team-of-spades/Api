using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KZW.IPort;
using Microsoft.Extensions.Logging;

namespace KZW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        ICommunity _community;
        public CommunityApiController(ICommunity community)
        {
            _community = community;
        }
    }
}
