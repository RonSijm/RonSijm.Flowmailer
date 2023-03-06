namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Data set with statistics
/// </summary>
public class DataSet
{
    /// <summary>
    /// Data set with statistics
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
    /// <summary>
    /// Data set with statistics
    /// </summary>
    [JsonProperty("samples", NullValueHandling = NullValueHandling.Ignore)]
    public Sample[] Samples { get; set; }
}