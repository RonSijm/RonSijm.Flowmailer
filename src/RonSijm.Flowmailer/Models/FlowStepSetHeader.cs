namespace RonSijm.Flowmailer.Models;

public class FlowStepSetHeader
{
    [JsonProperty("headerName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderName { get; set; }
    [JsonProperty("headerValue", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderValue { get; set; }
}