namespace RonSijm.Flowmailer.Models;

/// <summary>
/// a SenderDomain configures which return-path and online tracking domain is used to send messages
/// </summary>
public class SenderDomain
{
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("dnsRecords", NullValueHandling = NullValueHandling.Ignore)]
    public DnsRecord[] DnsRecords { get; set; }
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("returnPathDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string ReturnPathDomain { get; set; }
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("senderDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string SenderDomainValue { get; set; }
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
    public Error[] Warnings { get; set; }
    /// <summary>
    /// a SenderDomain configures which return-path and online tracking domain is used to send messages
    /// </summary>
    [JsonProperty("webDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string WebDomain { get; set; }
}