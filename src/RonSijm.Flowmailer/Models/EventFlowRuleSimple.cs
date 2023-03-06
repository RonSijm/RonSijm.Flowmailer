namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Conditions which must be true for a event to use a flow
/// </summary>
public class EventFlowRuleSimple
{
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("dataExpression", NullValueHandling = NullValueHandling.Ignore)]
    public DataExpression DataExpression { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("dataExpressionValue", NullValueHandling = NullValueHandling.Ignore)]
    public string DataExpressionValue { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("dataExpressions", NullValueHandling = NullValueHandling.Ignore)]
    public DataExpression[] DataExpressions { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("eventFlowId", NullValueHandling = NullValueHandling.Ignore)]
    public string EventFlowId { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
    public string EventType { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
    public Header Header { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("headerValue", NullValueHandling = NullValueHandling.Ignore)]
    public string HeaderValue { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] Headers { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("linkName", NullValueHandling = NullValueHandling.Ignore)]
    public string LinkName { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("linkTarget", NullValueHandling = NullValueHandling.Ignore)]
    public string LinkTarget { get; set; }
    /// <summary>
    /// Conditions which must be true for a event to use a flow
    /// </summary>
    [JsonProperty("messageFlowId", NullValueHandling = NullValueHandling.Ignore)]
    public string MessageFlowId { get; set; }
}