namespace RonSijm.Flowmailer.Models;

public class FlowStepRewriteRecipient
{
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    [JsonProperty("recipientNameTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientNameTemplate { get; set; }
    [JsonProperty("recipientTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientTemplate { get; set; }
}