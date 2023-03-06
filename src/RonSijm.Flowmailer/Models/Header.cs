namespace RonSijm.Flowmailer.Models;

public class Header
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}