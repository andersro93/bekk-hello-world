namespace BekkHelloWorld.Options;

public sealed class SiteOptions
{
    public const string Key = "Site";

    public string Greeting { get; set; } = "World";
    public string From { get; set; } = "Unknown";
}
