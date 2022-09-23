using LanguageExt;

namespace Domain;

public static class PlainTextConverter
{
    private static Dictionary<int, string> _mapping = new()
    {
        {1, "uno"},
        {3, "tres"},
        {5, "cinco"}
    };
    
    public static string Convert(int digit)
    {
        return _mapping.GetValueOrDefault(digit);
    }

    public static Option<string> ConvertWithOption(int digit)
    {
        return Optional(Convert(digit));
    }
}