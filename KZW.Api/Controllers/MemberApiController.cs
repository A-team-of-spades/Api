using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KZW.IPort;
using Newtonsoft.Json;
using KZW.BLL;

namespace KZW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IMember _member;
        public MemberApiController(IMember member)
        {
            _member = member;
        }


        [HttpGet]
        [Route("/api/show")]
        public string Show()
        {
            var ss = _member.Show();
            return JsonConvert.SerializeObject(ss);
        }
    }
}
