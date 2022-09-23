using FluentAssertions;

namespace Domain.Tests;

public class PlainTextConverterShould
{
    [Fact]
    public void Convert3IntoTres() => PlainTextConverter.Convert(3).Should().BeEquivalentTo("tres");
    
    [Fact]
    public void Convert5IntoCinco() => PlainTextConverter.Convert(5).Should().BeEquivalentTo("cinco");
    
    [Fact]
    public void Convert1IntoUno() => PlainTextConverter.Convert(1).Should().BeEquivalentTo("uno");
}