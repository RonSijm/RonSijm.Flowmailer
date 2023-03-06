namespace RonSijm.Flowmailer.Models;

/// <summary>
/// A processing step in a flow
/// </summary>
public class FlowStep
{
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("addAttachment", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepAddAttachment AddAttachment { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("aggregate", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepAggregate Aggregate { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("applyToLinkDomains", NullValueHandling = NullValueHandling.Ignore)]
    public string ApplyToLinkDomains { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("archive", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepArchive Archive { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("divisor", NullValueHandling = NullValueHandling.Ignore)]
    public int Divisor { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("enabledExpression", NullValueHandling = NullValueHandling.Ignore)]
    public string EnabledExpression { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("errorOnNotFound", NullValueHandling = NullValueHandling.Ignore)]
    public bool ErrorOnNotFound { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("externalContent", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepExternalContent ExternalContent { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("externalData", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepExternalData ExternalData { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("extractData", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepExtractData ExtractData { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("mailPlusApiCredentials", NullValueHandling = NullValueHandling.Ignore)]
    public MailPlusAPICredentials MailPlusApiCredentials { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("overwriteUrlParameters", NullValueHandling = NullValueHandling.Ignore)]
    public bool OverwriteUrlParameters { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("resubmitMessage", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepResubmitMessage ResubmitMessage { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("rewriteRecipient", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepRewriteRecipient RewriteRecipient { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepSchedule Schedule { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("setHeader", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepSetHeader SetHeader { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("setSender", NullValueHandling = NullValueHandling.Ignore)]
    public FlowStepSetSender SetSender { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("subjectTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string SubjectTemplate { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
    public ObjectDescription Template { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
    public string To { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
    /// <summary>
    /// A processing step in a flow
    /// </summary>
    [JsonProperty("urlParametersTemplate", NullValueHandling = NullValueHandling.Ignore)]
    public string UrlParametersTemplate { get; set; }
}