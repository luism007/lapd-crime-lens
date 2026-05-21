using LapdCrimeLens.Api.DTOs.Import;
using LapdCrimeLens.Api.Import;
using LapdCrimeLens.Api.Models;

namespace LapdCrimeLens.Api.Mappers;

public static class LapdNibrsIncidentMapper
{
    public static Incident ToIncident(LapdNibrsCsvDataRow row)
    {

        var incident = new Incident();

        incident.ImportedAt = DateTime.UtcNow;
        incident.CaseNumber = row.CaseNo.Trim();
        incident.UniqueNibrNumber = row.UniqueNibrNo.Trim();

        incident.DateReported = CsvValueParser.ParseNullableDateTime(row.DateRptd);
        incident.DateOccurred = CsvValueParser.ParseNullableDateTime(row.DateOcc);
        incident.TimeOccurred = row.TimeOcc.Trim();

        incident.AreaCode = row.AreaCode.Trim();
        incident.AreaName = row.AreaName.Trim();
        incident.ReportingDistrictNumber = row.ReportingDistrictNumber.Trim();

        incident.TotalOffenseCount = CsvValueParser.ParseNullableInt(row.TotalOffenseCount);
        incident.Group = row.Group.Trim();
        incident.NibrCode = row.NibrCode.Trim();
        incident.NibrDescription = row.NibrDescription.Trim();
        incident.CrimeAgainst = row.CrimeAgainst.Trim();

        incident.PremiseCode = row.PremiseCode.Trim();
        incident.PremiseDescription = row.PremiseDescription.Trim();

        incident.WeaponUsedCode = row.WeaponUsedCode.Trim();
        incident.WeaponDescription = row.WeaponDescription.Trim();

        incident.StatusCode = row.StatusCode.Trim();
        incident.StatusDescription = row.StatusDescription.Trim();

        incident.TotalVictimCount = CsvValueParser.ParseNullableInt(row.TotalVictimCount);
        incident.IsVictimShot = CsvValueParser.ParseYesOrNo(row.VictimShot);
        incident.IsDomesticViolence = CsvValueParser.ParseYesOrNo(row.DomesticViolenceCrime);
        incident.IsHateCrime = CsvValueParser.ParseYesOrNo(row.HateCrime);
        incident.IsGangRelated = CsvValueParser.ParseYesOrNo(row.GangRelated);
        incident.IsTransitRelated = CsvValueParser.ParseYesOrNo(row.TransitRelatedCrime);
        incident.IsHomelessVictim = CsvValueParser.ParseYesOrNo(row.HomelessVictimCrime);
        incident.IsHomelessSuspect = CsvValueParser.ParseYesOrNo(row.HomelessSuspectCrime);
        incident.IsHomelessArrestee = CsvValueParser.ParseYesOrNo(row.HomelessArresteeCrime);

        incident.Location = row.Location.Trim();
        incident.Latitude = CsvValueParser.ParseNullableDouble(row.Lat);
        incident.Longitude = CsvValueParser.ParseNullableDouble(row.Lon);



        return incident;



    }
}