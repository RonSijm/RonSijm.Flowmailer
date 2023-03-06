namespace RonSijm.Flowmailer.Models;

public class FlowStepExtractData
{
    [JsonProperty("dataType", NullValueHandling = NullValueHandling.Ignore)]
    public string DataType { get; set; }
    [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
    public string Filename { get; set; }
    [JsonProperty("htmlDecodeText", NullValueHandling = NullValueHandling.Ignore)]
    public bool HtmlDecodeText { get; set; }
    [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
    public string MimeType { get; set; }
    [JsonProperty("removeMimePart", NullValueHandling = NullValueHandling.Ignore)]
    public bool RemoveMimePart { get; set; }
    [JsonProperty("selector", NullValueHandling = NullValueHandling.Ignore)]
    public string Selector { get; set; }
}