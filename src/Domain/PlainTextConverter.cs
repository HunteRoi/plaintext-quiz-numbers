using LanguageExt;
using static LanguageExt.Prelude;

namespace Domain;

public static class PlainTextConverter
{
    private static readonly Dictionary<int, string> Mapping = new()
    {
        {0, "cero"},
        {1, "uno"},
        {2, "dos"},
        {3, "tres"},
        {4, "cuatro"},
        {5, "cinco"},
        {6, "seis"},
        {7, "siete"},
        {8, "ocho"},
        {9, "nueve"},
    };

    public static Option<string> ConvertWithOption(int digit)
    {
        return Optional(Mapping.GetValueOrDefault(digit));
    }
}