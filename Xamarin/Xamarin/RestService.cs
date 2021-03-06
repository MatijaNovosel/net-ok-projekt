using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Models;

namespace Xamarin
{
    class RestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
        }

        public async Task<List<Product>> GetProducts()
        {
            Uri uri = new Uri("https://webshopauth20210304235128.azurewebsites.net/api/items");
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<List<Product>>(content);
                return Items;
            }
            return new List<Product>();
        }
    }
}
