namespace LapdCrimeLens.Api.DTOs.Import;

public class LapdNibrsCsvDataRow
{
    public string CaseNo { get; set; } = string.Empty;
    public string UniqueNibrNo { get; set; } = string.Empty;
    public string DateRptd { get; set; } = string.Empty;
    public string DateOcc { get; set; } = string.Empty;
    public string TimeOcc { get; set; } = string.Empty;
    public string AreaCode { get; set; } = string.Empty;
    public string AreaName { get; set; } = string.Empty;
    public string ReportingDistrictNumber { get; set; } = string.Empty;
    public string TotalOffenseCount { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string NibrCode { get; set; } = string.Empty;
    public string NibrDescription { get; set; } = string.Empty;
    public string CrimeAgainst { get; set; } = string.Empty;
    public string PremiseCode { get; set; } = string.Empty;
    public string PremiseDescription { get; set; } = string.Empty;
    public string WeaponUsedCode { get; set; } = string.Empty;
    public string WeaponDescription { get; set; } = string.Empty;
    public string StatusCode { get; set; } = string.Empty;
    public string StatusDescription { get; set; } = string.Empty;
    public string TotalVictimCount { get; set; } = string.Empty;
    public string VictimShot { get; set; } = string.Empty;
    public string DomesticViolenceCrime { get; set; } = string.Empty;
    public string HateCrime { get; set; } = string.Empty;
    public string GangRelated { get; set; } = string.Empty;
    public string TransitRelatedCrime { get; set; } = string.Empty;
    public string HomelessVictimCrime { get; set; } = string.Empty;
    public string HomelessSuspectCrime { get; set; } = string.Empty;
    public string HomelessArresteeCrime { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Lat { get; set; } = string.Empty;
    public string Lon { get; set; } = string.Empty;

}