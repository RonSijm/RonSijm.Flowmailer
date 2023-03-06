namespace RonSijm.Flowmailer.Models;

public class FlowStepAddAttachment
{
    [JsonProperty("urlTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string UrlTemplate { get; set; }
}