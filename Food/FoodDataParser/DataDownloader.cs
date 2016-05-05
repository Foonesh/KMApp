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


        /// <summary>
        /// Downloads and returns the JSON data of a specified product from http://api.nal.usda.gov/ndb/reports/
        /// </summary>
        /// <param name="itemNumber">Number of item to download </param>
        /// <param name="type">Report type: [b]asic or [f]ull or [s]tats</param>
        /// <param name="apiKey">Api key from ndb.nal.usda.gov</param>
        /// <returns></returns>
        public static string DownloadItemData(
            string itemNumber,
            string type = "b",
            string apiKey = "T21BmgS4azRMC9kNqvTZI6LLs86tdoS71knqUrCd")
        {
            return DownloadItemDataTask(itemNumber, type, apiKey).Result;
        }

        public static async Task<string> DownloadItemDataTask(
            string itemNumber,
            string type = "b",
            string apiKey = "T21BmgS4azRMC9kNqvTZI6LLs86tdoS71knqUrCd")
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("api_key", apiKey);
                HttpContent requestContent = new FormUrlEncodedContent(new KeyValuePair<string, string>[0]);

                requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                StringBuilder requestMessage = new StringBuilder();
                requestMessage.Append("http://api.nal.usda.gov/ndb/reports/?")
                    .Append("ndbno=")
                    .Append(itemNumber)
                    .Append("&type=")
                    .Append(type)
                    .Append("&format=json")
                    .Append("&api_key=")
                    .Append(apiKey);

                HttpResponseMessage response = await client.PostAsync(requestMessage.ToString(), requestContent);

                using (StreamReader reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    string result = await reader.ReadToEndAsync();
                    return result;
                }
            }

        }
    }
}
