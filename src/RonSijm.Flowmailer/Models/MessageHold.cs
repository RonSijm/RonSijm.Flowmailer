namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Messages that could not be processed
/// </summary>
public class MessageHold
{
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("backendDone", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime BackendDone { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public string Data { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("dataCoding", NullValueHandling = NullValueHandling.Ignore)]
    public byte DataCoding { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("errorText", NullValueHandling = NullValueHandling.Ignore)]
    public string ErrorText { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("extraData", NullValueHandling = NullValueHandling.Ignore)]
    public Object ExtraData { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Flow { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("messageId", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageId { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("messageType", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageType { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
    public string Reason { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
    public string Recipient { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
    public string Sender { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Source { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("submitted", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Submitted { get; set; }
    /// <summary>
    /// Messages that could not be processed
    /// </summary>
    [JsonProperty("transactionId", NullValueHandling = NullValueHandling.Ignore)]
    public string TransactionId { get; set; }
}