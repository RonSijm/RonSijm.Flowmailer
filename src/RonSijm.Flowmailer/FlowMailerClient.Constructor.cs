namespace RonSijm.Flowmailer;

public partial class FlowMailerClient
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _accountId;

    private FlowMailerClient(string clientId, string clientSecret, string accountId)
    {
        _accountId = accountId;
        _clientSecret = clientSecret;
        _clientId = clientId;
    }

    public FlowMailerClient(IHttpClientFactory clientFactory, string clientId, string clientSecret, string accountId) : this(clientId, clientSecret, accountId)
    {
        _clientFactory = clientFactory;
    }

    public FlowMailerClient(IHttpClientFactory clientFactory, FlowMailerOptions options) : this(clientFactory, options.ClientId, options.ClientSecret, options.AccountId)
    {
    }

    public FlowMailerClient(FlowMailerOptions options) : this(options.ClientId, options.ClientSecret, options.AccountId)
    {
        _clientFactory = new DefaultHttpClientFactory();
    }
}