using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telegram.Bots.Requests.Stickers;
using WeatherTelegramBot.Models;

namespace WeatherTelegramBot.Service
{
    public class ApiService
    {
        public static async Task<Root> GetWeather(double latitue, double longitude)
        {
            var client = new HttpClient();
            var responce = await client.GetStringAsync(string.Format($"https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid=11fab17a28491dcf0681cb5e98165e4e", latitue, longitude));

            return JsonConvert.DeserializeObject<Root>(responce);

        }
        //public static async Task<string> GetCity()
        //{

        //}
    }
}
