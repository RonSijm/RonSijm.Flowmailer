namespace RonSijm.Flowmailer.Models;

public class FlowStepExternalContent
{
    [JsonProperty("resultVariable", NullValueHandling = NullValueHandling.Ignore)]
    public string ResultVariable { get; set; }
    [JsonProperty("urlTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string UrlTemplate { get; set; }
}