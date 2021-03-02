using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KZW.IPort;
using KZW.Model;
using KZW.Model.New.lj;
using Newtonsoft.Json;

namespace KZW.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class GoodsApiController : BaseController
    {
        /// <summary>
        /// 注入依赖
        /// </summary>
        IGoods _goods;
        public GoodsApiController(IGoods goods)
        {
            _goods = goods;
        }

        
        [Route("/api/GetDiscounts")]
        [HttpGet]
        public string GetDiscounts()
        {
            return JsonConvert.SerializeObject(_goods.GetDiscounts());
        }

        [Route("/api/GetGoods")]
        [HttpGet]
        public List<GoodsAllModel> GetGoods()
        {
            return _goods.GetGoods();
        }

        [Route("/api/GetGoodsDetails")]
        [HttpGet]
        public List<GoodsAllModel> GetGoodsDetails()
        {
            return _goods.GetGoodsDetails();
        }

        [Route("/api/GetGoodsEvaluate")]
        [HttpGet]
        public List<GoodsAllModel> GetGoodsEvaluate()
        {
            return _goods.GetGoodsEvaluate();
        }

        [Route("/api/GetAddress")]
        [HttpGet]
        public string GetAddress()
        {
            return JsonConvert.SerializeObject(_goods.GetAddress());
        }

        [Route("/api/AddGoodsEvaluate")]
        [HttpPost]
        public int AddGoodsEvaluate(GoodsAllModel good)
        {
            return _goods.AddGoodsEvaluate(good);
        }

        [Route("/api/AddUsersDis")]
        [HttpPost]
        public int AddUsersDis(UsersDis dis)
        {
            return _goods.AddUsersDis(dis);
        }
    }
}
