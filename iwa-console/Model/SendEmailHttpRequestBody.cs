namespace iwa_console
{
    using Newtonsoft.Json;

    public class SendEmailHttpRequestBody
    {
        [JsonProperty("message")]
        public MyMessage Message { get; set; }
    }
}
