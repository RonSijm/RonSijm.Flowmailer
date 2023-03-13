namespace RonSijm.Flowmailer.UnitTests;

public class TestThatEveryMethodCanBeInvokedWithMock
{
    private readonly Fixture _fixture = new();

    [Fact]
    public async Task CanInvokeGetEventFlowRules()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetEventFlowRules();
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetHierarchyFlowEventFlowRules()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetHierarchyFlowEventFlowRules();
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeListEventFlows()
    {
        var expectedResponse = _fixture.Create<List<EventFlow>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListEventFlows();
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeCreateEventFlows()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.CreateEventFlows(new EventFlow());
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeDeleteEventByEventFlowId()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteEventByEventFlowId("mockEventFlowId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetEventByEventFlowId()
    {
        var expectedResponse = _fixture.Create<EventFlow>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetEventByEventFlowId("mockEventFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSaveEventByEventFlowId()
    {
        var expectedResponse = _fixture.Create<EventFlow>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SaveEventByEventFlowId(new EventFlow(), "mockEventFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeGetRuleForAEventByEventFlowId()
    {
        var expectedResponse = _fixture.Create<EventFlowRuleSimple>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetRuleForAEventByEventFlowId("mockEventFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSetRuleForAEventByEventFlowId()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SetRuleForAEventByEventFlowId(new EventFlowRuleSimple(), "mockEventFlowId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(true, "sortorderMockValue")]
    [InlineData(false, null)]
    [InlineData(false, "sortorderMockValue")]
    public async Task CanInvokeListFilters(bool initDaterange, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<Filter>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListFilters(new RangeHeaderValue(), daterange, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeDeleteFilter()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteFilter("mockFilterId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetFlowRules()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetFlowRules();
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeListFlowTemplates()
    {
        var expectedResponse = _fixture.Create<List<FlowTemplate>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListFlowTemplates();
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeListFlows(bool statistics)
    {
        var expectedResponse = _fixture.Create<List<Flow>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListFlows(statistics);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeCreateFlow()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.CreateFlow(new Flow());
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeDeleteFlow()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteFlow("mockFlowId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetFlow()
    {
        var expectedResponse = _fixture.Create<Flow>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetFlow("mockFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSaveFlow()
    {
        var expectedResponse = _fixture.Create<Flow>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SaveFlow(new Flow(), "mockFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true)]
    [InlineData(true, true, false)]
    [InlineData(true, false, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, true)]
    [InlineData(false, true, false)]
    [InlineData(false, false, true)]
    [InlineData(false, false, false)]
    public async Task CanInvokeListMessagesPerFlow(bool addheaders, bool addonlinelink, bool addtags)
    {
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessagesPerFlow(new date_range(), "mockFlowId", new items_range(), addheaders, addonlinelink, addtags);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeGetRuleForAFlowConditions()
    {
        var expectedResponse = _fixture.Create<FlowRuleSimple>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetRuleForAFlowConditions("mockFlowId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSetRuleForAFlow()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SetRuleForAFlow(new FlowRuleSimple(), "mockFlowId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(42)]
    public async Task CanInvokeGetStatisticsForAFlow(int interval)
    {
        var expectedResponse = _fixture.Create<DataSets>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetStatisticsForAFlow(new date_range(), "mockFlowId", interval);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true, true, null, true)]
    [InlineData(true, true, true, true, null, false)]
    [InlineData(true, true, true, true, "sortorderMockValue", true)]
    [InlineData(true, true, true, true, "sortorderMockValue", false)]
    [InlineData(true, true, true, false, null, true)]
    [InlineData(true, true, true, false, null, false)]
    [InlineData(true, true, true, false, "sortorderMockValue", true)]
    [InlineData(true, true, true, false, "sortorderMockValue", false)]
    [InlineData(true, true, false, true, null, true)]
    [InlineData(true, true, false, true, null, false)]
    [InlineData(true, true, false, true, "sortorderMockValue", true)]
    [InlineData(true, true, false, true, "sortorderMockValue", false)]
    [InlineData(true, true, false, false, null, true)]
    [InlineData(true, true, false, false, null, false)]
    [InlineData(true, true, false, false, "sortorderMockValue", true)]
    [InlineData(true, true, false, false, "sortorderMockValue", false)]
    [InlineData(true, false, true, true, null, true)]
    [InlineData(true, false, true, true, null, false)]
    [InlineData(true, false, true, true, "sortorderMockValue", true)]
    [InlineData(true, false, true, true, "sortorderMockValue", false)]
    [InlineData(true, false, true, false, null, true)]
    [InlineData(true, false, true, false, null, false)]
    [InlineData(true, false, true, false, "sortorderMockValue", true)]
    [InlineData(true, false, true, false, "sortorderMockValue", false)]
    [InlineData(true, false, false, true, null, true)]
    [InlineData(true, false, false, true, null, false)]
    [InlineData(true, false, false, true, "sortorderMockValue", true)]
    [InlineData(true, false, false, true, "sortorderMockValue", false)]
    [InlineData(true, false, false, false, null, true)]
    [InlineData(true, false, false, false, null, false)]
    [InlineData(true, false, false, false, "sortorderMockValue", true)]
    [InlineData(true, false, false, false, "sortorderMockValue", false)]
    [InlineData(false, true, true, true, null, true)]
    [InlineData(false, true, true, true, null, false)]
    [InlineData(false, true, true, true, "sortorderMockValue", true)]
    [InlineData(false, true, true, true, "sortorderMockValue", false)]
    [InlineData(false, true, true, false, null, true)]
    [InlineData(false, true, true, false, null, false)]
    [InlineData(false, true, true, false, "sortorderMockValue", true)]
    [InlineData(false, true, true, false, "sortorderMockValue", false)]
    [InlineData(false, true, false, true, null, true)]
    [InlineData(false, true, false, true, null, false)]
    [InlineData(false, true, false, true, "sortorderMockValue", true)]
    [InlineData(false, true, false, true, "sortorderMockValue", false)]
    [InlineData(false, true, false, false, null, true)]
    [InlineData(false, true, false, false, null, false)]
    [InlineData(false, true, false, false, "sortorderMockValue", true)]
    [InlineData(false, true, false, false, "sortorderMockValue", false)]
    [InlineData(false, false, true, true, null, true)]
    [InlineData(false, false, true, true, null, false)]
    [InlineData(false, false, true, true, "sortorderMockValue", true)]
    [InlineData(false, false, true, true, "sortorderMockValue", false)]
    [InlineData(false, false, true, false, null, true)]
    [InlineData(false, false, true, false, null, false)]
    [InlineData(false, false, true, false, "sortorderMockValue", true)]
    [InlineData(false, false, true, false, "sortorderMockValue", false)]
    [InlineData(false, false, false, true, null, true)]
    [InlineData(false, false, false, true, null, false)]
    [InlineData(false, false, false, true, "sortorderMockValue", true)]
    [InlineData(false, false, false, true, "sortorderMockValue", false)]
    [InlineData(false, false, false, false, null, true)]
    [InlineData(false, false, false, false, null, false)]
    [InlineData(false, false, false, false, "sortorderMockValue", true)]
    [InlineData(false, false, false, false, "sortorderMockValue", false)]
    public async Task CanInvokeListMessageEvents(bool addmessagetags, bool initDaterange, bool initFlowIds, bool initReceivedrange, string sortorder, bool initSourceIds)
    {
        var daterange = initDaterange ? new date_range() : null;
        var flowIds = initFlowIds ? new List<string>() : null;
        var receivedrange = initReceivedrange ? new date_range() : null;
        var sourceIds = initSourceIds ? new List<string>() : null;
        var expectedResponse = _fixture.Create<List<MessageEvent>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessageEvents(new RangeHeaderValue(), addmessagetags, daterange, flowIds, receivedrange, sortorder, sourceIds);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeListMessageHold(bool initDaterange)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<MessageHold>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessageHold(new items_range(), daterange);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeGetMessageHold()
    {
        var expectedResponse = _fixture.Create<MessageHold>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetMessageHold("mockMessageId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true, true, true, true, null, null)]
    [InlineData(true, true, true, true, true, true, null, "sortorderMockValue")]
    [InlineData(true, true, true, true, true, true, "sortfieldMockValue", null)]
    [InlineData(true, true, true, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, true, true, false, null, null)]
    [InlineData(true, true, true, true, true, false, null, "sortorderMockValue")]
    [InlineData(true, true, true, true, true, false, "sortfieldMockValue", null)]
    [InlineData(true, true, true, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, true, false, true, null, null)]
    [InlineData(true, true, true, true, false, true, null, "sortorderMockValue")]
    [InlineData(true, true, true, true, false, true, "sortfieldMockValue", null)]
    [InlineData(true, true, true, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, true, false, false, null, null)]
    [InlineData(true, true, true, true, false, false, null, "sortorderMockValue")]
    [InlineData(true, true, true, true, false, false, "sortfieldMockValue", null)]
    [InlineData(true, true, true, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, false, true, true, null, null)]
    [InlineData(true, true, true, false, true, true, null, "sortorderMockValue")]
    [InlineData(true, true, true, false, true, true, "sortfieldMockValue", null)]
    [InlineData(true, true, true, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, false, true, false, null, null)]
    [InlineData(true, true, true, false, true, false, null, "sortorderMockValue")]
    [InlineData(true, true, true, false, true, false, "sortfieldMockValue", null)]
    [InlineData(true, true, true, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, false, false, true, null, null)]
    [InlineData(true, true, true, false, false, true, null, "sortorderMockValue")]
    [InlineData(true, true, true, false, false, true, "sortfieldMockValue", null)]
    [InlineData(true, true, true, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, true, false, false, false, null, null)]
    [InlineData(true, true, true, false, false, false, null, "sortorderMockValue")]
    [InlineData(true, true, true, false, false, false, "sortfieldMockValue", null)]
    [InlineData(true, true, true, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, true, true, true, null, null)]
    [InlineData(true, true, false, true, true, true, null, "sortorderMockValue")]
    [InlineData(true, true, false, true, true, true, "sortfieldMockValue", null)]
    [InlineData(true, true, false, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, true, true, false, null, null)]
    [InlineData(true, true, false, true, true, false, null, "sortorderMockValue")]
    [InlineData(true, true, false, true, true, false, "sortfieldMockValue", null)]
    [InlineData(true, true, false, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, true, false, true, null, null)]
    [InlineData(true, true, false, true, false, true, null, "sortorderMockValue")]
    [InlineData(true, true, false, true, false, true, "sortfieldMockValue", null)]
    [InlineData(true, true, false, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, true, false, false, null, null)]
    [InlineData(true, true, false, true, false, false, null, "sortorderMockValue")]
    [InlineData(true, true, false, true, false, false, "sortfieldMockValue", null)]
    [InlineData(true, true, false, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, false, true, true, null, null)]
    [InlineData(true, true, false, false, true, true, null, "sortorderMockValue")]
    [InlineData(true, true, false, false, true, true, "sortfieldMockValue", null)]
    [InlineData(true, true, false, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, false, true, false, null, null)]
    [InlineData(true, true, false, false, true, false, null, "sortorderMockValue")]
    [InlineData(true, true, false, false, true, false, "sortfieldMockValue", null)]
    [InlineData(true, true, false, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, false, false, true, null, null)]
    [InlineData(true, true, false, false, false, true, null, "sortorderMockValue")]
    [InlineData(true, true, false, false, false, true, "sortfieldMockValue", null)]
    [InlineData(true, true, false, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, true, false, false, false, false, null, null)]
    [InlineData(true, true, false, false, false, false, null, "sortorderMockValue")]
    [InlineData(true, true, false, false, false, false, "sortfieldMockValue", null)]
    [InlineData(true, true, false, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, true, true, true, null, null)]
    [InlineData(true, false, true, true, true, true, null, "sortorderMockValue")]
    [InlineData(true, false, true, true, true, true, "sortfieldMockValue", null)]
    [InlineData(true, false, true, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, true, true, false, null, null)]
    [InlineData(true, false, true, true, true, false, null, "sortorderMockValue")]
    [InlineData(true, false, true, true, true, false, "sortfieldMockValue", null)]
    [InlineData(true, false, true, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, true, false, true, null, null)]
    [InlineData(true, false, true, true, false, true, null, "sortorderMockValue")]
    [InlineData(true, false, true, true, false, true, "sortfieldMockValue", null)]
    [InlineData(true, false, true, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, true, false, false, null, null)]
    [InlineData(true, false, true, true, false, false, null, "sortorderMockValue")]
    [InlineData(true, false, true, true, false, false, "sortfieldMockValue", null)]
    [InlineData(true, false, true, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, false, true, true, null, null)]
    [InlineData(true, false, true, false, true, true, null, "sortorderMockValue")]
    [InlineData(true, false, true, false, true, true, "sortfieldMockValue", null)]
    [InlineData(true, false, true, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, false, true, false, null, null)]
    [InlineData(true, false, true, false, true, false, null, "sortorderMockValue")]
    [InlineData(true, false, true, false, true, false, "sortfieldMockValue", null)]
    [InlineData(true, false, true, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, false, false, true, null, null)]
    [InlineData(true, false, true, false, false, true, null, "sortorderMockValue")]
    [InlineData(true, false, true, false, false, true, "sortfieldMockValue", null)]
    [InlineData(true, false, true, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, true, false, false, false, null, null)]
    [InlineData(true, false, true, false, false, false, null, "sortorderMockValue")]
    [InlineData(true, false, true, false, false, false, "sortfieldMockValue", null)]
    [InlineData(true, false, true, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, true, true, true, null, null)]
    [InlineData(true, false, false, true, true, true, null, "sortorderMockValue")]
    [InlineData(true, false, false, true, true, true, "sortfieldMockValue", null)]
    [InlineData(true, false, false, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, true, true, false, null, null)]
    [InlineData(true, false, false, true, true, false, null, "sortorderMockValue")]
    [InlineData(true, false, false, true, true, false, "sortfieldMockValue", null)]
    [InlineData(true, false, false, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, true, false, true, null, null)]
    [InlineData(true, false, false, true, false, true, null, "sortorderMockValue")]
    [InlineData(true, false, false, true, false, true, "sortfieldMockValue", null)]
    [InlineData(true, false, false, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, true, false, false, null, null)]
    [InlineData(true, false, false, true, false, false, null, "sortorderMockValue")]
    [InlineData(true, false, false, true, false, false, "sortfieldMockValue", null)]
    [InlineData(true, false, false, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, false, true, true, null, null)]
    [InlineData(true, false, false, false, true, true, null, "sortorderMockValue")]
    [InlineData(true, false, false, false, true, true, "sortfieldMockValue", null)]
    [InlineData(true, false, false, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, false, true, false, null, null)]
    [InlineData(true, false, false, false, true, false, null, "sortorderMockValue")]
    [InlineData(true, false, false, false, true, false, "sortfieldMockValue", null)]
    [InlineData(true, false, false, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, false, false, true, null, null)]
    [InlineData(true, false, false, false, false, true, null, "sortorderMockValue")]
    [InlineData(true, false, false, false, false, true, "sortfieldMockValue", null)]
    [InlineData(true, false, false, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(true, false, false, false, false, false, null, null)]
    [InlineData(true, false, false, false, false, false, null, "sortorderMockValue")]
    [InlineData(true, false, false, false, false, false, "sortfieldMockValue", null)]
    [InlineData(true, false, false, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, true, true, true, null, null)]
    [InlineData(false, true, true, true, true, true, null, "sortorderMockValue")]
    [InlineData(false, true, true, true, true, true, "sortfieldMockValue", null)]
    [InlineData(false, true, true, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, true, true, false, null, null)]
    [InlineData(false, true, true, true, true, false, null, "sortorderMockValue")]
    [InlineData(false, true, true, true, true, false, "sortfieldMockValue", null)]
    [InlineData(false, true, true, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, true, false, true, null, null)]
    [InlineData(false, true, true, true, false, true, null, "sortorderMockValue")]
    [InlineData(false, true, true, true, false, true, "sortfieldMockValue", null)]
    [InlineData(false, true, true, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, true, false, false, null, null)]
    [InlineData(false, true, true, true, false, false, null, "sortorderMockValue")]
    [InlineData(false, true, true, true, false, false, "sortfieldMockValue", null)]
    [InlineData(false, true, true, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, false, true, true, null, null)]
    [InlineData(false, true, true, false, true, true, null, "sortorderMockValue")]
    [InlineData(false, true, true, false, true, true, "sortfieldMockValue", null)]
    [InlineData(false, true, true, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, false, true, false, null, null)]
    [InlineData(false, true, true, false, true, false, null, "sortorderMockValue")]
    [InlineData(false, true, true, false, true, false, "sortfieldMockValue", null)]
    [InlineData(false, true, true, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, false, false, true, null, null)]
    [InlineData(false, true, true, false, false, true, null, "sortorderMockValue")]
    [InlineData(false, true, true, false, false, true, "sortfieldMockValue", null)]
    [InlineData(false, true, true, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, true, false, false, false, null, null)]
    [InlineData(false, true, true, false, false, false, null, "sortorderMockValue")]
    [InlineData(false, true, true, false, false, false, "sortfieldMockValue", null)]
    [InlineData(false, true, true, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, true, true, true, null, null)]
    [InlineData(false, true, false, true, true, true, null, "sortorderMockValue")]
    [InlineData(false, true, false, true, true, true, "sortfieldMockValue", null)]
    [InlineData(false, true, false, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, true, true, false, null, null)]
    [InlineData(false, true, false, true, true, false, null, "sortorderMockValue")]
    [InlineData(false, true, false, true, true, false, "sortfieldMockValue", null)]
    [InlineData(false, true, false, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, true, false, true, null, null)]
    [InlineData(false, true, false, true, false, true, null, "sortorderMockValue")]
    [InlineData(false, true, false, true, false, true, "sortfieldMockValue", null)]
    [InlineData(false, true, false, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, true, false, false, null, null)]
    [InlineData(false, true, false, true, false, false, null, "sortorderMockValue")]
    [InlineData(false, true, false, true, false, false, "sortfieldMockValue", null)]
    [InlineData(false, true, false, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, false, true, true, null, null)]
    [InlineData(false, true, false, false, true, true, null, "sortorderMockValue")]
    [InlineData(false, true, false, false, true, true, "sortfieldMockValue", null)]
    [InlineData(false, true, false, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, false, true, false, null, null)]
    [InlineData(false, true, false, false, true, false, null, "sortorderMockValue")]
    [InlineData(false, true, false, false, true, false, "sortfieldMockValue", null)]
    [InlineData(false, true, false, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, false, false, true, null, null)]
    [InlineData(false, true, false, false, false, true, null, "sortorderMockValue")]
    [InlineData(false, true, false, false, false, true, "sortfieldMockValue", null)]
    [InlineData(false, true, false, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, true, false, false, false, false, null, null)]
    [InlineData(false, true, false, false, false, false, null, "sortorderMockValue")]
    [InlineData(false, true, false, false, false, false, "sortfieldMockValue", null)]
    [InlineData(false, true, false, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, true, true, true, null, null)]
    [InlineData(false, false, true, true, true, true, null, "sortorderMockValue")]
    [InlineData(false, false, true, true, true, true, "sortfieldMockValue", null)]
    [InlineData(false, false, true, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, true, true, false, null, null)]
    [InlineData(false, false, true, true, true, false, null, "sortorderMockValue")]
    [InlineData(false, false, true, true, true, false, "sortfieldMockValue", null)]
    [InlineData(false, false, true, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, true, false, true, null, null)]
    [InlineData(false, false, true, true, false, true, null, "sortorderMockValue")]
    [InlineData(false, false, true, true, false, true, "sortfieldMockValue", null)]
    [InlineData(false, false, true, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, true, false, false, null, null)]
    [InlineData(false, false, true, true, false, false, null, "sortorderMockValue")]
    [InlineData(false, false, true, true, false, false, "sortfieldMockValue", null)]
    [InlineData(false, false, true, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, false, true, true, null, null)]
    [InlineData(false, false, true, false, true, true, null, "sortorderMockValue")]
    [InlineData(false, false, true, false, true, true, "sortfieldMockValue", null)]
    [InlineData(false, false, true, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, false, true, false, null, null)]
    [InlineData(false, false, true, false, true, false, null, "sortorderMockValue")]
    [InlineData(false, false, true, false, true, false, "sortfieldMockValue", null)]
    [InlineData(false, false, true, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, false, false, true, null, null)]
    [InlineData(false, false, true, false, false, true, null, "sortorderMockValue")]
    [InlineData(false, false, true, false, false, true, "sortfieldMockValue", null)]
    [InlineData(false, false, true, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, true, false, false, false, null, null)]
    [InlineData(false, false, true, false, false, false, null, "sortorderMockValue")]
    [InlineData(false, false, true, false, false, false, "sortfieldMockValue", null)]
    [InlineData(false, false, true, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, true, true, true, null, null)]
    [InlineData(false, false, false, true, true, true, null, "sortorderMockValue")]
    [InlineData(false, false, false, true, true, true, "sortfieldMockValue", null)]
    [InlineData(false, false, false, true, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, true, true, false, null, null)]
    [InlineData(false, false, false, true, true, false, null, "sortorderMockValue")]
    [InlineData(false, false, false, true, true, false, "sortfieldMockValue", null)]
    [InlineData(false, false, false, true, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, true, false, true, null, null)]
    [InlineData(false, false, false, true, false, true, null, "sortorderMockValue")]
    [InlineData(false, false, false, true, false, true, "sortfieldMockValue", null)]
    [InlineData(false, false, false, true, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, true, false, false, null, null)]
    [InlineData(false, false, false, true, false, false, null, "sortorderMockValue")]
    [InlineData(false, false, false, true, false, false, "sortfieldMockValue", null)]
    [InlineData(false, false, false, true, false, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, false, true, true, null, null)]
    [InlineData(false, false, false, false, true, true, null, "sortorderMockValue")]
    [InlineData(false, false, false, false, true, true, "sortfieldMockValue", null)]
    [InlineData(false, false, false, false, true, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, false, true, false, null, null)]
    [InlineData(false, false, false, false, true, false, null, "sortorderMockValue")]
    [InlineData(false, false, false, false, true, false, "sortfieldMockValue", null)]
    [InlineData(false, false, false, false, true, false, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, false, false, true, null, null)]
    [InlineData(false, false, false, false, false, true, null, "sortorderMockValue")]
    [InlineData(false, false, false, false, false, true, "sortfieldMockValue", null)]
    [InlineData(false, false, false, false, false, true, "sortfieldMockValue", "sortorderMockValue")]
    [InlineData(false, false, false, false, false, false, null, null)]
    [InlineData(false, false, false, false, false, false, null, "sortorderMockValue")]
    [InlineData(false, false, false, false, false, false, "sortfieldMockValue", null)]
    [InlineData(false, false, false, false, false, false, "sortfieldMockValue", "sortorderMockValue")]
    public async Task CanInvokeListMessages(bool addevents, bool addheaders, bool addonlinelink, bool addtags, bool initDaterange, bool initFlowIds, string sortfield, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var flowIds = initFlowIds ? new List<string>() : null;
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessages(new RangeHeaderValue(), addevents, addheaders, addonlinelink, addtags, daterange, flowIds, sortfield, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSimulateMessage()
    {
        var expectedResponse = _fixture.Create<SimulateMessageResult>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SimulateMessage(new SimulateMessage());
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSubmitMessage()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SubmitMessage(new SubmitMessage());
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeGetMessage(bool addtags)
    {
        var expectedResponse = _fixture.Create<Message>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetMessage("mockMessageId", addtags);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public async Task CanInvokeListArchivedAsMessage(bool addattachments, bool adddata)
    {
        var expectedResponse = _fixture.Create<List<MessageArchive>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListArchivedAsMessage("mockMessageId", addattachments, adddata);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeFetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId()
    {
        var expectedResponse = _fixture.Create<Attachment>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.FetchAttachmentForAnArchivedMessageByFlowStepIdAndContentId("mockContentId", "mockFlowStepId", "mockMessageId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true)]
    [InlineData(true, false)]
    [InlineData(false, true)]
    [InlineData(false, false)]
    public async Task CanInvokeGetErrorArchiveByMessages(bool addattachments, bool adddata)
    {
        var expectedResponse = _fixture.Create<MessageArchive>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetErrorArchiveByMessages("mockMessageId", addattachments, adddata);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeResendMessage()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ResendMessage(new ResendMessage(), "mockMessageId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true, 0)]
    [InlineData(true, 42)]
    [InlineData(false, 0)]
    [InlineData(false, 42)]
    public async Task CanInvokeGetMessageStats(bool initFlowIds, int interval)
    {
        var flowIds = initFlowIds ? new List<string>() : null;
        var expectedResponse = _fixture.Create<DataSets>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetMessageStats(new date_range(), flowIds, interval);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeGetRecipient(bool initDaterange)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<Recipient>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetRecipient("mockRecipient", daterange);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true, true, null)]
    [InlineData(true, true, true, true, "sortorderMockValue")]
    [InlineData(true, true, true, false, null)]
    [InlineData(true, true, true, false, "sortorderMockValue")]
    [InlineData(true, true, false, true, null)]
    [InlineData(true, true, false, true, "sortorderMockValue")]
    [InlineData(true, true, false, false, null)]
    [InlineData(true, true, false, false, "sortorderMockValue")]
    [InlineData(true, false, true, true, null)]
    [InlineData(true, false, true, true, "sortorderMockValue")]
    [InlineData(true, false, true, false, null)]
    [InlineData(true, false, true, false, "sortorderMockValue")]
    [InlineData(true, false, false, true, null)]
    [InlineData(true, false, false, true, "sortorderMockValue")]
    [InlineData(true, false, false, false, null)]
    [InlineData(true, false, false, false, "sortorderMockValue")]
    [InlineData(false, true, true, true, null)]
    [InlineData(false, true, true, true, "sortorderMockValue")]
    [InlineData(false, true, true, false, null)]
    [InlineData(false, true, true, false, "sortorderMockValue")]
    [InlineData(false, true, false, true, null)]
    [InlineData(false, true, false, true, "sortorderMockValue")]
    [InlineData(false, true, false, false, null)]
    [InlineData(false, true, false, false, "sortorderMockValue")]
    [InlineData(false, false, true, true, null)]
    [InlineData(false, false, true, true, "sortorderMockValue")]
    [InlineData(false, false, true, false, null)]
    [InlineData(false, false, true, false, "sortorderMockValue")]
    [InlineData(false, false, false, true, null)]
    [InlineData(false, false, false, true, "sortorderMockValue")]
    [InlineData(false, false, false, false, null)]
    [InlineData(false, false, false, false, "sortorderMockValue")]
    public async Task CanInvokeListMessagesPerRecipient(bool addheaders, bool addonlinelink, bool addtags, bool initDaterange, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessagesPerRecipient(new RangeHeaderValue(), "mockRecipient", addheaders, addonlinelink, addtags, daterange, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true, true, null)]
    [InlineData(true, true, true, true, "sortorderMockValue")]
    [InlineData(true, true, true, false, null)]
    [InlineData(true, true, true, false, "sortorderMockValue")]
    [InlineData(true, true, false, true, null)]
    [InlineData(true, true, false, true, "sortorderMockValue")]
    [InlineData(true, true, false, false, null)]
    [InlineData(true, true, false, false, "sortorderMockValue")]
    [InlineData(true, false, true, true, null)]
    [InlineData(true, false, true, true, "sortorderMockValue")]
    [InlineData(true, false, true, false, null)]
    [InlineData(true, false, true, false, "sortorderMockValue")]
    [InlineData(true, false, false, true, null)]
    [InlineData(true, false, false, true, "sortorderMockValue")]
    [InlineData(true, false, false, false, null)]
    [InlineData(true, false, false, false, "sortorderMockValue")]
    [InlineData(false, true, true, true, null)]
    [InlineData(false, true, true, true, "sortorderMockValue")]
    [InlineData(false, true, true, false, null)]
    [InlineData(false, true, true, false, "sortorderMockValue")]
    [InlineData(false, true, false, true, null)]
    [InlineData(false, true, false, true, "sortorderMockValue")]
    [InlineData(false, true, false, false, null)]
    [InlineData(false, true, false, false, "sortorderMockValue")]
    [InlineData(false, false, true, true, null)]
    [InlineData(false, false, true, true, "sortorderMockValue")]
    [InlineData(false, false, true, false, null)]
    [InlineData(false, false, true, false, "sortorderMockValue")]
    [InlineData(false, false, false, true, null)]
    [InlineData(false, false, false, true, "sortorderMockValue")]
    [InlineData(false, false, false, false, null)]
    [InlineData(false, false, false, false, "sortorderMockValue")]
    public async Task CanInvokeListMessagesPerSender(bool addheaders, bool addonlinelink, bool addtags, bool initDaterange, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessagesPerSender(new RangeHeaderValue(), "mockSender", addheaders, addonlinelink, addtags, daterange, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeListSenderDomains()
    {
        var expectedResponse = _fixture.Create<List<SenderDomainModel>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListSenderDomains();
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeCreateSenderDomains()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.CreateSenderDomains(new SenderDomainModel());
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeGetByBySenderDomains(bool validate)
    {
        var expectedResponse = _fixture.Create<SenderDomainModel>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetByBySenderDomains("mockDomain", validate);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeValidatesSenderDomains()
    {
        var expectedResponse = _fixture.Create<SenderDomainModel>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ValidatesSenderDomains(new SenderDomainModel());
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeDeleteSenderDomains()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteSenderDomains("mockDomainId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeGetSenderDomains(bool validate)
    {
        var expectedResponse = _fixture.Create<SenderDomainModel>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetSenderDomains("mockDomainId", validate);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSaveSenderDomains()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SaveSenderDomains(new SenderDomainModel(), "mockDomainId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeListSenderIdentities()
    {
        var expectedResponse = _fixture.Create<List<SenderIdentity>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListSenderIdentities();
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeCreateSenderIdentities()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.CreateSenderIdentities(new SenderIdentity());
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeDeleteSenderIdentitiesByIdentityId()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteSenderIdentitiesByIdentityId("mockIdentityId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetSenderIdentitiesByIdentityId()
    {
        var expectedResponse = _fixture.Create<SenderIdentity>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetSenderIdentitiesByIdentityId("mockIdentityId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSaveSenderIdentitiesByIdentityId()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SaveSenderIdentitiesByIdentityId(new SenderIdentity(), "mockIdentityId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task CanInvokeListSourceSystems(bool statistics)
    {
        var expectedResponse = _fixture.Create<List<Source>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListSourceSystems(statistics);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokePostSources()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.PostSources(new Source());
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeDeleteSources()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteSources("mockSourceId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetSource()
    {
        var expectedResponse = _fixture.Create<Source>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetSource("mockSourceId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeUpdateSources()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.UpdateSources(new Source(), "mockSourceId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true, true, true)]
    [InlineData(true, true, false)]
    [InlineData(true, false, true)]
    [InlineData(true, false, false)]
    [InlineData(false, true, true)]
    [InlineData(false, true, false)]
    [InlineData(false, false, true)]
    [InlineData(false, false, false)]
    public async Task CanInvokeListMessagesPerSource(bool addheaders, bool addonlinelink, bool addtags)
    {
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessagesPerSource(new date_range(), new items_range(), "mockSourceId", addheaders, addonlinelink, addtags);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(42)]
    public async Task CanInvokeGetStatisticsForASource(int interval)
    {
        var expectedResponse = _fixture.Create<DataSets>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetStatisticsForASource(new date_range(), "mockSourceId", interval);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeListUsersPerSourceSystem()
    {
        var expectedResponse = _fixture.Create<List<Credentials>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListUsersPerSourceSystem("mockSourceId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokePostUsersBySources()
    {
        var expectedResponse = _fixture.Create<Credentials>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.PostUsersBySources(new Credentials(), "mockSourceId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeDeleteUsersBySources()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteUsersBySources("mockSourceId", "mockUserId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetUsersBySources()
    {
        var expectedResponse = _fixture.Create<Credentials>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetUsersBySources("mockSourceId", "mockUserId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeUpdateUsersBySources()
    {
        var expectedResponse = _fixture.Create<Credentials>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.UpdateUsersBySources(new Credentials(), "mockSourceId", "mockUserId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Theory]
    [InlineData(true, true, true, true, null)]
    [InlineData(true, true, true, true, "sortorderMockValue")]
    [InlineData(true, true, true, false, null)]
    [InlineData(true, true, true, false, "sortorderMockValue")]
    [InlineData(true, true, false, true, null)]
    [InlineData(true, true, false, true, "sortorderMockValue")]
    [InlineData(true, true, false, false, null)]
    [InlineData(true, true, false, false, "sortorderMockValue")]
    [InlineData(true, false, true, true, null)]
    [InlineData(true, false, true, true, "sortorderMockValue")]
    [InlineData(true, false, true, false, null)]
    [InlineData(true, false, true, false, "sortorderMockValue")]
    [InlineData(true, false, false, true, null)]
    [InlineData(true, false, false, true, "sortorderMockValue")]
    [InlineData(true, false, false, false, null)]
    [InlineData(true, false, false, false, "sortorderMockValue")]
    [InlineData(false, true, true, true, null)]
    [InlineData(false, true, true, true, "sortorderMockValue")]
    [InlineData(false, true, true, false, null)]
    [InlineData(false, true, true, false, "sortorderMockValue")]
    [InlineData(false, true, false, true, null)]
    [InlineData(false, true, false, true, "sortorderMockValue")]
    [InlineData(false, true, false, false, null)]
    [InlineData(false, true, false, false, "sortorderMockValue")]
    [InlineData(false, false, true, true, null)]
    [InlineData(false, false, true, true, "sortorderMockValue")]
    [InlineData(false, false, true, false, null)]
    [InlineData(false, false, true, false, "sortorderMockValue")]
    [InlineData(false, false, false, true, null)]
    [InlineData(false, false, false, true, "sortorderMockValue")]
    [InlineData(false, false, false, false, null)]
    [InlineData(false, false, false, false, "sortorderMockValue")]
    public async Task CanInvokeListMessagesPerTag(bool addheaders, bool addonlinelink, bool addtags, bool initDaterange, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<Message>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListMessagesPerTag(new RangeHeaderValue(), "mockTag", addheaders, addonlinelink, addtags, daterange, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeListTemplates()
    {
        var expectedResponse = _fixture.Create<List<Template>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListTemplates();
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeCreateTemplate()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)201, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.CreateTemplate(new Template());
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeDeleteTemplate()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.DeleteTemplate("mockTemplateId");
        response.Should().Be(expectedResponse);
    }

    [Fact]
    public async Task CanInvokeGetTemplate()
    {
        var expectedResponse = _fixture.Create<Template>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.GetTemplate("mockTemplateId");
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }

    [Fact]
    public async Task CanInvokeSaveTemplate()
    {
        var expectedResponse = _fixture.Create<string>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)200, _ => new StringContent(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.SaveTemplate(new Template(), "mockTemplateId");
        response.Should().Be(expectedResponse);
    }

    [Theory]
    [InlineData(true, true, true, true, true, true, null)]
    [InlineData(true, true, true, true, true, true, "sortorderMockValue")]
    [InlineData(true, true, true, true, true, false, null)]
    [InlineData(true, true, true, true, true, false, "sortorderMockValue")]
    [InlineData(true, true, true, true, false, true, null)]
    [InlineData(true, true, true, true, false, true, "sortorderMockValue")]
    [InlineData(true, true, true, true, false, false, null)]
    [InlineData(true, true, true, true, false, false, "sortorderMockValue")]
    [InlineData(true, true, true, false, true, true, null)]
    [InlineData(true, true, true, false, true, true, "sortorderMockValue")]
    [InlineData(true, true, true, false, true, false, null)]
    [InlineData(true, true, true, false, true, false, "sortorderMockValue")]
    [InlineData(true, true, true, false, false, true, null)]
    [InlineData(true, true, true, false, false, true, "sortorderMockValue")]
    [InlineData(true, true, true, false, false, false, null)]
    [InlineData(true, true, true, false, false, false, "sortorderMockValue")]
    [InlineData(true, true, false, true, true, true, null)]
    [InlineData(true, true, false, true, true, true, "sortorderMockValue")]
    [InlineData(true, true, false, true, true, false, null)]
    [InlineData(true, true, false, true, true, false, "sortorderMockValue")]
    [InlineData(true, true, false, true, false, true, null)]
    [InlineData(true, true, false, true, false, true, "sortorderMockValue")]
    [InlineData(true, true, false, true, false, false, null)]
    [InlineData(true, true, false, true, false, false, "sortorderMockValue")]
    [InlineData(true, true, false, false, true, true, null)]
    [InlineData(true, true, false, false, true, true, "sortorderMockValue")]
    [InlineData(true, true, false, false, true, false, null)]
    [InlineData(true, true, false, false, true, false, "sortorderMockValue")]
    [InlineData(true, true, false, false, false, true, null)]
    [InlineData(true, true, false, false, false, true, "sortorderMockValue")]
    [InlineData(true, true, false, false, false, false, null)]
    [InlineData(true, true, false, false, false, false, "sortorderMockValue")]
    [InlineData(true, false, true, true, true, true, null)]
    [InlineData(true, false, true, true, true, true, "sortorderMockValue")]
    [InlineData(true, false, true, true, true, false, null)]
    [InlineData(true, false, true, true, true, false, "sortorderMockValue")]
    [InlineData(true, false, true, true, false, true, null)]
    [InlineData(true, false, true, true, false, true, "sortorderMockValue")]
    [InlineData(true, false, true, true, false, false, null)]
    [InlineData(true, false, true, true, false, false, "sortorderMockValue")]
    [InlineData(true, false, true, false, true, true, null)]
    [InlineData(true, false, true, false, true, true, "sortorderMockValue")]
    [InlineData(true, false, true, false, true, false, null)]
    [InlineData(true, false, true, false, true, false, "sortorderMockValue")]
    [InlineData(true, false, true, false, false, true, null)]
    [InlineData(true, false, true, false, false, true, "sortorderMockValue")]
    [InlineData(true, false, true, false, false, false, null)]
    [InlineData(true, false, true, false, false, false, "sortorderMockValue")]
    [InlineData(true, false, false, true, true, true, null)]
    [InlineData(true, false, false, true, true, true, "sortorderMockValue")]
    [InlineData(true, false, false, true, true, false, null)]
    [InlineData(true, false, false, true, true, false, "sortorderMockValue")]
    [InlineData(true, false, false, true, false, true, null)]
    [InlineData(true, false, false, true, false, true, "sortorderMockValue")]
    [InlineData(true, false, false, true, false, false, null)]
    [InlineData(true, false, false, true, false, false, "sortorderMockValue")]
    [InlineData(true, false, false, false, true, true, null)]
    [InlineData(true, false, false, false, true, true, "sortorderMockValue")]
    [InlineData(true, false, false, false, true, false, null)]
    [InlineData(true, false, false, false, true, false, "sortorderMockValue")]
    [InlineData(true, false, false, false, false, true, null)]
    [InlineData(true, false, false, false, false, true, "sortorderMockValue")]
    [InlineData(true, false, false, false, false, false, null)]
    [InlineData(true, false, false, false, false, false, "sortorderMockValue")]
    [InlineData(false, true, true, true, true, true, null)]
    [InlineData(false, true, true, true, true, true, "sortorderMockValue")]
    [InlineData(false, true, true, true, true, false, null)]
    [InlineData(false, true, true, true, true, false, "sortorderMockValue")]
    [InlineData(false, true, true, true, false, true, null)]
    [InlineData(false, true, true, true, false, true, "sortorderMockValue")]
    [InlineData(false, true, true, true, false, false, null)]
    [InlineData(false, true, true, true, false, false, "sortorderMockValue")]
    [InlineData(false, true, true, false, true, true, null)]
    [InlineData(false, true, true, false, true, true, "sortorderMockValue")]
    [InlineData(false, true, true, false, true, false, null)]
    [InlineData(false, true, true, false, true, false, "sortorderMockValue")]
    [InlineData(false, true, true, false, false, true, null)]
    [InlineData(false, true, true, false, false, true, "sortorderMockValue")]
    [InlineData(false, true, true, false, false, false, null)]
    [InlineData(false, true, true, false, false, false, "sortorderMockValue")]
    [InlineData(false, true, false, true, true, true, null)]
    [InlineData(false, true, false, true, true, true, "sortorderMockValue")]
    [InlineData(false, true, false, true, true, false, null)]
    [InlineData(false, true, false, true, true, false, "sortorderMockValue")]
    [InlineData(false, true, false, true, false, true, null)]
    [InlineData(false, true, false, true, false, true, "sortorderMockValue")]
    [InlineData(false, true, false, true, false, false, null)]
    [InlineData(false, true, false, true, false, false, "sortorderMockValue")]
    [InlineData(false, true, false, false, true, true, null)]
    [InlineData(false, true, false, false, true, true, "sortorderMockValue")]
    [InlineData(false, true, false, false, true, false, null)]
    [InlineData(false, true, false, false, true, false, "sortorderMockValue")]
    [InlineData(false, true, false, false, false, true, null)]
    [InlineData(false, true, false, false, false, true, "sortorderMockValue")]
    [InlineData(false, true, false, false, false, false, null)]
    [InlineData(false, true, false, false, false, false, "sortorderMockValue")]
    [InlineData(false, false, true, true, true, true, null)]
    [InlineData(false, false, true, true, true, true, "sortorderMockValue")]
    [InlineData(false, false, true, true, true, false, null)]
    [InlineData(false, false, true, true, true, false, "sortorderMockValue")]
    [InlineData(false, false, true, true, false, true, null)]
    [InlineData(false, false, true, true, false, true, "sortorderMockValue")]
    [InlineData(false, false, true, true, false, false, null)]
    [InlineData(false, false, true, true, false, false, "sortorderMockValue")]
    [InlineData(false, false, true, false, true, true, null)]
    [InlineData(false, false, true, false, true, true, "sortorderMockValue")]
    [InlineData(false, false, true, false, true, false, null)]
    [InlineData(false, false, true, false, true, false, "sortorderMockValue")]
    [InlineData(false, false, true, false, false, true, null)]
    [InlineData(false, false, true, false, false, true, "sortorderMockValue")]
    [InlineData(false, false, true, false, false, false, null)]
    [InlineData(false, false, true, false, false, false, "sortorderMockValue")]
    [InlineData(false, false, false, true, true, true, null)]
    [InlineData(false, false, false, true, true, true, "sortorderMockValue")]
    [InlineData(false, false, false, true, true, false, null)]
    [InlineData(false, false, false, true, true, false, "sortorderMockValue")]
    [InlineData(false, false, false, true, false, true, null)]
    [InlineData(false, false, false, true, false, true, "sortorderMockValue")]
    [InlineData(false, false, false, true, false, false, null)]
    [InlineData(false, false, false, true, false, false, "sortorderMockValue")]
    [InlineData(false, false, false, false, true, true, null)]
    [InlineData(false, false, false, false, true, true, "sortorderMockValue")]
    [InlineData(false, false, false, false, true, false, null)]
    [InlineData(false, false, false, false, true, false, "sortorderMockValue")]
    [InlineData(false, false, false, false, false, true, null)]
    [InlineData(false, false, false, false, false, true, "sortorderMockValue")]
    [InlineData(false, false, false, false, false, false, null)]
    [InlineData(false, false, false, false, false, false, "sortorderMockValue")]
    public async Task CanInvokeListUndeliveredMessages(bool addevents, bool addheaders, bool addonlinelink, bool addtags, bool initDaterange, bool initReceivedrange, string sortorder)
    {
        var daterange = initDaterange ? new date_range() : null;
        var receivedrange = initReceivedrange ? new date_range() : null;
        var expectedResponse = _fixture.Create<List<BouncedMessage>>();

        var httpClientFactory = FlowMailerMockClientFactory.Create(mockHandler =>
        {
            mockHandler.WhenStartsWith("https://api.flowmailer.net/", (HttpStatusCode)206, _ => JsonContent.Create(expectedResponse));
        });

        var flowMailerClient = new FlowMailerClient(httpClientFactory, new FlowMailerOptions() { AccountId = "1337" });

        var response = await flowMailerClient.ListUndeliveredMessages(new RangeHeaderValue(), addevents, addheaders, addonlinelink, addtags, daterange, receivedrange, sortorder);
        var responseJson = JsonConvert.SerializeObject(response, Formatting.Indented);
        var expectedJson = JsonConvert.SerializeObject(expectedResponse, Formatting.Indented);

        responseJson.Should().Be(expectedJson);
    }
}
