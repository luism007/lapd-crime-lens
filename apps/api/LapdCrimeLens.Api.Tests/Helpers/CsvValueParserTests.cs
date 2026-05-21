using LapdCrimeLens.Api.Import;
namespace LapdCrimeLens.Api.Tests.Import;

public class CsvValueParserTests
{
    [Fact]
    public void ParseNullableDateTime_WithValidIsoDateTime_ReturnParsedDateTime()
    {
        var value = "2026-04-06T20:00:33";
        var result = CsvValueParser.ParseNullableDateTime(value);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2026, result.Value.Year);
        Assert.Equal(4, result.Value.Month);
        Assert.Equal(6, result.Value.Day);
        Assert.Equal(20, result.Value.Hour);
        Assert.Equal(0, result.Value.Minute);
        Assert.Equal(33, result.Value.Second);
    }

    [Fact]
    public void ParseNullableDateTime_WithEmptyString_ReturnsNull()
    {
        var value = "";
        var result = CsvValueParser.ParseNullableDateTime(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseNullableDateTime_WithWhitespace_ReturnsNull()
    {
        var value = "    ";
        var result = CsvValueParser.ParseNullableDateTime(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseNullableDateTime_WithInvalidValue_ReturnsNull()
    {
        var value = "not-a-date";
        var result = CsvValueParser.ParseNullableDateTime(value);
        Assert.Null(result);
    }
}