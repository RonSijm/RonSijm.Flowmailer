namespace RonSijm.Flowmailer.Models;

/// <summary>
/// A flowmailer content template
/// </summary>
public class Template
{
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("contentId", NullValueHandling = NullValueHandling.Ignore)]
    public string ContentId { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public string Data { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("decodeBase64", NullValueHandling = NullValueHandling.Ignore)]
    public bool DecodeBase64 { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("disposition", NullValueHandling = NullValueHandling.Ignore)]
    public string Disposition { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
    public string Filename { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
    public string MimeType { get; set; }
    /// <summary>
    /// A flowmailer content template
    /// </summary>
    [JsonProperty("templateEngine", NullValueHandling = NullValueHandling.Ignore)]
    public string TemplateEngine { get; set; }
}