// ReSharper disable UnusedMember.Global
using System.Net.Http.Headers;

namespace RonSijm.Flowmailer;

public partial class FlowMailerClient : IFlowMailerClient
{
    /// <inheritdoc />
    /// <summary>
    /// Get flow rule list for all event flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> GetEventFlowRules(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flow_rules";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// Get flow rule list for all event flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> GetHierarchyFlowEventFlowRules(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flow_rules/hierarchy";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// List flows per account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<EventFlow>> ListEventFlows(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<EventFlow>>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// Create a new flow
    /// <param name="request">Flow object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateEventFlows(EventFlow request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// Delete flow by id
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{eventFlowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// Get flow by id
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlow> GetEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{eventFlowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlow>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlow> SaveEventByEventFlowId(EventFlow request, string eventFlowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{eventFlowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlow>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlowRuleSimple> GetRuleForAEventByEventFlowId(string eventFlowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{eventFlowId}/rule";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlowRuleSimple>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="eventFlowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SetRuleForAEventByEventFlowId(EventFlowRuleSimple request, string eventFlowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{eventFlowId}/rule";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// List filters per account
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the filter was added in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Filter>> ListFilters(RangeHeaderValue range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/filters";
        if (sortorder != default)
        {
            url += $"?sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Filter>>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// Delete a recipient from the filter
    /// <param name="filterId">Filter ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteFilter(string filterId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/filters/{filterId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// Get flow rule list for all flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> GetFlowRules(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flow_rules";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <inheritdoc />
    /// <summary>
    /// List flow templates per account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<FlowTemplate>> ListFlowTemplates(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flow_templates";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<FlowTemplate>>(result);
        return parseResult;
    }

    /// <inheritdoc />
    /// <summary>
    /// List flows per account
    /// <param name="statistics">Whether to return statistics per flow</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Flow>> ListFlows(bool statistics = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows";
        if (statistics)
        {
            url += "?statistics=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Flow>>(result);
        return parseResult;
    }

    /// <summary>
    /// Create a new flow
    /// <param name="request">Flow object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateFlow(Flow request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Delete flow by id
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteFlow(string flowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get flow by id
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Flow> GetFlow(string flowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Flow>(result);
        return parseResult;
    }

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Flow> SaveFlow(Flow request, string flowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Flow>(result);
        return parseResult;
    }

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
    public async Task<List<Message>> ListMessagesPerFlow(date_range daterange, string flowId, items_range range, bool addheaders = false, bool addonlinelink = false, bool addtags = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}/messages";
        var firstParam = true;
        if (addheaders)
        {
            firstParam = false;
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<FlowRuleSimple> GetRuleForAFlowConditions(string flowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}/rule";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<FlowRuleSimple>(result);
        return parseResult;
    }

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SetRuleForAFlow(FlowRuleSimple request, string flowId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}/rule";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get time based message statistics for a message flow
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flowId">Flow ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetStatisticsForAFlow(date_range daterange, string flowId, int interval = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flowId}/stats";
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (interval != default)
        {
            url += $";interval={interval}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<DataSets>(result);
        return parseResult;
    }

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
    public async Task<List<MessageEvent>> ListMessageEvents(RangeHeaderValue range, bool addmessagetags = false, date_range daterange = default, List<string> flowIds = default, date_range receivedrange = default, string sortorder = default, List<string> sourceIds = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/message_events";
        var firstParam = true;
        if (addmessagetags)
        {
            firstParam = false;
            url += "?addmessagetags=true";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (flowIds != default)
        {
            url += $";flowIds={flowIds}";
        }
        if (receivedrange != default)
        {
            url += $";receivedrange={receivedrange}";
        }
        if (sourceIds != default)
        {
            url += $";sourceIds={sourceIds}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<MessageEvent>>(result);
        return parseResult;
    }

    /// <summary>
    /// List messages which could not be processed
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the message was submitted in</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<MessageHold>> ListMessageHold(items_range range, date_range daterange = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/message_hold";
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<MessageHold>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get a held message by its id
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<MessageHold> GetMessageHold(string messageId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/message_hold/{messageId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<MessageHold>(result);
        return parseResult;
    }

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
    public async Task<List<Message>> ListMessages(RangeHeaderValue range, bool addevents = false, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, List<string> flowIds = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages";
        var firstParam = true;
        if (addevents)
        {
            firstParam = false;
            url += "?addevents=true";
        }
        if (addheaders)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (sortfield != default)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += $"sortfield={sortfield}";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (flowIds != default)
        {
            url += $";flowIds={flowIds}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Simulate an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SimulateMessageResult> SimulateMessage(SimulateMessage request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/simulate";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SimulateMessageResult>(result);
        return parseResult;
    }

    /// <summary>
    /// Send an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SubmitMessage(SubmitMessage request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/submit";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get message by id
    /// <param name="messageId">Message ID</param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Message> GetMessage(string messageId, bool addtags = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{messageId}";
        if (addtags)
        {
            url += "?addtags=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Message>(result);
        return parseResult;
    }

    /// <summary>
    /// List the message as archived by one or more flow steps
    /// <param name="messageId">Message ID</param>
    /// <param name="addattachments"></param>
    /// <param name="adddata"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<MessageArchive>> ListArchivedAsMessage(string messageId, bool addattachments = false, bool adddata = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{messageId}/archive";
        var firstParam = true;
        if (addattachments)
        {
            firstParam = false;
            url += "?addattachments=true";
        }
        if (adddata)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += "?adddata=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<MessageArchive>>(result);
        return parseResult;
    }

    /// <summary>
    /// Fetch an attachment including data for an archived message
    /// <param name="contentId">Attachment content ID</param>
    /// <param name="flowStepId">Flow step ID</param>
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Attachment> FetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId(string contentId, string flowStepId, string messageId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{messageId}/archive/{flowStepId}/attachment/{contentId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Attachment>(result);
        return parseResult;
    }

    public async Task<MessageArchive> GetErrorArchiveByMessages(string messageId, bool addattachments = false, bool adddata = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{messageId}/error_archive";
        var firstParam = true;
        if (addattachments)
        {
            firstParam = false;
            url += "?addattachments=true";
        }
        if (adddata)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += "?adddata=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<MessageArchive>(result);
        return parseResult;
    }

    /// <summary>
    /// Resend message by id
    /// <param name="request"></param>
    /// <param name="messageId">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> ResendMessage(ResendMessage request, string messageId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{messageId}/resend";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get time based message statistics for whole account
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="flowIds"></param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetMessageStats(date_range daterange, List<string> flowIds = default, int interval = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messagestats";
        if (interval != default)
        {
            url += $"?interval={interval}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (flowIds != default)
        {
            url += $";flowIds={flowIds}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<DataSets>(result);
        return parseResult;
    }

    /// <summary>
    /// Get information about a recipient
    /// <param name="recipient">Recipient email address or phone number</param>
    /// <param name="daterange">Specifies the date range for message statistics</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Recipient> GetRecipient(string recipient, date_range daterange = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/recipient/{recipient}";
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Recipient>(result);
        return parseResult;
    }

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
    public async Task<List<Message>> ListMessagesPerRecipient(RangeHeaderValue range, string recipient, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/recipient/{recipient}/messages";
        var firstParam = true;
        if (addheaders)
        {
            firstParam = false;
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

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
    public async Task<List<Message>> ListMessagesPerSender(RangeHeaderValue range, string sender, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender/{sender}/messages";
        var firstParam = true;
        if (addheaders)
        {
            firstParam = false;
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// List sender domains by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<SenderDomainModel>> ListSenderDomains(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<SenderDomainModel>>(result);
        return parseResult;
    }

    /// <summary>
    /// Create sender domain
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateSenderDomains(SenderDomainModel request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get sender domain by domain name
    /// <param name="domain">Sender domain name</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderDomainModel> GetByBySenderDomains(string domain, bool validate = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/by_domain/{domain}";
        if (validate)
        {
            url += "?validate=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomainModel>(result);
        return parseResult;
    }

    /// <summary>
    /// Validates but does not save a sender domain.
    /// <param name="request">the sender domain to validate</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderDomainModel> ValidatesSenderDomains(SenderDomainModel request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/validate";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomainModel>(result);
        return parseResult;
    }

    /// <summary>
    /// Delete sender domain
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteSenderDomains(string domainId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domainId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get sender domain by id
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderDomainModel> GetSenderDomains(string domainId, bool validate = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domainId}";
        if (validate)
        {
            url += "?validate=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomainModel>(result);
        return parseResult;
    }

    /// <summary>
    /// Save sender domain
    /// <param name="request"></param>
    /// <param name="domainId">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveSenderDomains(SenderDomainModel request, string domainId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domainId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// List sender identities by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<SenderIdentity>> ListSenderIdentities(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<SenderIdentity>>(result);
        return parseResult;
    }

    /// <summary>
    /// Create sender identity
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateSenderIdentities(SenderIdentity request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Delete sender identity
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identityId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get sender identity by id
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identityId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identityId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderIdentity>(result);
        return parseResult;
    }

    /// <summary>
    /// Save sender identity
    /// <param name="request"></param>
    /// <param name="identityId">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identityId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identityId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// List source systems per account
    /// <param name="statistics">Whether to include message statistics or not</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Source>> ListSourceSystems(bool statistics = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources";
        if (statistics)
        {
            url += "?statistics=true";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Source>>(result);
        return parseResult;
    }

    public async Task<string> PostSources(Source request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    public async Task<string> DeleteSources(string sourceId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get a source by id
    /// <param name="sourceId">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Source> GetSource(string sourceId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Source>(result);
        return parseResult;
    }

    public async Task<string> UpdateSources(Source request, string sourceId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

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
    public async Task<List<Message>> ListMessagesPerSource(date_range daterange, items_range range, string sourceId, bool addheaders = false, bool addonlinelink = false, bool addtags = false, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/messages";
        var firstParam = true;
        if (addheaders)
        {
            firstParam = false;
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get time based message statistics for a message source
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetStatisticsForASource(date_range daterange, string sourceId, int interval = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/stats";
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (interval != default)
        {
            url += $";interval={interval}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<DataSets>(result);
        return parseResult;
    }

    /// <summary>
    /// List credentials per source system
    /// <param name="sourceId">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Credentials>> ListUsersPerSourceSystem(string sourceId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/users";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Credentials>>(result);
        return parseResult;
    }

    public async Task<Credentials> PostUsersBySources(Credentials request, string sourceId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/users";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Credentials>(result);
        return parseResult;
    }

    public async Task<string> DeleteUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/users/{userId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    public async Task<Credentials> GetUsersBySources(string sourceId, string userId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/users/{userId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Credentials>(result);
        return parseResult;
    }

    public async Task<Credentials> UpdateUsersBySources(Credentials request, string sourceId, string userId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{sourceId}/users/{userId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Credentials>(result);
        return parseResult;
    }

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
    public async Task<List<Message>> ListMessagesPerTag(RangeHeaderValue range, string tag, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/tag/{tag}/messages";
        var firstParam = true;
        if (addheaders)
        {
            firstParam = false;
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// List templates by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Template>> ListTemplates(CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Template>>(result);
        return parseResult;
    }

    /// <summary>
    /// Create template
    /// <param name="request">Template object</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateTemplate(Template request, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Delete template by id
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteTemplate(string templateId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{templateId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

    /// <summary>
    /// Get template by id
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Template> GetTemplate(string templateId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{templateId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Template>(result);
        return parseResult;
    }

    /// <summary>
    /// Save template
    /// <param name="request">Template object</param>
    /// <param name="templateId">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveTemplate(Template request, string templateId, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{templateId}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
#if NET5_0_OR_GREATER
        var messageContent = await result.Content.ReadAsStringAsync(cancellationToken);
#else
        var messageContent = await result.Content.ReadAsStringAsync();
#endif

        return messageContent;
    }

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
    public async Task<List<BouncedMessage>> ListUndeliveredMessages(RangeHeaderValue range, bool addevents = false, bool addheaders = false, bool addonlinelink = false, bool addtags = false, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/undeliveredmessages";
        var firstParam = true;
        if (addevents)
        {
            firstParam = false;
            url += "?addevents=true";
        }
        if (addheaders)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addheaders=true";
        }
        if (addonlinelink)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addonlinelink=true";
        }
        if (addtags)
        {
            if (firstParam)
            {
                url += "?";
                firstParam = false;
            }
            else
            {
                url += "&";
            }
            url += "?addtags=true";
        }
        if (sortorder != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"sortorder={sortorder}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }
        if (receivedrange != default)
        {
            url += $";receivedrange={receivedrange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Range = range;

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<BouncedMessage>>(result);
        return parseResult;
    }
}
