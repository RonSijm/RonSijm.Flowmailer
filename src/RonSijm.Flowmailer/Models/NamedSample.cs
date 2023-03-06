namespace RonSijm.Flowmailer.Models;

public class NamedSample
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
    [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
    public bool Other { get; set; }
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public int Value { get; set; }
}