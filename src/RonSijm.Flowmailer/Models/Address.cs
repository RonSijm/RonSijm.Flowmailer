namespace RonSijm.Flowmailer.Models;

public class AddressModel
{
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string Address { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}