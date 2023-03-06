namespace RonSijm.Flowmailer.Models;

public class Message
{
    [JsonProperty("backendDone", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BackendDone { get; set; }
    [JsonProperty("backendStart", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BackendStart { get; set; }
    [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
    public MessageEvent[] Events { get; set; }
    [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Flow { get; set; }
    [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
    public string From { get; set; }
    [JsonProperty("fromAddress", NullValueHandling = NullValueHandling.Ignore)]
    public Address FromAddress { get; set; }
    [JsonProperty("headersIn", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] HeadersIn { get; set; }
    [JsonProperty("headersOut", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] HeadersOut { get; set; }
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    [JsonProperty("messageDetailsLink", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageDetailsLink { get; set; }
    [JsonProperty("messageIdHeader", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageIdHeader { get; set; }
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    [JsonProperty("onlineLink", NullValueHandling = NullValueHandling.Ignore)]
    public string OnlineLink { get; set; }
    [JsonProperty("recipientAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string RecipientAddress { get; set; }
    [JsonProperty("senderAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderAddress { get; set; }
    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Source { get; set; }
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }
    [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
    public string Subject { get; set; }
    [JsonProperty("submitted", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Submitted { get; set; }
    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Tags { get; set; }
    [JsonProperty("toAddressList", NullValueHandling = NullValueHandling.Ignore)]
    public Address[] ToAddressList { get; set; }
    [JsonProperty("transactionId", NullValueHandling = NullValueHandling.Ignore)]
    public string TransactionId { get; set; }
}