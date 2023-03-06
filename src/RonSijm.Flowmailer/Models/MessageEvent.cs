namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Message event
/// </summary>
public class MessageEvent
{
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public string Data { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("deviceCategory", NullValueHandling = NullValueHandling.Ignore)]
    public string DeviceCategory { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("linkName", NullValueHandling = NullValueHandling.Ignore)]
    public string LinkName { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("linkTarget", NullValueHandling = NullValueHandling.Ignore)]
    public string LinkTarget { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("messageId", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageId { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("messageTags", NullValueHandling = NullValueHandling.Ignore)]
    public string[] MessageTags { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("mta", NullValueHandling = NullValueHandling.Ignore)]
    public string Mta { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("operatingSystem", NullValueHandling = NullValueHandling.Ignore)]
    public string OperatingSystem { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("operatingSystemVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string OperatingSystemVersion { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("received", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Received { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("referer", NullValueHandling = NullValueHandling.Ignore)]
    public string Referer { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("remoteAddr", NullValueHandling = NullValueHandling.Ignore)]
    public string RemoteAddr { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("snippet", NullValueHandling = NullValueHandling.Ignore)]
    public string Snippet { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
    public string UserAgent { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("userAgentDisplayName", NullValueHandling = NullValueHandling.Ignore)]
    public string UserAgentDisplayName { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("userAgentString", NullValueHandling = NullValueHandling.Ignore)]
    public string UserAgentString { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("userAgentType", NullValueHandling = NullValueHandling.Ignore)]
    public string UserAgentType { get; set; }
    /// <summary>
    /// Message event
    /// </summary>
    [JsonProperty("userAgentVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string UserAgentVersion { get; set; }
}