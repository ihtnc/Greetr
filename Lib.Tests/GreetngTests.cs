using Greetr.Lib;
using Xunit;
using FluentAssertions;

namespace Lib.Tests;

public class GreetngTests
{
    [Fact]
    public void When_Calling_Get_Should_Return_Something()
    {
        // ARRANGE
        var greetng = new Greetng();

        // ACT
        var actual = greetng.Get();

        // ASSERT
        actual.Should().NotBeNullOrEmpty();
    }
}