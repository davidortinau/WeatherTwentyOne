namespace WeatherTwentyOne.Models
{

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Minimum
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Maximum
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Temperature
    {
        [JsonProperty("minimum")]
        public Minimum Minimum { get; set; }

        [JsonProperty("maximum")]
        public Maximum Maximum { get; set; }
    }

    public class Day
    {
        [JsonProperty("phrase")]
        public string Phrase { get; set; }
    }

    public class Night
    {
        [JsonProperty("phrase")]
        public string Phrase { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("temperature")]
        public Temperature Temperature { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("night")]
        public Night Night { get; set; }
    }

    public class DailyForecastsPayload
    {
        [JsonProperty("forecasts")]
        public List<Forecast> Forecasts { get; set; }
    }
}