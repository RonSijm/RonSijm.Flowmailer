// ReSharper disable UnusedMember.Global
namespace RonSijm.Flowmailer;

public partial class FlowMailerClient : IFlowMailerClient
{

    /// <summary>
    /// This call is used to request an access token using the client id and secret provided by flowmailer.
    /// <param name="client_id">The API client id provided by Flowmailer</param>
    /// <param name="client_secret">The API client secret provided by Flowmailer</param>
    /// <param name="grant_type">must be <code>client_credentials</code></param>
    /// <param name="scope">Must be absent or <code>api</code></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<OAuthTokenResponse> RequestOauthToken(string client_id, string client_secret, string grant_type, string scope = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://login.flowmailer.net/oauth/token";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<OAuthTokenResponse>(result);
        return parseResult;
    }

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

    /// <summary>
    /// Get flow rule list for all event flows
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> GetEventFlowRulesHierarchy(CancellationToken cancellationToken = default)
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

    /// <summary>
    /// Delete flow by id
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteEventFlows(string event_flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{event_flow_id}";

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
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlow> GetEventFlows(string event_flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{event_flow_id}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlow>(result);
        return parseResult;
    }

    /// <summary>
    /// Save flow
    /// <param name="request">Flow object</param>
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlow> SaveEventFlows(EventFlow request, string event_flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{event_flow_id}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Put, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlow>(result);
        return parseResult;
    }

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<EventFlowRuleSimple> GetEventFlowsRule(string event_flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{event_flow_id}/rule";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<EventFlowRuleSimple>(result);
        return parseResult;
    }

    /// <summary>
    /// Set conditions for a flow
    /// <param name="request">Flow conditions</param>
    /// <param name="event_flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SetEventFlowsRule(EventFlowRuleSimple request, string event_flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/event_flows/{event_flow_id}/rule";

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
    /// List filters per account
    /// <param name="range">Limits the returned list</param>
    /// <param name="daterange">Date range the filter was added in</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Filter>> ListFilters(ref_range range, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
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
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Filter>>(result);
        return parseResult;
    }

    /// <summary>
    /// Delete a recipient from the filter
    /// <param name="filter_id">Filter ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteFilters(string filter_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/filters/{filter_id}";

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

    /// <summary>
    /// List flows per account
    /// <param name="statistics">Whether to return statistics per flow</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Flow>> ListFlows(bool statistics = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows";
        if (statistics != default)
        {
            url += $"?statistics={statistics}";
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
    public async Task<string> CreateFlows(Flow request, CancellationToken cancellationToken = default)
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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteFlows(string flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}";

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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Flow> GetFlows(string flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}";

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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Flow> SaveFlows(Flow request, string flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}";

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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="range">Limits the returned list</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Message>> ListFlowsMessages(date_range daterange, string flow_id, items_range range, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}/messages";
        var firstParam = true;
        if (addheaders != default)
        {
            firstParam = false;
            url += $"?addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"addtags={addtags}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get flow conditions for a flow
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<FlowRuleSimple> GetFlowsRule(string flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}/rule";

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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SetFlowsRule(FlowRuleSimple request, string flow_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}/rule";

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
    /// <param name="flow_id">Flow ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetFlowsStats(date_range daterange, string flow_id, int interval = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/flows/{flow_id}/stats";
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
    /// <param name="flow_ids">Filter results on message flow ID</param>
    /// <param name="receivedrange"></param>
    /// <param name="sortorder"></param>
    /// <param name="source_ids">Filter results on message source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<MessageEvent>> ListMessageEvents(ref_range range, bool addmessagetags = default, date_range daterange = default, List<string> flow_ids = default, date_range receivedrange = default, string sortorder = default, List<string> source_ids = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/message_events";
        var firstParam = true;
        if (addmessagetags != default)
        {
            firstParam = false;
            url += $"?addmessagetags={addmessagetags}";
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
        if (flow_ids != default)
        {
            url += $";flow_ids={flow_ids}";
        }
        if (receivedrange != default)
        {
            url += $";receivedrange={receivedrange}";
        }
        if (source_ids != default)
        {
            url += $";source_ids={source_ids}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Add("range", range.ToString());

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
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<MessageHold>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get a held message by its id
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<MessageHold> GetMessageHold(string message_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/message_hold/{message_id}";

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
    /// <param name="flow_ids">Filter results on flow ID</param>
    /// <param name="sortfield">Sort by INSERTED or SUBMITTED (default INSERTED)</param>
    /// <param name="sortorder"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Message>> ListMessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, List<string> flow_ids = default, string sortfield = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages";
        var firstParam = true;
        if (addevents != default)
        {
            firstParam = false;
            url += $"?addevents={addevents}";
        }
        if (addheaders != default)
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
            url += $"addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
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
            url += $"addtags={addtags}";
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
        if (flow_ids != default)
        {
            url += $";flow_ids={flow_ids}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Simulate an email or sms message
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SimulateMessageResult> SimulateMessagesSimulate(SimulateMessage request, CancellationToken cancellationToken = default)
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
    public async Task<string> SendMessagesSubmit(SubmitMessage request, CancellationToken cancellationToken = default)
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
    /// <param name="message_id">Message ID</param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Message> GetMessages(string message_id, bool addtags = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{message_id}";
        if (addtags != default)
        {
            url += $"?addtags={addtags}";
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
    /// <param name="message_id">Message ID</param>
    /// <param name="addattachments"></param>
    /// <param name="adddata"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<MessageArchive>> ListMessagesArchive(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{message_id}/archive";
        var firstParam = true;
        if (addattachments != default)
        {
            firstParam = false;
            url += $"?addattachments={addattachments}";
        }
        if (adddata != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"adddata={adddata}";
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
    /// <param name="content_id">Attachment content ID</param>
    /// <param name="flow_step_id">Flow step ID</param>
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Attachment> FetchMessagesArchiveAttachmentByFlowStepIdAndContentId(string content_id, string flow_step_id, string message_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{message_id}/archive/{flow_step_id}/attachment/{content_id}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Attachment>(result);
        return parseResult;
    }

    public async Task<MessageArchive> GetMessagesErrorArchive(string message_id, bool addattachments = default, bool adddata = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{message_id}/error_archive";
        var firstParam = true;
        if (addattachments != default)
        {
            firstParam = false;
            url += $"?addattachments={addattachments}";
        }
        if (adddata != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"adddata={adddata}";
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
    /// <param name="message_id">Message ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> ResendMessagesResend(ResendMessage request, string message_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/messages/{message_id}/resend";

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
    /// <param name="flow_ids"></param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetMessagestats(date_range daterange, List<string> flow_ids = default, int interval = default, CancellationToken cancellationToken = default)
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
        if (flow_ids != default)
        {
            url += $";flow_ids={flow_ids}";
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
    public async Task<List<Message>> ListRecipientMessages(ref_range range, string recipient, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/recipient/{recipient}/messages";
        var firstParam = true;
        if (addheaders != default)
        {
            firstParam = false;
            url += $"?addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
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
            url += $"addtags={addtags}";
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
        requestMessage.Headers.Add("range", range.ToString());

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
    public async Task<List<Message>> ListSenderMessages(ref_range range, string sender, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender/{sender}/messages";
        var firstParam = true;
        if (addheaders != default)
        {
            firstParam = false;
            url += $"?addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
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
            url += $"addtags={addtags}";
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
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// List sender domains by account
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<SenderDomain>> ListSenderDomains(CancellationToken cancellationToken = default)
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
        var parseResult = await HttpResultParser.ParseRawResult<List<SenderDomain>>(result);
        return parseResult;
    }

    /// <summary>
    /// Create sender domain
    /// <param name="request"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> CreateSenderDomains(SenderDomain request, CancellationToken cancellationToken = default)
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
    public async Task<SenderDomain> GetSenderDomainsByDomain(string domain, bool validate = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/by_domain/{domain}";
        if (validate != default)
        {
            url += $"?validate={validate}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomain>(result);
        return parseResult;
    }

    /// <summary>
    /// Validates but does not save a sender domain.
    /// <param name="request">the sender domain to validate</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderDomain> SaveSenderDomainsValidate(SenderDomain request, CancellationToken cancellationToken = default)
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
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomain>(result);
        return parseResult;
    }

    /// <summary>
    /// Delete sender domain
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteSenderDomains(string domain_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domain_id}";

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
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="validate">Validate DNS records for this SenderDomain</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderDomain> GetSenderDomains(string domain_id, bool validate = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domain_id}";
        if (validate != default)
        {
            url += $"?validate={validate}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<SenderDomain>(result);
        return parseResult;
    }

    /// <summary>
    /// Save sender domain
    /// <param name="request"></param>
    /// <param name="domain_id">Sender domain ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveSenderDomains(SenderDomain request, string domain_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_domains/{domain_id}";

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
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identity_id}";

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
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<SenderIdentity> GetSenderIdentitiesByIdentityId(string identity_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identity_id}";

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
    /// <param name="identity_id">Sender identity ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveSenderIdentitiesByIdentityId(SenderIdentity request, string identity_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sender_identities/{identity_id}";

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
    public async Task<List<Source>> ListSources(bool statistics = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources";
        if (statistics != default)
        {
            url += $"?statistics={statistics}";
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

    public async Task<string> DeleteSources(string source_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}";

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
    /// <param name="source_id">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Source> GetSources(string source_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Source>(result);
        return parseResult;
    }

    public async Task<string> UpdateSources(Source request, string source_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}";

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
    /// <param name="source_id">Source ID</param>
    /// <param name="addheaders">Whether to add e-mail headers</param>
    /// <param name="addonlinelink"></param>
    /// <param name="addtags"></param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Message>> ListSourcesMessages(date_range daterange, items_range range, string source_id, bool addheaders = default, bool addonlinelink = default, bool addtags = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/messages";
        var firstParam = true;
        if (addheaders != default)
        {
            firstParam = false;
            url += $"?addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
        {
            if (firstParam)
            {
                url += "?";
            }
            else
            {
                url += "&";
            }
            url += $"addtags={addtags}";
        }
        if (daterange != default)
        {
            url += $";daterange={daterange}";
        }

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Message>>(result);
        return parseResult;
    }

    /// <summary>
    /// Get time based message statistics for a message source
    /// <param name="daterange">Date range the messages were submitted in</param>
    /// <param name="source_id">Source ID</param>
    /// <param name="interval">Time difference between samples</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<DataSets> GetSourcesStats(date_range daterange, string source_id, int interval = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/stats";
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
    /// <param name="source_id">Source ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<List<Credentials>> ListSourcesUsers(string source_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/users";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<Credentials>>(result);
        return parseResult;
    }

    public async Task<Credentials> PostSourcesUsers(Credentials request, string source_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/users";

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");
        requestMessage.Content = JsonContentFactory.Create(request);

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Credentials>(result);
        return parseResult;
    }

    public async Task<string> DeleteSourcesUsers(string source_id, string user_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/users/{user_id}";

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

    public async Task<Credentials> GetSourcesUsers(string source_id, string user_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/users/{user_id}";

        var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
        requestMessage.Headers.Add("Authorization", $"Bearer {_oauthTokenResponse.AccessToken}");
        requestMessage.Headers.Add("Accept", "application/vnd.flowmailer.v1.12+json");

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<Credentials>(result);
        return parseResult;
    }

    public async Task<Credentials> UpdateSourcesUsers(Credentials request, string source_id, string user_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/sources/{source_id}/users/{user_id}";

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
    public async Task<List<Message>> ListTagMessages(ref_range range, string tag, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/tag/{tag}/messages";
        var firstParam = true;
        if (addheaders != default)
        {
            firstParam = false;
            url += $"?addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
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
            url += $"addtags={addtags}";
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
        requestMessage.Headers.Add("range", range.ToString());

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
    public async Task<string> CreateTemplates(Template request, CancellationToken cancellationToken = default)
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
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> DeleteTemplates(string template_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{template_id}";

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
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<Template> GetTemplates(string template_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{template_id}";

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
    /// <param name="template_id">Template ID</param>
    /// <param name="cancellationToken">A token to cancel the request</param>
    /// </summary>
    public async Task<string> SaveTemplates(Template request, string template_id, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/templates/{template_id}";

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
    public async Task<List<BouncedMessage>> ListUndeliveredmessages(ref_range range, bool addevents = default, bool addheaders = default, bool addonlinelink = default, bool addtags = default, date_range daterange = default, date_range receivedrange = default, string sortorder = default, CancellationToken cancellationToken = default)
    {
        if (_oauthTokenResponse == null || _oauthTokenResponse.IsExpired())
        {
            _oauthTokenResponse = await OauthToken(cancellationToken);
        }

        using var client = _clientFactory.CreateClient();

        var url = $"https://api.flowmailer.net/{_accountId}/undeliveredmessages";
        var firstParam = true;
        if (addevents != default)
        {
            firstParam = false;
            url += $"?addevents={addevents}";
        }
        if (addheaders != default)
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
            url += $"addheaders={addheaders}";
        }
        if (addonlinelink != default)
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
            url += $"addonlinelink={addonlinelink}";
        }
        if (addtags != default)
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
            url += $"addtags={addtags}";
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
        requestMessage.Headers.Add("range", range.ToString());

        var result = await client.SendAsync(requestMessage, cancellationToken);
        var parseResult = await HttpResultParser.ParseRawResult<List<BouncedMessage>>(result);
        return parseResult;
    }
}
