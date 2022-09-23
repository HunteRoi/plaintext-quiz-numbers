using LanguageExt;

namespace Domain;

public static class PlainTextConverter
{
    private static readonly Dictionary<int, string> Mapping = new()
    {
        {1, "uno"},
        {3, "tres"},
        {5, "cinco"}
    };

    public static Option<string> ConvertWithOption(int digit)
    {
        var value = Mapping.GetValueOrDefault(digit);
        return value ?? Option<string>.None;
    }
}