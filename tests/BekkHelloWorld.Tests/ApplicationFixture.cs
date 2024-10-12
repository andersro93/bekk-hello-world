namespace BekkHelloWorld.Tests;

public sealed class ApplicationFixture : WebApplicationFactory<IBekkHelloWorldAssemblyMarker>
{
    internal const string Greeting = "TEST SUITE";
    internal const string From = "xUnit";

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseSetting("SITE:GREETING", Greeting);
        builder.UseSetting("SITE:FROM", From);
    }
}
