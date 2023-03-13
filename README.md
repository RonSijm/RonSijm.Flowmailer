# RonSijm.Flowmailer

[![.NET](https://github.com/RonSijm/RonSijm.Flowmailer/actions/workflows/build_main.yml/badge.svg?branch=main)](https://github.com/RonSijm/RonSijm.Flowmailer/actions/workflows/dotnet.yml) [![Nuget](https://img.shields.io/nuget/v/RonSijm.Flowmailer)](https://www.nuget.org/packages/RonSijm.Flowmailer/) [![codecov](https://codecov.io/gh/RonSijm/RonSijm.Flowmailer/branch/main/graph/badge.svg?token=PIDRVFD6IW)](https://codecov.io/gh/RonSijm/RonSijm.Flowmailer)

C# client library implementing all Flowmailer API methods

API documentation: https://flowmailer.com/apidoc/flowmailer-api

Nuget: https://www.nuget.org/packages/RonSijm.Flowmailer/

Usage in library:

    var client = new FlowMailerClient(httpFactory, "ClientId", "ClientSecret", "AccountId");
    var result = await client.GetEventFlows();

Usage in ASP Core:

Create a config session in your appsettings.json:

    "FlowMailer": {
      "ClientId": "ClientId",
      "ClientSecret": "ClientSecret",
      "AccountId": "1337"
    }

Wire it up in your Program.cs:

    var flowMailerConfig = builder.Configuration.GetSection("FlowMailer").Get<FlowMailerOptions>();
    builder.Services.AddScoped<IFlowMailerClient>(serviceProvider => new FlowMailerClient(serviceProvider.GetService<IHttpClientFactory>(), flowMailerConfig));

Implemented methods:

## GetEventFlowRules
 - Get flow rule list for all event flows
 - Url: https://api.flowmailer.net/{account_id}/event_flow_rules
 - Endpoint: Task<string> GetEventFlowRules(CancellationToken cancellationToken = default)
---
## GetHierarchyFlowEventFlowRules
 - Get flow rule list for all event flows
 - Url: https://api.flowmailer.net/{account_id}/event_flow_rules/hierarchy
 - Endpoint: Task<string> GetHierarchyFlowEventFlowRules(CancellationToken cancellationToken = default)
---
## ListEventFlows
 - List flows per account
 - Url: https://api.flowmailer.net/{account_id}/event_flows
 - Endpoint: Task<List<EventFlow>> ListEventFlows(CancellationToken cancellationToken = default)
---
## CreateEventFlows
 - Create a new flow
 - Url: https://api.flowmailer.net/{account_id}/event_flows
 - Endpoint: Task<string> CreateEventFlows(EventFlow request, CancellationToken cancellationToken = default)
---
## DeleteEventByEventFlowId
 - Delete flow by id
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{eventFlowId}
 - Endpoint: Task<string> DeleteEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
---
## GetEventByEventFlowId
 - Get flow by id
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{eventFlowId}
 - Endpoint: Task<EventFlow> GetEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
---
## SaveEventByEventFlowId
 - Save flow
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{eventFlowId}
 - Endpoint: Task<EventFlow> SaveEventByEventFlowId(EventFlow request, string eventFlowId, CancellationToken cancellationToken = default)
---
## GetRuleForAEventByEventFlowId
 - Get flow conditions for a flow
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{eventFlowId}/rule
 - Endpoint: Task<EventFlowRuleSimple> GetRuleForAEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
---
## SetRuleForAEventByEventFlowId
 - Set conditions for a flow
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{eventFlowId}/rule
 - Endpoint: Task<string> SetRuleForAEventByEventFlowId(EventFlowRuleSimple request, string eventFlowId, CancellationToken cancellationToken = default)
---
## ListFilters
 - List filters per account
 - Url: https://api.flowmailer.net/{account_id}/filters
 - Endpoint: Task<List<Filter>> ListFilters(ref_range range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
## DeleteFilter
 - Delete a recipient from the filter
 - Url: https://api.flowmailer.net/{account_id}/filters/{filterId}
 - Endpoint: Task<string> DeleteFilter(string filterId, CancellationToken cancellationToken = default)
---
## GetFlowRules
 - Get flow rule list for all flows
 - Url: https://api.flowmailer.net/{account_id}/flow_rules
 - Endpoint: Task<string> GetFlowRules(CancellationToken cancellationToken = default)
---
## ListFlowTemplates
 - List flow templates per account
 - Url: https://api.flowmailer.net/{account_id}/flow_templates
 - Endpoint: Task<List<FlowTemplate>> ListFlowTemplates(CancellationToken cancellationToken = default)
---
## ListFlows
 - List flows per account
 - Url: https://api.flowmailer.net/{account_id}/flows
 - Endpoint: Task<List<Flow>> ListFlows(bool statistics = default, CancellationToken cancellationToken = default)
---
## CreateFlow
 - Create a new flow
 - Url: https://api.flowmailer.net/{account_id}/flows
 - Endpoint: Task<string> CreateFlow(Flow request, CancellationToken cancellationToken = default)
---
## DeleteFlow
 - Delete flow by id
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}
 - Endpoint: Task<string> DeleteFlow(string flowId, CancellationToken cancellationToken = default)
---
## GetFlow
 - Get flow by id
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}
 - Endpoint: Task<Flow> GetFlow(string flowId, CancellationToken cancellationToken = default)
---
## SaveFlow
 - Save flow
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}
 - Endpoint: Task<Flow> SaveFlow(Flow request, string flowId, CancellationToken cancellationToken = default)
