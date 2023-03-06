namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Message statistics summary
/// </summary>
public class MessageSummary
{
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("averageDeliverTimeMillis", NullValueHandling = NullValueHandling.Ignore)]
    public int AverageDeliverTimeMillis { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("clicked", NullValueHandling = NullValueHandling.Ignore)]
    public int Clicked { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("delivered", NullValueHandling = NullValueHandling.Ignore)]
    public int Delivered { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("opened", NullValueHandling = NullValueHandling.Ignore)]
    public int Opened { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("processed", NullValueHandling = NullValueHandling.Ignore)]
    public int Processed { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
    public int Sent { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("uniqueClicked", NullValueHandling = NullValueHandling.Ignore)]
    public int UniqueClicked { get; set; }
    /// <summary>
    /// Message statistics summary
    /// </summary>
    [JsonProperty("uniqueOpened", NullValueHandling = NullValueHandling.Ignore)]
    public int UniqueOpened { get; set; }
}