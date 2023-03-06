namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Multiple data sets
/// </summary>
public class DataSets
{
    /// <summary>
    /// Multiple data sets
    /// </summary>
    [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
    public DataSet[] List { get; set; }
}