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
    public class ShoppingApiController : ControllerBase
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IShopping _shopping;
        public ShoppingApiController(IShopping shopping)
        {
            _shopping = shopping;
        }
    }
}
