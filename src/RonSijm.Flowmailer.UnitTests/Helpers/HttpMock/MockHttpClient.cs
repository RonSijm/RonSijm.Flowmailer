using System.Net.Http;
using System.Threading;

namespace RonSijm.Flowmailer.UnitTests.Helpers.HttpMock;

public class MockHttpClient : HttpClient
{
    private readonly MockHttpMessageHandler _mockHttpMessageHandler;

    public MockHttpClient(MockHttpMessageHandler mockHttpMessageHandler)
    {
        _mockHttpMessageHandler = mockHttpMessageHandler;
    }

    public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return _mockHttpMessageHandler.SendAsync(request, cancellationToken);
    }
}