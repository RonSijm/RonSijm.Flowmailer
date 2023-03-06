namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Message flow
/// </summary>
public class Flow
{
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("messageSummary", NullValueHandling = NullValueHandling.Ignore)]
    public MessageSummary MessageSummary { get; set; }
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
    public Sample[] Statistics { get; set; }
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStep[] Steps { get; set; }
    /// <summary>
    /// Message flow
    /// </summary>
    [JsonProperty("templateId", NullValueHandling = NullValueHandling.Ignore)]
    public string TemplateId { get; set; }
}