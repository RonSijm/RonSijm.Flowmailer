namespace RonSijm.Flowmailer.Models;

public class SampleMessage
{
    [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Created { get; set; }
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }
    [JsonProperty("extraData", NullValueHandling = NullValueHandling.Ignore)]
    public Object ExtraData { get; set; }
    [JsonProperty("fromAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string FromAddress { get; set; }
    [JsonProperty("fromName", NullValueHandling = NullValueHandling.Ignore)]
    public string FromName { get; set; }
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    [JsonProperty("mimedata", NullValueHandling = NullValueHandling.Ignore)]
    public string Mimedata { get; set; }
    [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
    public string Sender { get; set; }
    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Source { get; set; }
}