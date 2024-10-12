namespace BekkHelloWorld.Tests.IntegrationTests;

public sealed class GreetingTests(ApplicationFixture applicationFixture) : IClassFixture<ApplicationFixture>
{
    [Fact]
    public async Task ACallToRoot_ShouldReturnHelloWithCorrectGreeting()
    {
        // Arrange
        var httpClient = applicationFixture.CreateClient();

        // Act
        var response = await httpClient.GetStringAsync("/");

        // Assert
        response.Should().Contain(ApplicationFixture.Greeting);
        response.Should().Contain(ApplicationFixture.From);
    }
}
