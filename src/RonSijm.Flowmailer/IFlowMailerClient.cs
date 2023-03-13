using System.Net.Http.Headers;

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
    Task<string> GetHierarchyFlowEventFlowRules(CancellationToken cancellationToken = default);

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
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow by id
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlow> GetEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlow> SaveEventByEventFlowId(EventFlow request, string eventFlowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<EventFlowRuleSimple> GetRuleForAEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SetRuleForAEventByEventFlowId(EventFlowRuleSimple request, string eventFlowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List filters per account
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the filter was added in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Filter>> ListFilters(RangeHeaderValue range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a recipient from the filter
    /// <param name="filterId">Filter ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteFilter(string filterId, CancellationToken cancellationToken = default);

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
    Task<List<Flow>> ListFlows(bool statistics = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new flow
    /// <param name="request">Flow object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateFlow(Flow request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete flow by id
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteFlow(string flowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow by id
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Flow> GetFlow(string flowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Flow> SaveFlow(Flow request, string flowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per flow
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="range">Limits the returned list</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerFlow(date_range daterange, string flowId, items_range range, bool addheaders = false, bool addonlinelink = false, bool addtags = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<FlowRuleSimple> GetRuleForAFlowConditions(string flowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SetRuleForAFlow(FlowRuleSimple request, string flowId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for a message flow
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetStatisticsForAFlow(date_range daterange, string flowId, int interval = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List message events
    /// <param name="range">Limits the returned list</param>
    /// <param name="addmessagetags">Message tags will be included with each event if this parameter is true</param>
    /// <param name="daterange"></param>
    /// <param name="flowIds">Filter results on message flow ID</param>
    /// <param name="receivedrange"></param>
    /// <param name="sortorder"></param>
    /// <param name="sourceIds">Filter results on message source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageEvent>> ListMessageEvents(RangeHeaderValue range, bool addmessagetags = false, date_range daterange = default, List<string> flowIds = default, date_range receivedrange = default, string sortorder = default, List<string> sourceIds = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages which could not be processed
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageHold>> ListMessageHold(items_range range, date_range daterange = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a held message by its id
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<MessageHold> GetMessageHold(string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages
    /// <param name="range">Limits the returned list</param>
    /// <param name="addevents">Whether to add message events</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="flowIds">Filter results on flow ID</param>
    /// <param name="sortfield">Sort by INSERTED or SUBMITTED (default INSERTED)</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessages(RangeHeaderValue range, bool addevents = false, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, List<string> flowIds = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulate an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SimulateMessageResult> SimulateMessage(SimulateMessage request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Send an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SubmitMessage(SubmitMessage request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get message by id
    /// <param name="messageId">Message ID</param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Message> GetMessage(string messageId, bool addtags = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// List the message as archived by one or more flow steps
    /// <param name="messageId">Message ID</param>
    /// <param name="addattachments"></param>
    /// <param name="adddata"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<MessageArchive>> ListArchivedAsMessage(string messageId, bool addattachments = false, bool adddata = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetch an attachment including data for an archived message
    /// <param name="contentId">Attachment content ID</param>
    /// <param name="flowStepId">Flow step ID</param>
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Attachment> FetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId(string contentId, string flowStepId, string messageId, CancellationToken cancellationToken = default);

    Task<MessageArchive> GetErrorArchiveByMessages(string messageId, bool addattachments = false, bool adddata = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Resend message by id
    /// <param name="request"></param>
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> ResendMessage(ResendMessage request, string messageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for whole account
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flowIds"></param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetMessageStats(date_range daterange, List<string> flowIds = default, int interval = default, CancellationToken cancellationToken = default);

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
    Task<List<Message>> ListMessagesPerRecipient(RangeHeaderValue range, string recipient, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

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
    Task<List<Message>> ListMessagesPerSender(RangeHeaderValue range, string sender, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List sender domains by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<SenderDomainModel>> ListSenderDomains(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create sender domain
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> CreateSenderDomains(SenderDomainModel request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender domain by domain name
    /// <param name="domain">Sender domain name</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomainModel> GetByBySenderDomains(string domain, bool validate = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validates but does not save a sender domain.
    /// <param name="request">the sender domain to validate</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomainModel> ValidatesSenderDomains(SenderDomainModel request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete sender domain
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteSenderDomains(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender domain by id
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderDomainModel> GetSenderDomains(string domainId, bool validate = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save sender domain
    /// <param name="request"></param>
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveSenderDomains(SenderDomainModel request, string domainId, CancellationToken cancellationToken = default);

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
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sender identity by id
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save sender identity
    /// <param name="request"></param>
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identityId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List source systems per account
    /// <param name="statistics">Whether to include message statistics or not</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Source>> ListSourceSystems(bool statistics = false, CancellationToken cancellationToken = default);

    Task<string> PostSources(Source request, CancellationToken cancellationToken = default);
    Task<string> DeleteSources(string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a source by id
    /// <param name="sourceId">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Source> GetSource(string sourceId, CancellationToken cancellationToken = default);

    Task<string> UpdateSources(Source request, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// List messages per source
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="range">Limits the returned list</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Message>> ListMessagesPerSource(date_range daterange, items_range range, string sourceId, bool addheaders = false, bool addonlinelink = false, bool addtags = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get time based message statistics for a message source
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<DataSets> GetStatisticsForASource(date_range daterange, string sourceId, int interval = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// List credentials per source system
    /// <param name="sourceId">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<List<Credentials>> ListUsersPerSourceSystem(string sourceId, CancellationToken cancellationToken = default);

    Task<Credentials> PostUsersBySources(Credentials request, string sourceId, CancellationToken cancellationToken = default);
    Task<string> DeleteUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default);
    Task<Credentials> GetUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default);
    Task<Credentials> UpdateUsersBySources(Credentials request, string sourceId, string userId, CancellationToken cancellationToken = default);

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
    Task<List<Message>> ListMessagesPerTag(RangeHeaderValue range, string tag, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default);

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
    Task<string> CreateTemplate(Template request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete template by id
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> DeleteTemplate(string templateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get template by id
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<Template> GetTemplate(string templateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Save template
    /// <param name="request">Template object</param>
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    Task<string> SaveTemplate(Template request, string templateId, CancellationToken cancellationToken = default);

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
    Task<List<BouncedMessage>> ListUndeliveredMessages(RangeHeaderValue range, bool addevents = false, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default);
}