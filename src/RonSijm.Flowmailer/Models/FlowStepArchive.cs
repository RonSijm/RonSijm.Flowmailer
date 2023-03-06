namespace RonSijm.Flowmailer.Models;

public class FlowStepArchive
{
    [JsonProperty("onlineLink", NullValueHandling = NullValueHandling.Ignore)]
    public bool OnlineLink { get; set; }
    [JsonProperty("retention", NullValueHandling = NullValueHandling.Ignore)]
    public string Retention { get; set; }
}