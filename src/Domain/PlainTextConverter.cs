using LanguageExt;
using LanguageExt.UnsafeValueAccess;
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
        {10, "diez"},
        {11, "once"},
        {12, "doce"},
        {13, "trece"},
        {14, "catorce"},
        {15, "quince"},
        {16, "dieciséis"},
        {17, "diecisiete"},
        {18, "dieciocho"},
        {19, "diecinueve"},
        {20, "veinte"},
        {21, "veintiuno"},
        {22, "veintidós"},
        {23, "veintitrés"},
        {24, "veinticuatro"},
        {25, "veinticinco"},
        {26, "veintiséis"},
        {27, "veintisiete"},
        {28, "vientiocho"},
        {29, "vientinueve"},
        {30, "treinta"},
        {40, "cuarenta"},
        {50, "cincuenta"},
        {60, "sesenta"},
        {70, "setenta"},
        {80, "ochenta"},
        {90, "noventa"},
        {100, "ciento"},
        {110, "ciento y diez"}
    };

    private static string? InnerConvert(int number)
    {
        return Mapping.GetValueOrDefault(number);
    }
    
    public static Option<string> Convert(int number)
    {
        if (number < 100 && number > 30 && number % 10 != 0)
        {
            int rest = number % 10;
            int substraction = number - rest;
            var substractionAsPlainText = InnerConvert(substraction);
            var restAsPlainText = InnerConvert(rest);
            return $"{substractionAsPlainText} y {restAsPlainText}";
        }
        if (number > 100 && number % 100 != 0)
        {
            int rest = number % 100;
            int substraction = number - rest;
            var substractionAsPlainText = InnerConvert(substraction);
            var restAsPlainText = InnerConvert(rest);
            return $"{substractionAsPlainText} y {restAsPlainText}";
        }
        return Optional(InnerConvert(number));
    }
}