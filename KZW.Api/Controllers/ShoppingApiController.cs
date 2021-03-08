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
        [HttpPost]
        [Route("/api/AddInform/{In}")]
        public int AddInform(Information In)
        {
            var ss = _shopping.AddInform(In);
            return ss;
        }
        [HttpPost]
        [Route("/api/EditInform/{type}/{id}")]
        public int EditInform(int type, int id)
        {
            var ss = _shopping.EditInform(type, id);
            return ss;
        }
        [HttpGet]
        [Route("/api/ChaShopping/{num}/{id}")]
        public List<SelAll> ChaShopping(string num, int id)
        {
            var ss = _shopping.ChaShopping(num, id);
            return ss;
        }
        [HttpGet]
        [Route("/api/GetAddres")]
        public List<Addres> GetAddres()
        {
            var ss = _shopping.GetAddres();
            return ss;
        }
        [HttpPost]
        [Route("/api/EditShopping/{sum}/{id}")]
        public int EditShopping(int sum, int id)
        {
            var ss = _shopping.EditShopping(sum, id);
            return ss;
        }
       
        
        
    }
}
