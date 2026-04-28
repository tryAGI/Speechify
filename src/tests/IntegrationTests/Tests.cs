namespace Speechify.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SpeechifyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SPEECHIFY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SPEECHIFY_API_KEY environment variable is not found.");

        var client = new SpeechifyClient(apiKey);
        
        return client;
    }
}
