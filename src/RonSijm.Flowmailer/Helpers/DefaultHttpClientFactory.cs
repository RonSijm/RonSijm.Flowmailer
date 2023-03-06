namespace RonSijm.Flowmailer.Helpers;

internal class DefaultHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient(string name)
    {
        var client = new HttpClient();
        return client;
    }
}