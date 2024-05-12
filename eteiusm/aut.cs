private static async Task<bool> CheckProxy(string proxyAddress)
{
    // Define the test URL
    const string testUrl = "http://example.com";

    // Create a HttpClientHandler and set the proxy
    var httpClientHandler = new HttpClientHandler
    {
        Proxy = new WebProxy(proxyAddress),
        UseProxy = true
    };

    // Create an HttpClient object
    using (var httpClient = new HttpClient(httpClientHandler))
    {
        try
        {
            // Set a reasonable timeout
            httpClient.Timeout = TimeSpan.FromSeconds(5);

            // Attempt to get a response from the test URL
            var response = await httpClient.GetAsync(testUrl);

            // Return true if the status code is a success code (200-299)
            return response.IsSuccessStatusCode;
        }
        catch
        {
            // If an exception occurs, the proxy is not working
            return false;
        }
    }
}
