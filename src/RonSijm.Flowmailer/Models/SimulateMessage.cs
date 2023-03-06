namespace RonSijm.Flowmailer.Models;

public class SimulateMessage
{
    [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
    public Attachment[] Attachments { get; set; }
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Object Data { get; set; }
    [JsonProperty("deliveryNotificationType", NullValueHandling = NullValueHandling.Ignore)]
    public string DeliveryNotificationType { get; set; }
    [JsonProperty("flowSelector", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowSelector { get; set; }
    [JsonProperty("headerFromAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderFromAddress { get; set; }
    [JsonProperty("headerFromName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderFromName { get; set; }
    [JsonProperty("headerToAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderToAddress { get; set; }
    [JsonProperty("headerToName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderToName { get; set; }
    [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] Headers { get; set; }
    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string Html { get; set; }
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    [JsonProperty("mimedata", NullValueHandling = NullValueHandling.Ignore)]
    public string Mimedata { get; set; }
    [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientAddress { get; set; }
    [JsonProperty("scheduleAt", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime ScheduleAt { get; set; }
    [JsonProperty("senderAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderAddress { get; set; }
    [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceId { get; set; }
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Tags { get; set; }
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }
}