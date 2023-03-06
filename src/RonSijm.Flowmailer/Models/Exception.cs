namespace RonSijm.Flowmailer.Models;

public class Exception : System.Exception
{
    public Exception() : base()
    {
        
    }

    public Exception(string message, System.Exception innerException) : base(message, innerException)
    {

    }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
}