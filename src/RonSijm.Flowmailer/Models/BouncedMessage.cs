namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Undeliverable message
/// </summary>
public class BouncedMessage
{
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("backendDone", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BackendDone { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("backendStart", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BackendStart { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("bounceReceived", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BounceReceived { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("bounceSnippet", NullValueHandling = NullValueHandling.Ignore)]
    public string BounceSnippet { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("bounceSubType", NullValueHandling = NullValueHandling.Ignore)]
    public string BounceSubType { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("bounceType", NullValueHandling = NullValueHandling.Ignore)]
    public string BounceType { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
    public MessageEvent[] Events { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Flow { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
    public string From { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("fromAddress", NullValueHandling = NullValueHandling.Ignore)]
    public Address FromAddress { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("headersIn", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] HeadersIn { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("headersOut", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] HeadersOut { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("messageDetailsLink", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageDetailsLink { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("messageIdHeader", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageIdHeader { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("onlineLink", NullValueHandling = NullValueHandling.Ignore)]
    public string OnlineLink { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientAddress { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("senderAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderAddress { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Source { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("submitted", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Submitted { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Tags { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("toAddressList", NullValueHandling = NullValueHandling.Ignore)]
    public Address[] ToAddressList { get; set; }
    /// <summary>
    /// Undeliverable message
    /// </summary>
    [JsonProperty("transactionId", NullValueHandling = NullValueHandling.Ignore)]
    public string TransactionId { get; set; }
}