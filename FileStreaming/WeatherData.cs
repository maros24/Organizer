using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BusinessLogic
{
    public class WeatherData
    {
        public static void GetWeather()
        {
            string city;
            Console.Write("Enter a city- ");
            city = Console.ReadLine();

            using (WebClient wc = new WebClient())
            {
                string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=6f529c8327ba3ddaaa534da24ba75e12";
                string json = wc.DownloadString(weburl);
                var weather = JsonConvert.DeserializeObject<MyWeather>(json);
          

               // XmlDocument doc = new XmlDocument();
               // var response = JsonConvert.DeserializeObject<MyWeather>(json);
               //  doc.Load(new StringReader(xml));
               // string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
               //double temp = double.Parse(szTemp) - 273.16;
               //Console.WriteLine(temp.ToString("N2") + " Celcius");
                Console.WriteLine("Weather :"+weather.Name);
            }
        }
    }
    public class MyWeather
    {
       
        [JsonProperty("temp")]
        public double temp
        {
            get; set;
                
        }

        [JsonProperty("name")]
        public string Name
        {
            get; set;
        }

        [JsonProperty("cod")]
        public int Cod
        {
            get; set;
        }
    }
}

