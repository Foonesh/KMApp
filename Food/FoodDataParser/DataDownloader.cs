using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Food.FoodDataParser
{
    public static class DataDownloader
    {
        //https://ndb.nal.usda.gov/ndb/doc/apilist/API-FOOD-REPORT.md
        //API zwraca JSON


        public static async Task<string> DownloadItemData(string itemName)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("api_key", "T21BmgS4azRMC9kNqvTZI6LLs86tdoS71knqUrCd");
                HttpContent requestContent =
                    new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("API_KEY", "T21BmgS4azRMC9kNqvTZI6LLs86tdoS71knqUrCd"),
                        new KeyValuePair<string, string>("ndbno", "01009"),
                        new KeyValuePair<string, string>("type", "f"),
                        new KeyValuePair<string, string>("api_key", "T21BmgS4azRMC9kNqvTZI6LLs86tdoS71knqUrCd")
                    });

                requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await client.PostAsync("http://api.nal.usda.gov/ndb/reports", requestContent);

                using (StreamReader reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    // Write the output.
                    string result = await reader.ReadToEndAsync();
                    return result;
                }
            }
            
        }
    }
}
