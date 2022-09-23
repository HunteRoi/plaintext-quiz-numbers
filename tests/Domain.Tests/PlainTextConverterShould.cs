using FluentAssertions;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Domain.Tests;

public class PlainTextConverterShould
{
    [Theory]
    [InlineData(1, "uno")]
    [InlineData(3, "tres")]
    [InlineData(5, "cinco")]
    public void ConvertDigitIntoPlainText(int number, string expected) =>
        PlainTextConverter
            .Convert(number)
            .Should()
            .BeEquivalentTo(expected);

    [Fact]
    public void ConvertDigitIntoPlainTextWithOption()
    {
        PlainTextConverter
            .ConvertWithOption(1)
            .IfSome(value => value.Should().BeEquivalentTo("uno"));
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