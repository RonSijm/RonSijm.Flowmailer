namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Event flow
/// </summary>
public class EventFlow
{
    /// <summary>
    /// Event flow
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Event flow
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Event flow
    /// </summary>
    [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
    public string ParentId { get; set; }
    /// <summary>
    /// Event flow
    /// </summary>
    [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStep[] Steps { get; set; }
}