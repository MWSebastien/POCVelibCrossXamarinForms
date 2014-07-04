using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using POC.Models;

namespace POC.ViewModels
{
    public class RestService : IRestService
    {

        public async Task<List<Velib>> GetVelib()
        {
            try
            {
                //await Task.Delay(TimeSpan.FromSeconds(10));

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://api.jcdecaux.com/vls/v1/stations/?contract=Paris&apiKey=fe8e31e1684acf2b17499f6bb4db09be9fba459e");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("");

                string content = await response.Content.ReadAsStringAsync();

                var list = JsonConvert.DeserializeObject<List<Velib>>(content);

                return list;
            }
            catch (Exception ex)
            {
                var t = ex.Message;
            }
            return new List<Velib>();
        }



    }
}
