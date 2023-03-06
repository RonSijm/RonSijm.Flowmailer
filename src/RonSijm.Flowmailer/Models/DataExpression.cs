namespace RonSijm.Flowmailer.Models;

public class DataExpression
{
    [JsonProperty("expression", NullValueHandling = NullValueHandling.Ignore)]
    public string Expression { get; set; }
    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}