---
## ListMessagesPerFlow
 - List messages per flow
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerFlow(date_range daterange, string flowId, items_range range, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
---
## GetRuleForAFlowConditions
 - Get flow conditions for a flow
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}/rule
 - Endpoint: Task<FlowRuleSimple> GetRuleForAFlowConditions(string flowId, CancellationToken cancellationToken = default)
---
## SetRuleForAFlow
 - Set conditions for a flow
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}/rule
 - Endpoint: Task<string> SetRuleForAFlow(FlowRuleSimple request, string flowId, CancellationToken cancellationToken = default)
---
## GetStatisticsForAFlow
 - Get time based message statistics for a message flow
 - Url: https://api.flowmailer.net/{account_id}/flows/{flowId}/stats
 - Endpoint: Task<DataSets> GetStatisticsForAFlow(date_range daterange, string flowId, int interval = default, CancellationToken cancellationToken = default)
---
## ListMessageEvents
 - List message events
 - Url: https://api.flowmailer.net/{account_id}/message_events
 - Endpoint: Task<List<MessageEvent>> ListMessageEvents(ref_range range, bool addmessagetags = default, date_range daterange = default, List<string> flowIds = default, date_range receivedrange = default, string sortorder = default, List<string> sourceIds = default, CancellationToken cancellationToken = default)
---
## ListMessageHold
 - List messages which could not be processed
 - Url: https://api.flowmailer.net/{account_id}/message_hold
 - Endpoint: Task<List<MessageHold>> ListMessageHold(items_range range, date_range daterange = default, CancellationToken cancellationToken = default)
---
## GetMessageHold
 - Get a held message by its id
 - Url: https://api.flowmailer.net/{account_id}/message_hold/{messageId}
 - Endpoint: Task<MessageHold> GetMessageHold(string messageId, CancellationToken cancellationToken = default)
---
## ListMessages
 - List messages
 - Url: https://api.flowmailer.net/{account_id}/messages
 - Endpoint: Task<List<Message>> ListMessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, List<string> flowIds = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default)
---
## SimulateMessage
 - Simulate an email or sms message
 - Url: https://api.flowmailer.net/{account_id}/messages/simulate
 - Endpoint: Task<SimulateMessageResult> SimulateMessage(SimulateMessage request, CancellationToken cancellationToken = default)
---
## SubmitMessage
 - Send an email or sms message
 - Url: https://api.flowmailer.net/{account_id}/messages/submit
 - Endpoint: Task<string> SubmitMessage(SubmitMessage request, CancellationToken cancellationToken = default)
---
## GetMessage
 - Get message by id
 - Url: https://api.flowmailer.net/{account_id}/messages/{messageId}
 - Endpoint: Task<Message> GetMessage(string messageId, bool addtags = default, CancellationToken cancellationToken = default)
