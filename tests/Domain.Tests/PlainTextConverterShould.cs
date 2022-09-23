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
    [InlineData(10, "diez")]
    [InlineData(11, "once")]
    [InlineData(12, "doce")]
    [InlineData(13, "trece")]
    [InlineData(14, "catorce")]
    [InlineData(15, "quince")]
    [InlineData(16, "dieciséis")]
    [InlineData(17, "diecisiete")]
    [InlineData(18, "dieciocho")]
    [InlineData(19, "diecinueve")]
    [InlineData(20, "veinte")]
    [InlineData(21, "veintiuno")]
    [InlineData(22, "veintidós")]
    [InlineData(23, "veintitrés")]
    [InlineData(24, "veinticuatro")]
    [InlineData(25, "veinticinco")]
    [InlineData(26, "veintiséis")]
    [InlineData(27, "veintisiete")]
    [InlineData(28, "vientiocho")]
    [InlineData(29, "vientinueve")]
    public void ConvertKnownNumberIntoPlainText(int number, string plainTextNumber)
    {
        var option = PlainTextConverter.Convert(number);

        option.IfSome(value => value.Should().BeEquivalentTo(plainTextNumber));
        option.IsNone.Should().BeFalse();
    }

    [Fact]
    public void ConvertUnknownDigitIntoPlainText()
    {
        PlainTextConverter.Convert(-1)
            .IsNone
            .Should()
            .BeTrue();
    }
}