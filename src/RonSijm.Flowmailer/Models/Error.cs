namespace RonSijm.Flowmailer.Models;

public class Error
{
    [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
    public Object[] Arguments { get; set; }
    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public string Code { get; set; }
    [JsonProperty("defaultMessage", NullValueHandling = NullValueHandling.Ignore)]
    public string DefaultMessage { get; set; }
    [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
    public string Field { get; set; }
    [JsonProperty("objectName", NullValueHandling = NullValueHandling.Ignore)]
    public string ObjectName { get; set; }
    [JsonProperty("rejectedValue", NullValueHandling = NullValueHandling.Ignore)]
    public Object RejectedValue { get; set; }
}