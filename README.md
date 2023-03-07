# RonSijm.Flowmailer

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

 - Url: https://api.flowmailer.net/{account_id}/event_flow_rules
 - Endpoint: Task<string> GetEventFlowRules(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flow_rules/hierarchy
 - Endpoint: Task<string> GetHierarchyByEventFlowRules(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows
 - Endpoint: Task<List<EventFlow>> ListEventFlows(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows
 - Endpoint: Task<string> CreateEventFlows(EventFlow request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{event_flow_id}
 - Endpoint: Task<string> DeleteEventFlows(string event_flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{event_flow_id}
 - Endpoint: Task<EventFlow> GetEventFlows(string event_flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{event_flow_id}
 - Endpoint: Task<EventFlow> SaveEventFlows(EventFlow request, string event_flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{event_flow_id}/rule
 - Endpoint: Task<EventFlowRuleSimple> GetRuleByEventFlows(string event_flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/event_flows/{event_flow_id}/rule
 - Endpoint: Task<string> SetRuleByEventFlows(EventFlowRuleSimple request, string event_flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/filters
 - Endpoint: Task<List<Filter>> ListFilters(ref_range range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/filters/{filter_id}
 - Endpoint: Task<string> DeleteFilters(string filter_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flow_rules
 - Endpoint: Task<string> GetFlowRules(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flow_templates
 - Endpoint: Task<List<FlowTemplate>> ListFlowTemplates(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows
 - Endpoint: Task<List<Flow>> ListFlows(bool statistics = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows
 - Endpoint: Task<string> CreateFlows(Flow request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}
 - Endpoint: Task<string> DeleteFlows(string flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}
 - Endpoint: Task<Flow> GetFlows(string flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}
 - Endpoint: Task<Flow> SaveFlows(Flow request, string flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerFlow(date_range daterange, string flow_id, items_range range, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}/rule
 - Endpoint: Task<FlowRuleSimple> GetRuleForFlow(string flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}/rule
 - Endpoint: Task<string> SetRuleForFlow(FlowRuleSimple request, string flow_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/flows/{flow_id}/stats
 - Endpoint: Task<DataSets> GetStatsForFlow(date_range daterange, string flow_id, int interval = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/message_events
 - Endpoint: Task<List<MessageEvent>> ListMessageEvents(ref_range range, bool addmessagetags = default, date_range daterange = default, List<string> flow_ids = default, date_range receivedrange = default, string sortorder = default, List<string> source_ids = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/message_hold
 - Endpoint: Task<List<MessageHold>> ListMessageHold(items_range range, date_range daterange = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/message_hold/{message_id}
 - Endpoint: Task<MessageHold> GetMessageHold(string message_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages
 - Endpoint: Task<List<Message>> ListMessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, List<string> flow_ids = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/simulate
 - Endpoint: Task<SimulateMessageResult> SimulateMessages(SimulateMessage request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/submit
 - Endpoint: Task<string> SendMessages(SubmitMessage request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/{message_id}
 - Endpoint: Task<Message> GetMessages(string message_id, bool addtags = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/{message_id}/archive
 - Endpoint: Task<List<MessageArchive>> ListArchiveByMessage(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/{message_id}/archive/{flow_step_id}/attachment/{content_id}
 - Endpoint: Task<Attachment> FetchAttachmentByArchiveAndMessageByFlowStepIdAndContentId(string content_id, string flow_step_id, string message_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/{message_id}/error_archive
 - Endpoint: Task<MessageArchive> GetErrorArchiveByMessages(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messages/{message_id}/resend
 - Endpoint: Task<string> ResendMessages(ResendMessage request, string message_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/messagestats
 - Endpoint: Task<DataSets> GetMessagestats(date_range daterange, List<string> flow_ids = default, int interval = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/recipient/{recipient}
 - Endpoint: Task<Recipient> GetRecipient(string recipient, date_range daterange = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/recipient/{recipient}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerRecipient(ref_range range, string recipient, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender/{sender}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerSender(ref_range range, string sender, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains
 - Endpoint: Task<List<SenderDomain>> ListSenderDomains(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains
 - Endpoint: Task<string> CreateSenderDomains(SenderDomain request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/by_domain/{domain}
 - Endpoint: Task<SenderDomain> GetByDomainBySenderDomains(string domain, bool validate = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/validate
 - Endpoint: Task<SenderDomain> ValidatesSenderDomains(SenderDomain request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domain_id}
 - Endpoint: Task<string> DeleteSenderDomains(string domain_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domain_id}
 - Endpoint: Task<SenderDomain> GetSenderDomains(string domain_id, bool validate = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_domains/{domain_id}
 - Endpoint: Task<string> SaveSenderDomains(SenderDomain request, string domain_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_identities
 - Endpoint: Task<List<SenderIdentity>> ListSenderIdentities(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_identities
 - Endpoint: Task<string> CreateSenderIdentities(SenderIdentity request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identity_id}
 - Endpoint: Task<string> DeleteSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identity_id}
 - Endpoint: Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sender_identities/{identity_id}
 - Endpoint: Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identity_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources
 - Endpoint: Task<List<Source>> ListSources(bool statistics = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources
 - Endpoint: Task<string> PostSources(Source request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}
 - Endpoint: Task<string> DeleteSources(string source_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}
 - Endpoint: Task<Source> GetSources(string source_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}
 - Endpoint: Task<string> UpdateSources(Source request, string source_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerSource(date_range daterange, items_range range, string source_id, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/stats
 - Endpoint: Task<DataSets> GetStatsForSource(date_range daterange, string source_id, int interval = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/users
 - Endpoint: Task<List<Credentials>> ListUsersPerSource(string source_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/users
 - Endpoint: Task<Credentials> PostUsersBySources(Credentials request, string source_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/users/{user_id}
 - Endpoint: Task<string> DeleteUsersBySources(string source_id, string user_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/users/{user_id}
 - Endpoint: Task<Credentials> GetUsersBySources(string source_id, string user_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/sources/{source_id}/users/{user_id}
 - Endpoint: Task<Credentials> UpdateUsersBySources(Credentials request, string source_id, string user_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/tag/{tag}/messages
 - Endpoint: Task<List<Message>> ListMessagesPerTag(ref_range range, string tag, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/templates
 - Endpoint: Task<List<Template>> ListTemplates(CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/templates
 - Endpoint: Task<string> CreateTemplates(Template request, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/templates/{template_id}
 - Endpoint: Task<string> DeleteTemplates(string template_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/templates/{template_id}
 - Endpoint: Task<Template> GetTemplates(string template_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/templates/{template_id}
 - Endpoint: Task<string> SaveTemplates(Template request, string template_id, CancellationToken cancellationToken = default)
---
 - Url: https://api.flowmailer.net/{account_id}/undeliveredmessages
 - Endpoint: Task<List<BouncedMessage>> ListUndeliveredmessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default)
---
