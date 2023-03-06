namespace RonSijm.Flowmailer.Models;

public class SimulateMessageResult
{
    [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
    public Attachment[] Attachments { get; set; }
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Object Data { get; set; }
    [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Flow { get; set; }
    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string Html { get; set; }
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }
}