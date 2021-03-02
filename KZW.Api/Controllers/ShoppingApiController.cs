using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KZW.IPort;
using Newtonsoft.Json;
using KZW.Model;

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
        [HttpGet]
        [Route("/api/Pics/{num}")]
        public string GetPics(string num)
        {
            var ss = _shopping.GetPics(num);
            return JsonConvert.SerializeObject(ss);
        }
        [HttpGet]
        [Route("/api/AddInform/{In}")]
        public int AddInform(Information In)
        {
            var ss = _shopping.AddInform(In);
            return ss;
        }
        [HttpGet]
        [Route("/api/EditInform/{type}/{id}")]
        public int EditInform(int type, int id)
        {
            var ss = _shopping.EditInform(type, id);
            return ss;
        }
    }
}
