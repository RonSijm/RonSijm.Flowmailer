namespace RonSijm.Flowmailer.Models;

public class FlowStepResubmitMessage
{
    [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Account { get; set; }
    [JsonProperty("duplicateMessage", NullValueHandling = NullValueHandling.Ignore)]
    public bool DuplicateMessage { get; set; }
    [JsonProperty("flowSelector", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowSelector { get; set; }
    [JsonProperty("headerName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderName { get; set; }
    [JsonProperty("headerValue", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderValue { get; set; }
    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Source { get; set; }
}