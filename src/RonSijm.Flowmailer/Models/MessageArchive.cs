namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Archived message text and/or html
/// </summary>
public class MessageArchive
{
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
    public Attachment[] Attachments { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Object Data { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("flowStepId", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowStepId { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string Html { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("messageDetailsLink", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageDetailsLink { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("onlineLink", NullValueHandling = NullValueHandling.Ignore)]
    public string OnlineLink { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("onlineVersion", NullValueHandling = NullValueHandling.Ignore)]
    public bool OnlineVersion { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    /// <summary>
    /// Archived message text and/or html
    /// </summary>
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }
}