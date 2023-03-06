namespace RonSijm.Flowmailer.Models;

public class Sample
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Timestamp { get; set; }
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public int Value { get; set; }
}