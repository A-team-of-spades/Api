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
    public class GoodsApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IGoods _goods;
        public GoodsApiController(IGoods goods)
        {
            _goods = goods;
        }
    }
}
