namespace BekkHelloWorld.Options;

public sealed class SiteOptions
{
    public const string Key = "Site";

    public string TitleText { get; set; } = "Hello World";
    public string SubText { get; set; } = "I hope you're doing fine!";
}
