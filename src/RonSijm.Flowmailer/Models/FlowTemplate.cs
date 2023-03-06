namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Message flow template
/// </summary>
public class FlowTemplate
{
    /// <summary>
    /// Message flow template
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Message flow template
    /// </summary>
    [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
    public bool Editable { get; set; }
    /// <summary>
    /// Message flow template
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Message flow template
    /// </summary>
    [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStep[] Steps { get; set; }
    /// <summary>
    /// Message flow template
    /// </summary>
    [JsonProperty("templateId", NullValueHandling = NullValueHandling.Ignore)]
    public string TemplateId { get; set; }
}