var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddOptions<SiteOptions>()
    .Bind(builder.Configuration.GetSection(SiteOptions.Key));

var app = builder.Build();

app.MapGet("/", (IOptionsSnapshot<SiteOptions> options) =>
{
    var siteOptions = options.Value;
    return $"Hello, {siteOptions.Greeting}, from {siteOptions.From}";
});

app.Run();
