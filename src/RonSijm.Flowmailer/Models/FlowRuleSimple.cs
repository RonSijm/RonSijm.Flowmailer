namespace RonSijm.Flowmailer.Models;

/// <summary>
/// Conditions which must be true for a message to use a flow
/// </summary>
public class FlowRuleSimple
{
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("dataExpressions", NullValueHandling = NullValueHandling.Ignore)]
    public DataExpression[] DataExpressions { get; set; }
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("flowId", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowId { get; set; }
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("flowSelector", NullValueHandling = NullValueHandling.Ignore)]
    public string FlowSelector { get; set; }
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
    public Header[] Headers { get; set; }
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
    public string Sender { get; set; }
    /// <summary>
    /// Conditions which must be true for a message to use a flow
    /// </summary>
    [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceId { get; set; }
}