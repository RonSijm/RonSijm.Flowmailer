namespace RonSijm.Flowmailer.Models;

public class Errors
{
    [JsonProperty("allErrors", NullValueHandling = NullValueHandling.Ignore)]
    public Error[] AllErrors { get; set; }
}