---
## ListArchivedAsMessage
 - List the message as archived by one or more flow steps
 - Url: https://api.flowmailer.net/{account_id}/messages/{messageId}/archive
 - Endpoint: Task<List<MessageArchive>> ListArchivedAsMessage(string messageId, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
---
## FetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId
 - Fetch an attachment including data for an archived message
 - Url: https://api.flowmailer.net/{account_id}/messages/{messageId}/archive/{flowStepId}/attachment/{contentId}
 - Endpoint: Task<Attachment> FetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId(string contentId, string flowStepId, string messageId, CancellationToken cancellationToken = default)
---
## GetErrorArchiveByMessages
 - Url: https://api.flowmailer.net/{account_id}/messages/{messageId}/error_archive
 - Endpoint: Task<MessageArchive> GetErrorArchiveByMessages(string messageId, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
---
## ResendMessage
 - Resend message by id
 - Url: https://api.flowmailer.net/{account_id}/messages/{messageId}/resend
 - Endpoint: Task<string> ResendMessage(ResendMessage request, string messageId, CancellationToken cancellationToken = default)
---
## GetMessageStats
 - Get time based message statistics for whole account
 - Url: https://api.flowmailer.net/{account_id}/messagestats
 - Endpoint: Task<DataSets> GetMessageStats(date_range daterange, List<string> flowIds = default, int interval = default, CancellationToken cancellationToken = default)
---
## GetRecipient
 - Get information about a recipient
 - Url: https://api.flowmailer.net/{account_id}/recipient/{recipient}
 - Endpoint: Task<Recipient> GetRecipient(string recipient, date_range daterange = default, CancellationToken cancellationToken = default)
---
## ListMessagesPerRecipient
 - List messages per recipient
 - Url: https://api.flowmailer.net/{account_id}/recipient/{recipient}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerRecipient(ref_range range, string recipient, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
## ListMessagesPerSender
 - List messages per sender
 - Url: https://api.flowmailer.net/{account_id}/sender/{sender}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerSender(ref_range range, string sender, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
## ListSenderDomains
 - List sender domains by account
 - Url: https://api.flowmailer.net/{account_id}/sender_domains
 - Endpoint: Task<List<SenderDomain>> ListSenderDomains(CancellationToken cancellationToken = default)
---
## CreateSenderDomains
 - Create sender domain
 - Url: https://api.flowmailer.net/{account_id}/sender_domains
 - Endpoint: Task<string> CreateSenderDomains(SenderDomain request, CancellationToken cancellationToken = default)
---
## GetByBySenderDomains
 - Get sender domain by domain name
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/by_domain/{domain}
 - Endpoint: Task<SenderDomain> GetByBySenderDomains(string domain, bool validate = default, CancellationToken cancellationToken = default)
---
## ValidatesSenderDomains
 - Validates but does not save a sender domain.
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/validate
 - Endpoint: Task<SenderDomain> ValidatesSenderDomains(SenderDomain request, CancellationToken cancellationToken = default)
---
## DeleteSenderDomains
 - Delete sender domain
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domainId}
 - Endpoint: Task<string> DeleteSenderDomains(string domainId, CancellationToken cancellationToken = default)
---
## GetSenderDomains
 - Get sender domain by id
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domainId}
 - Endpoint: Task<SenderDomain> GetSenderDomains(string domainId, bool validate = default, CancellationToken cancellationToken = default)
---
## SaveSenderDomains
 - Save sender domain
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domainId}
 - Endpoint: Task<string> SaveSenderDomains(SenderDomain request, string domainId, CancellationToken cancellationToken = default)
---
## ListSenderIdentities
 - List sender identities by account
 - Url: https://api.flowmailer.net/{account_id}/sender_identities
 - Endpoint: Task<List<SenderIdentity>> ListSenderIdentities(CancellationToken cancellationToken = default)
---
## CreateSenderIdentities
 - Create sender identity
 - Url: https://api.flowmailer.net/{account_id}/sender_identities
 - Endpoint: Task<string> CreateSenderIdentities(SenderIdentity request, CancellationToken cancellationToken = default)
