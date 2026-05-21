using System.Runtime.CompilerServices;
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

    [Fact]
    public void ParseNullableInt_WithValidIntValue_ReturnsParsedInt()
    {
        var value = "2139";
        var result = CsvValueParser.ParseNullableInt(value);

        Assert.Equal(2139, result);
    }

    [Fact]
    public void ParseNullableInt_WithNonNumericalValue_ReturnsNull()
    {
        var value = "jrkjfrkjf";
        var result = CsvValueParser.ParseNullableInt(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseNullableInt_WithEmptyString_ReturnsNull()
    {
        var value = "   ";
        var result = CsvValueParser.ParseNullableInt(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseNullableDouble_WithValidDoubleValue_ReturnsParsedDouble()
    {
        var value = "34.2011";
        var result = CsvValueParser.ParseNullableDouble(value);
        Assert.Equal(result, 34.2011);
    }
    [Fact]
    public void ParseNullableDouble_WithValidNegativeDoubleValue_ReturnsParsedNegativeDouble()
    {
        var value = "-118.3025";
        var result = CsvValueParser.ParseNullableDouble(value);
        Assert.Equal(result, -118.3025);
    }

    [Fact]
    public void ParseNullableDouble_WithNonNumericalValue_ReturnsNull()
    {
        var value = "jrkjfrkjf";
        var result = CsvValueParser.ParseNullableDouble(value);
        Assert.Null(result);
    }


    [Fact]
    public void ParseNullableDouble_WithEmptyString_ReturnsNull()
    {
        var value = "   ";
        var result = CsvValueParser.ParseNullableDouble(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseYesOrNo_WithValidYesString_ReturnsBoolean()
    {
        var value = "Yes";
        var result = CsvValueParser.ParseYesOrNo(value);
        Assert.True(result);
    }

    [Fact]
    public void ParseYesOrNo_WithValidNoString_ReturnsBoolean()
    {
        var value = "No";
        var result = CsvValueParser.ParseYesOrNo(value);
        Assert.False(result);
    }

    [Fact]
    public void ParseYesOrNo_WithInvalidNumericValue_ReturnsNull()
    {
        var value = "123034";
        var result = CsvValueParser.ParseYesOrNo(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseYesOrNo_WithNonYesOrNoValue_ReturnnsNull()
    {
        var value = "banana";
        var result = CsvValueParser.ParseYesOrNo(value);
        Assert.Null(result);
    }

    [Fact]
    public void ParseYesOrNo_WithWhiteSpace_ReturnsNull()
    {
        var value = "   ";
        var result = CsvValueParser.ParseYesOrNo(value);
        Assert.Null(result);
    }
}