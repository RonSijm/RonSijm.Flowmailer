namespace RonSijm.Flowmailer.Models;

/// <summary>
/// An email or sms message that can be submitted to Flowmailer.
/// </summary>
public class SubmitMessage
{
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
    public Attachment[] Attachments { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Object Data { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("deliveryNotificationType", NullValueHandling = NullValueHandling.Ignore)]
    public string DeliveryNotificationType { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("flowSelector", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowSelector { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("headerFromAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderFromAddress { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("headerFromName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderFromName { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("headerToAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderToAddress { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("headerToName", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderToName { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] Headers { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string Html { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("mimedata", NullValueHandling = NullValueHandling.Ignore)]
    public string Mimedata { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientAddress { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("scheduleAt", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime ScheduleAt { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("senderAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderAddress { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Tags { get; set; }
    /// <summary>
    /// An email or sms message that can be submitted to Flowmailer.
    /// </summary>
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }
}