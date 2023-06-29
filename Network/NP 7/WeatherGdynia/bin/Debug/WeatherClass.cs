using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherGdynia
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class City
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("coord")]
        public Coord coord { get; set; }

        [JsonPropertyName("country")]
        public string country { get; set; }

        [JsonPropertyName("population")]
        public int population { get; set; }

        [JsonPropertyName("timezone")]
        public int timezone { get; set; }

        [JsonPropertyName("sunrise")]
        public int sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public int sunset { get; set; }
    }

    public class Clouds
    {
        [JsonPropertyName("all")]
        public int all { get; set; }
    }

    public class Coord
    {
        [JsonPropertyName("lat")]
        public double lat { get; set; }

        [JsonPropertyName("lon")]
        public double lon { get; set; }
    }

    public class List
    {
        [JsonPropertyName("dt")]
        public int dt { get; set; }

        [JsonPropertyName("main")]
        public Main main { get; set; }

        [JsonPropertyName("weather")]
        public List<Weather> weather { get; set; }

        [JsonPropertyName("clouds")]
        public Clouds clouds { get; set; }

        [JsonPropertyName("wind")]
        public Wind wind { get; set; }

        [JsonPropertyName("visibility")]
        public int visibility { get; set; }

        [JsonPropertyName("pop")]
        public double pop { get; set; }

        [JsonPropertyName("rain")]
        public Rain rain { get; set; }

        [JsonPropertyName("sys")]
        public Sys sys { get; set; }

        [JsonPropertyName("dt_txt")]
        public string dt_txt { get; set; }
    }

    public class Main
    {
        [JsonPropertyName("temp")]
        public double temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double feels_like { get; set; }

        [JsonPropertyName("temp_min")]
        public double temp_min { get; set; }

        [JsonPropertyName("temp_max")]
        public double temp_max { get; set; }

        [JsonPropertyName("pressure")]
        public int pressure { get; set; }

        [JsonPropertyName("sea_level")]
        public int sea_level { get; set; }

        [JsonPropertyName("grnd_level")]
        public int grnd_level { get; set; }

        [JsonPropertyName("humidity")]
        public int humidity { get; set; }

        [JsonPropertyName("temp_kf")]
        public double temp_kf { get; set; }
    }

    public class Rain
    {
        [JsonPropertyName("3h")]
        public double _3h { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("cod")]
        public string cod { get; set; }

        [JsonPropertyName("message")]
        public int message { get; set; }

        [JsonPropertyName("cnt")]
        public int cnt { get; set; }

        [JsonPropertyName("list")]
        public List<List> list { get; set; }

        [JsonPropertyName("city")]
        public City city { get; set; }
    }

    public class Sys
    {
        [JsonPropertyName("pod")]
        public string pod { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("main")]
        public string main { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("icon")]
        public string icon { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("speed")]
        public double speed { get; set; }

        [JsonPropertyName("deg")]
        public int deg { get; set; }

        [JsonPropertyName("gust")]
        public double gust { get; set; }
    }


}
