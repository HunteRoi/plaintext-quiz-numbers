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
    };

    public static Option<string> Convert(int digit)
    {
        return Optional(Mapping.GetValueOrDefault(digit));
    }
}