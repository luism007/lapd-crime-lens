namespace LapdCrimeLens.Api.Import;

public static class CsvValueParser
{
    public static DateTime? ParseNullableDateTime(string value)
    {

        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return DateTime.TryParse(value, out var parsed)
        ? parsed
        : null;
    }

    public static int? ParseNullableInt(string value)
    {
        return int.TryParse(value, out var parsed)
        ? parsed
        : null;
    }

    public static double? ParseNullableDouble(string value)
    {
        return double.TryParse(value, out var parsed)
        ? parsed
        : null;
    }

    public static bool? ParseYesOrNo(string value)
    {

        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        var normalized = value.Trim();

        if (normalized.Equals("Yes", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (normalized.Equals("No", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        return null;
    }
}