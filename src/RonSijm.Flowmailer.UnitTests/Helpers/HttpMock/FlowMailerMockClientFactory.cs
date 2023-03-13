namespace RonSijm.Flowmailer.UnitTests.Helpers.HttpMock;

public static class FlowMailerMockClientFactory
{
    public static MockHttpClientFactory Create(Action<MockHttpMessageHandler> setup)
    {
        var mockHandler = new MockHttpMessageHandler();
        var token = new OAuthTokenResponse() { AccessToken = "MockAccessToken", ExpiresIn = 99, Received = DateTime.Now, Scope = "API" };

        mockHandler.When("https://login.flowmailer.net/oauth/token", HttpStatusCode.OK, _ => new StringContent(JsonConvert.SerializeObject(token)));
        setup(mockHandler);

        var mockClient = new MockHttpClient(mockHandler);

        var httpClientFactory = new MockHttpClientFactory(mockClient);
        return httpClientFactory;
    }
}