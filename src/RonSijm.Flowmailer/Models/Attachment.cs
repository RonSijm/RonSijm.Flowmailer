namespace RonSijm.Flowmailer.Models;

public class Attachment
{
    [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
    public string Content { get; set; }
    [JsonProperty("contentId", NullValueHandling = NullValueHandling.Ignore)]
    public string ContentId { get; set; }
    [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
    public string ContentType { get; set; }
    [JsonProperty("disposition", NullValueHandling = NullValueHandling.Ignore)]
    public string Disposition { get; set; }
    [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
    public string Filename { get; set; }
}