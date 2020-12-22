using ShoeSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoeSearch.Api
{
    public class FinnProcessor
    {

        public async Task<FinnModel> SearchProducts(string itemName, int pageNr)
        {
            string param = String.Format("?searchkey=SEARCH_ID_BAP_COMMON&q={0}&page={1}", itemName, pageNr);
            using (HttpResponseMessage response = await ApiHandler.ApiClient.GetAsync(param))
            {
                if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);
                System.IO.Stream responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<FinnModel>(responseStream);
            }
        }
    }
}
