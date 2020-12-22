using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeSearch.Models;
using ShoeSearch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSearch.Controllers
{
    [Route("api")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public ItemController(FinnApiService finnApiService)
        {
            this.FinnApiService = finnApiService;
        }

        public FinnApiService FinnApiService { get; }

        [HttpGet]
        public async Task<IEnumerable<Item>> Get(string itemName, int pageNr)
        {
            return await FinnApiService.GetProducts(itemName, pageNr);
        }
    }
}
