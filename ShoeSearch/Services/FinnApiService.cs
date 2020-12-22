using Microsoft.AspNetCore.Hosting;
using ShoeSearch.Api;
using ShoeSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoeSearch.Services
{
    public class FinnApiService
    {
        public FinnApiService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public async Task<IEnumerable<Item>> GetProducts(string itemName, int pageNr)
        {
            string param = String.Format("?searchkey=SEARCH_ID_BAP_COMMON&q={0}&page={1}", itemName, pageNr);
            using (HttpResponseMessage response = await ApiHandler.ApiClient.GetAsync(param))
            {
                if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
                System.IO.Stream responseStream = await response.Content.ReadAsStreamAsync();
                var json = await JsonSerializer.DeserializeAsync<FinnModel>(responseStream);
                return json.items;
            }
        }
    }
}
