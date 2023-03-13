using System.Net.Http;

namespace RonSijm.Flowmailer.UnitTests.Helpers.HttpMock;

public class MockHttpClientFactory : IHttpClientFactory
{
    private readonly HttpClient _instance;

    public MockHttpClientFactory(HttpClient instance)
    {
        _instance = instance;
    }

    public HttpClient CreateClient(string name)
    {
        return _instance;
    }
}