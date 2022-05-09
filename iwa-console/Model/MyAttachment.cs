namespace iwa_console
{
    using Newtonsoft.Json;

    public class MyAttachment
    {
        [JsonProperty("@odata.type")]
        public string Odatatype { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentBytes")]
        public string ContentBytes { get; set; }
    }
}