---
## DeleteSenderIdentitiesByIdentityId
 - Delete sender identity
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identityId}
 - Endpoint: Task<string> DeleteSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default)
---
## GetSenderIdentitiesByIdentityId
 - Get sender identity by id
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identityId}
 - Endpoint: Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default)
---
## SaveSenderIdentitiesByIdentityId
 - Save sender identity
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identityId}
 - Endpoint: Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identityId, CancellationToken cancellationToken = default)
---
## ListSourceSystems
 - List source systems per account
 - Url: https://api.flowmailer.net/{account_id}/sources
 - Endpoint: Task<List<Source>> ListSourceSystems(bool statistics = default, CancellationToken cancellationToken = default)
---
## PostSources
 - Url: https://api.flowmailer.net/{account_id}/sources
 - Endpoint: Task<string> PostSources(Source request, CancellationToken cancellationToken = default)
---
## DeleteSources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}
 - Endpoint: Task<string> DeleteSources(string sourceId, CancellationToken cancellationToken = default)
---
## GetSource
 - Get a source by id
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}
 - Endpoint: Task<Source> GetSource(string sourceId, CancellationToken cancellationToken = default)
---
## UpdateSources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}
 - Endpoint: Task<string> UpdateSources(Source request, string sourceId, CancellationToken cancellationToken = default)
---
## ListMessagesPerSource
 - List messages per source
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerSource(date_range daterange, items_range range, string sourceId, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
---
## GetStatisticsForASource
 - Get time based message statistics for a message source
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/stats
 - Endpoint: Task<DataSets> GetStatisticsForASource(date_range daterange, string sourceId, int interval = default, CancellationToken cancellationToken = default)
---
## ListUsersPerSourceSystem
 - List credentials per source system
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/users
 - Endpoint: Task<List<Credentials>> ListUsersPerSourceSystem(string sourceId, CancellationToken cancellationToken = default)
---
## PostUsersBySources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/users
 - Endpoint: Task<Credentials> PostUsersBySources(Credentials request, string sourceId, CancellationToken cancellationToken = default)
---
## DeleteUsersBySources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/users/{userId}
 - Endpoint: Task<string> DeleteUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default)
---
## GetUsersBySources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/users/{userId}
 - Endpoint: Task<Credentials> GetUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default)
---
## UpdateUsersBySources
 - Url: https://api.flowmailer.net/{account_id}/sources/{sourceId}/users/{userId}
 - Endpoint: Task<Credentials> UpdateUsersBySources(Credentials request, string sourceId, string userId, CancellationToken cancellationToken = default)
---
## ListMessagesPerTag
 - List messages per tag
 - Url: https://api.flowmailer.net/{account_id}/tag/{tag}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerTag(ref_range range, string tag, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
## ListTemplates
 - List templates by account
 - Url: https://api.flowmailer.net/{account_id}/templates
 - Endpoint: Task<List<Template>> ListTemplates(CancellationToken cancellationToken = default)
---
## CreateTemplate
 - Create template
 - Url: https://api.flowmailer.net/{account_id}/templates
 - Endpoint: Task<string> CreateTemplate(Template request, CancellationToken cancellationToken = default)
---
## DeleteTemplate
 - Delete template by id
 - Url: https://api.flowmailer.net/{account_id}/templates/{templateId}
 - Endpoint: Task<string> DeleteTemplate(string templateId, CancellationToken cancellationToken = default)
---
## GetTemplate
 - Get template by id
 - Url: https://api.flowmailer.net/{account_id}/templates/{templateId}
 - Endpoint: Task<Template> GetTemplate(string templateId, CancellationToken cancellationToken = default)
---
## SaveTemplate
 - Save template
 - Url: https://api.flowmailer.net/{account_id}/templates/{templateId}
 - Endpoint: Task<string> SaveTemplate(Template request, string templateId, CancellationToken cancellationToken = default)
---
## ListUndeliveredMessages
 - List undeliverable messages
 - Url: https://api.flowmailer.net/{account_id}/undeliveredmessages
 - Endpoint: Task<List<BouncedMessage>> ListUndeliveredMessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
