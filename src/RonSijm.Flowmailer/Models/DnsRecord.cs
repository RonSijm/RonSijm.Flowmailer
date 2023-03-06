namespace RonSijm.Flowmailer.Models;

/// <summary>
/// DNS record that should be configured
/// </summary>
public class DnsRecord
{
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("errorMessages", NullValueHandling = NullValueHandling.Ignore)]
    public string[] ErrorMessages { get; set; }
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
    /// <summary>
    /// DNS record that should be configured
    /// </summary>
    [JsonProperty("warningMessages", NullValueHandling = NullValueHandling.Ignore)]
    public string[] WarningMessages { get; set; }
}