namespace RonSijm.Flowmailer.Models;

public class DkimKey
{
    [JsonProperty("cnameTarget", NullValueHandling = NullValueHandling.Ignore)]
    public string CnameTarget { get; set; }
    [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
    public string Domain { get; set; }
    [JsonProperty("publicKey", NullValueHandling = NullValueHandling.Ignore)]
    public string PublicKey { get; set; }
    [JsonProperty("selector", NullValueHandling = NullValueHandling.Ignore)]
    public string Selector { get; set; }
}