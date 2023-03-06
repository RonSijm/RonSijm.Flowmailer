namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Information about a source system
/// </summary>
public class Source
{
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("dsnAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string DsnAddress { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("dsnDisable", NullValueHandling = NullValueHandling.Ignore)]
    public bool DsnDisable { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("feedbackLoopAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string FeedbackLoopAddress { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("humanReadableDsnAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string HumanReadableDsnAddress { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("humanReadableDsnEnable", NullValueHandling = NullValueHandling.Ignore)]
    public bool HumanReadableDsnEnable { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("lastActive", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime LastActive { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("maxMessageSize", NullValueHandling = NullValueHandling.Ignore)]
    public int MaxMessageSize { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("messageSummary", NullValueHandling = NullValueHandling.Ignore)]
    public MessageSummary MessageSummary { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
    public Sample[] Statistics { get; set; }
    /// <summary>
    /// Information about a source system
    /// </summary>
    [JsonProperty("tlsRequired", NullValueHandling = NullValueHandling.Ignore)]
    public bool TlsRequired { get; set; }
}