namespace RonSijm.Flowmailer.Models;

public class InboundRecipient
{
    [JsonProperty("destinationRecipient", NullValueHandling = NullValueHandling.Ignore)]
    public string DestinationRecipient { get; set; }
    [JsonProperty("inboundAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string InboundAddress { get; set; }
}