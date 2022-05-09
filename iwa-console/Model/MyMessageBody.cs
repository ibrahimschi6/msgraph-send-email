namespace iwa_console
{
    using Newtonsoft.Json;

    public class MyMessageBody
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
