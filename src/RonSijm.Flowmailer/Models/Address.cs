namespace RonSijm.Flowmailer.Models;

public class Address
{
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string AddressValue { get; set; }
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}