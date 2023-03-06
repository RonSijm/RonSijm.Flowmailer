namespace RonSijm.Flowmailer.Models;

public class FlowStepAggregate
{
    [JsonProperty("alwaysSendFirst", NullValueHandling = NullValueHandling.Ignore)]
    public bool AlwaysSendFirst { get; set; }
    [JsonProperty("maxTimeSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public int MaxTimeSeconds { get; set; }
    [JsonProperty("quietTimeSeconds", NullValueHandling = NullValueHandling.Ignore)]
    public int QuietTimeSeconds { get; set; }
}