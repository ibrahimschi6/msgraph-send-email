namespace iwa_console
{
    using Newtonsoft.Json;
    public class MyToRecipients
    {
        [JsonProperty("emailAddress")]
        public MyEmailAddress EmailAddress { get; set; }
    }
}
