namespace RonSijm.Flowmailer;

public interface IFlowMailerClient
{
    /// <summary>
    /// Get flow rule list for all event flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> GetEventFlowRules(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow rule list for all event flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> GetHierarchyByEventFlowRules(CancellationToken cancellationToken = default);

    /// <summary>
    /// List flows per account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<EventFlow>> ListEventFlows(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new flow
    /// <param name="request">Flow object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateEventFlows(EventFlow request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete flow by id
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteEventFlows(string event_flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow by id
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlow> GetEventFlows(string event_flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlow> SaveEventFlows(EventFlow request, string event_flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlowRuleSimple> GetRuleByEventFlows(string event_flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SetRuleByEventFlows(EventFlowRuleSimple request, string event_flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List filters per account
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the filter was added in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Filter>> ListFilters(ref_range range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a recipient from the filter
    /// <param name="filter_id">Filter ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteFilters(string filter_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow rule list for all flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> GetFlowRules(CancellationToken cancellationToken = default);

    /// <summary>
    /// List flow templates per account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<FlowTemplate>> ListFlowTemplates(CancellationToken cancellationToken = default);

    /// <summary>
    /// List flows per account
    /// <param name="statistics">Whether to return statistics per flow</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Flow>> ListFlows(bool statistics = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new flow
    /// <param name="request">Flow object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateFlows(Flow request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete flow by id
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteFlows(string flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow by id
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Flow> GetFlows(string flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Flow> SaveFlows(Flow request, string flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per flow
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="flow_id">Flow ID</param>
    /// <param name="range">Limits the returned list</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerFlow(date_range daterange, string flow_id, items_range range, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<FlowRuleSimple> GetRuleForFlow(string flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SetRuleForFlow(FlowRuleSimple request, string flow_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for a message flow
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flow_id">Flow ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetStatsForFlow(date_range daterange, string flow_id, int interval = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List message events
    /// <param name="range">Limits the returned list</param>
    /// <param name="addmessagetags">Message tags will be included with each event if this parameter is true</param>
    /// <param name="daterange"></param>
    /// <param name="flow_ids">Filter results on message flow ID</param>
    /// <param name="receivedrange"></param>
    /// <param name="sortorder"></param>
    /// <param name="source_ids">Filter results on message source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageEvent>> ListMessageEvents(ref_range range, bool addmessagetags = default, date_range daterange = default, List<string> flow_ids = default, date_range receivedrange = default, string sortorder = default, List<string> source_ids = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages which could not be processed
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageHold>> ListMessageHold(items_range range, date_range daterange = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a held message by its id
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<MessageHold> GetMessageHold(string message_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages
    /// <param name="range">Limits the returned list</param>
    /// <param name="addevents">Whether to add message events</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="flow_ids">Filter results on flow ID</param>
    /// <param name="sortfield">Sort by INSERTED or SUBMITTED (default INSERTED)</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, List<string> flow_ids = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulate an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SimulateMessageResult> SimulateMessages(SimulateMessage request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SendMessages(SubmitMessage request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get message by id
    /// <param name="message_id">Message ID</param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Message> GetMessages(string message_id, bool addtags = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List the message as archived by one or more flow steps
    /// <param name="message_id">Message ID</param>
    /// <param name="addattachments"></param>
    /// <param name="adddata"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageArchive>> ListArchiveByMessage(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch an attachment including data for an archived message
    /// <param name="content_id">Attachment content ID</param>
    /// <param name="flow_step_id">Flow step ID</param>
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Attachment> FetchAttachmentByArchiveAndMessageByFlowStepIdAndContentId(string content_id, string flow_step_id, string message_id, CancellationToken cancellationToken = default);

    Task<MessageArchive> GetErrorArchiveByMessages(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Resend message by id
    /// <param name="request"></param>
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> ResendMessages(ResendMessage request, string message_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for whole account
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flow_ids"></param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetMessagestats(date_range daterange, List<string> flow_ids = default, int interval = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get information about a recipient
    /// <param name="recipient">Recipient email address or phone number</param>
    /// <param name="daterange">Specifies the date range for message statistics</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Recipient> GetRecipient(string recipient, date_range daterange = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per recipient
    /// <param name="range">Limits the returned list</param>
    /// <param name="recipient">Recipient email address or phone number</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink">Whether to add online link</param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerRecipient(ref_range range, string recipient, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per sender
    /// <param name="range">Limits the returned list</param>
    /// <param name="sender">Sender email address or phone number</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink">Whether to add online link</param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerSender(ref_range range, string sender, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List sender domains by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<SenderDomain>> ListSenderDomains(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create sender domain
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateSenderDomains(SenderDomain request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender domain by domain name
    /// <param name="domain">Sender domain name</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomain> GetByDomainBySenderDomains(string domain, bool validate = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validates but does not save a sender domain.
    /// <param name="request">the sender domain to validate</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomain> ValidatesSenderDomains(SenderDomain request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete sender domain
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteSenderDomains(string domain_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender domain by id
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomain> GetSenderDomains(string domain_id, bool validate = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save sender domain
    /// <param name="request"></param>
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveSenderDomains(SenderDomain request, string domain_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List sender identities by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<SenderIdentity>> ListSenderIdentities(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create sender identity
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateSenderIdentities(SenderIdentity request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete sender identity
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender identity by id
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save sender identity
    /// <param name="request"></param>
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identity_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List source systems per account
    /// <param name="statistics">Whether to include message statistics or not</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Source>> ListSources(bool statistics = default, CancellationToken cancellationToken = default);

    Task<string> PostSources(Source request, CancellationToken cancellationToken = default);
    Task<string> DeleteSources(string source_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a source by id
    /// <param name="source_id">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Source> GetSources(string source_id, CancellationToken cancellationToken = default);

    Task<string> UpdateSources(Source request, string source_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per source
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="range">Limits the returned list</param>
    /// <param name="source_id">Source ID</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerSource(date_range daterange, items_range range, string source_id, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for a message source
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="source_id">Source ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetStatsForSource(date_range daterange, string source_id, int interval = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List credentials per source system
    /// <param name="source_id">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Credentials>> ListUsersPerSource(string source_id, CancellationToken cancellationToken = default);

    Task<Credentials> PostUsersBySources(Credentials request, string source_id, CancellationToken cancellationToken = default);
    Task<string> DeleteUsersBySources(string source_id, string user_id, CancellationToken cancellationToken = default);
    Task<Credentials> GetUsersBySources(string source_id, string user_id, CancellationToken cancellationToken = default);
    Task<Credentials> UpdateUsersBySources(Credentials request, string source_id, string user_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per tag
    /// <param name="range">Limits the returned list</param>
    /// <param name="tag">Tag</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink">Whether to add online link</param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerTag(ref_range range, string tag, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List templates by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Template>> ListTemplates(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create template
    /// <param name="request">Template object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateTemplates(Template request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete template by id
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteTemplates(string template_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get template by id
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Template> GetTemplates(string template_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save template
    /// <param name="request">Template object</param>
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveTemplates(Template request, string template_id, CancellationToken cancellationToken = default);

    /// <summary>
    /// List undeliverable messages
    /// <param name="range">Limits the returned list</param>
    /// <param name="addevents">Whether to add message events</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="receivedrange">Date range the message bounced</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<BouncedMessage>> ListUndeliveredmessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default);
}