using FluentAssertions;

namespace Domain.Tests;

public class PlainTextConverterShould
{
    [Theory]
    [InlineData(0, "cero")]
    [InlineData(1, "uno")]
    [InlineData(2, "dos")]
    [InlineData(3, "tres")]
    [InlineData(4, "cuatro")]
    [InlineData(5, "cinco")]
    [InlineData(6, "seis")]
    [InlineData(7, "siete")]
    [InlineData(8, "ocho")]
    [InlineData(9, "nueve")]
    public void ConvertKnownDigitIntoPlainText(int number, string plainTextNumber)
    {
        var option = PlainTextConverter.ConvertWithOption(number);

        option.IfSome(value => value.Should().BeEquivalentTo(plainTextNumber));
        option.IsNone.Should().BeFalse();
    }

    [Fact]
    public void ConvertUnknownDigitIntoPlainText()
    {
        PlainTextConverter.ConvertWithOption(-1)
            .IsNone
            .Should()
            .BeTrue();
    }
}