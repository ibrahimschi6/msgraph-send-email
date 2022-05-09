namespace iwa_console
{
    using Newtonsoft.Json;

    public class MyMessage
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public MyMessageBody Body { get; set; }

        [JsonProperty("toRecipients")]
        public MyToRecipients[] ToRecipients { get; set; }

        [JsonProperty("attachments")]
        public MyAttachment[] Attachments { get; set; }
    }
}
