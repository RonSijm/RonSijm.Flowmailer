namespace RonSijm.Flowmailer.Helpers;

public class DefaultHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient(string name)
    {
        var client = new HttpClient();
        return client;
    }
}