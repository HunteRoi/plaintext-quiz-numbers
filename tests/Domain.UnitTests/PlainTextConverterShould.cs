using System.ComponentModel;
using FluentAssertions;
using NUnit.Framework;

namespace Domain.UnitTests;

public class PlainTextConverterShould
{
    [Test]
    [DisplayName("3 should be tres")]
    public void Convert3IntoTres() => new PlainTextConverter().Convert(3).Should().BeEquivalentTo("tres");
    
    [Test]
    [DisplayName("5 should be cinco")]
    public void Convert5IntoCinco() => new PlainTextConverter().Convert(5).Should().BeEquivalentTo("cinco");
    
    [Test]
    [DisplayName("1 should be uno")]
    public void Convert1IntoUno() => new PlainTextConverter().Convert(1).Should().BeEquivalentTo("uno");
}