namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Generic resource model with an ID and description.
/// </summary>
public class ObjectDescription
{
    /// <summary>
    /// Generic resource model with an ID and description.
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    /// <summary>
    /// Generic resource model with an ID and description.
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
}