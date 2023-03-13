using System.Net.Http;
using System.Threading;

namespace RonSijm.Flowmailer.UnitTests.Helpers.HttpMock;

public class MockHttpMessageHandler
{
    private readonly Dictionary<Func<string, bool>, (HttpStatusCode ResponseCode, Func<HttpRequestMessage, HttpContent> Func)> _responses = new();

    public void WhenStartsWith(string url, HttpStatusCode code, Func<HttpRequestMessage, HttpContent> func)
    {
        _responses.Add(x => x.StartsWith(url), (code, func));
    }

    public void When(string url, HttpStatusCode code, Func<HttpRequestMessage, HttpContent> func)
    {
        _responses.Add(x => x == url, (code, func));
    }

    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.RequestUri == null)
        {
            return Task.FromResult<HttpResponseMessage>(null);
        }

        var url = request.RequestUri.ToString();

        foreach (var responseKey in _responses)
        {
            if (!responseKey.Key(url))
            {
                continue;
            }

            var message = responseKey.Value.Func.Invoke(request);

            var response = new HttpResponseMessage(responseKey.Value.ResponseCode);
            response.Content = message;

            return Task.FromResult(response);
        }

        return null;
    }
}