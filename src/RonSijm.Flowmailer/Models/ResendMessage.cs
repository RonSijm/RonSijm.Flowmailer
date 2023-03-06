namespace RonSijm.Flowmailer.Models;

public class ResendMessage
{
    [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientAddress { get; set; }
}