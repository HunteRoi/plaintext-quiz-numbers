using FluentAssertions;

namespace Domain.Tests;

public class PlainTextConverterShould
{
    [Theory]
    [InlineData(1, "uno")]
    [InlineData(3, "tres")]
    [InlineData(5, "cinco")]
    public void ConvertDigitIntoPlainTextWithOption(int number, string plainTextNumber)
    {
        PlainTextConverter
            .ConvertWithOption(number)
            .IfSome(value => value.Should().BeEquivalentTo(plainTextNumber));
    }
    
    [Fact]
    public void ConvertUnknownDigitIntoPlainTextWithOption()
    {
        PlainTextConverter
            .ConvertWithOption(6)
            .IsNone
            .Should()
            .BeTrue();
    }
}