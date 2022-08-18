using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace BigApp
{
        public class GetValutes
        {
            public class MyJson
            {
                public int r030 { get; set; }
                public string txt { get; set; }
                public double rate { get; set; }
                public string cc { get; set; }
                public string exchangedate { get; set; }
            }


            public string respJson;
            HttpClient client = new HttpClient();

            public async Task GetResponse()
            {
                string response = await client.GetStringAsync(
                    "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");

                Console.WriteLine(response);

                respJson = response;
            }
            public async void GetParser()
            {
                GetValutes getValutes = new GetValutes();

                await getValutes.GetResponse();

                var response = getValutes.respJson;
                if (response == null)
                {
                    Console.Error.WriteLine("ERROR");
                }

                //var jsnConvert = JsonConvert.DeserializeObject<List<MyJson>>(response);

                //foreach (var currency in jsnConvert)
                //{
                //    Console.WriteLine(currency);
                //}
            }
        }
    }
