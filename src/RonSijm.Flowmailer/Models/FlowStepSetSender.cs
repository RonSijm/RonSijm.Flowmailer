namespace RonSijm.Flowmailer.Models;

public class FlowStepSetSender
{
    [JsonProperty("senderNameTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderNameTemplate { get; set; }
    [JsonProperty("senderSetName", NullValueHandling = NullValueHandling.Ignore)]
    public bool SenderSetName { get; set; }
    [JsonProperty("senderTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderTemplate { get; set; }
}