namespace RonSijm.Flowmailer.Models;

public class FlowStepExternalData
{
    [JsonProperty("fullResponseInVariable", NullValueHandling = NullValueHandling.Ignore)]
    public bool FullResponseInVariable { get; set; }
    [JsonProperty("requestBodyTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string RequestBodyTemplate { get; set; }
    [JsonProperty("requestHeaders", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] RequestHeaders { get; set; }
    [JsonProperty("requestMethod", NullValueHandling = NullValueHandling.Ignore)]
    public string RequestMethod { get; set; }
    [JsonProperty("resultFormat", NullValueHandling = NullValueHandling.Ignore)]
    public string ResultFormat { get; set; }
    [JsonProperty("resultVariable", NullValueHandling = NullValueHandling.Ignore)]
    public string ResultVariable { get; set; }
    [JsonProperty("urlTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string UrlTemplate { get; set; }
}