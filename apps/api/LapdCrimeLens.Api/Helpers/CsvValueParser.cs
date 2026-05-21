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
}