namespace iwa_console
{
    using Newtonsoft.Json;

    public class MyEmailAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

}
