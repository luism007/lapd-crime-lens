namespace LapdCrimeLens.Api.Models;

public class Incident
{
    public int Id { get; set; }

    // App Tracking
    public DateTime ImportedAt { get; set; } = DateTime.UtcNow;

    // LAPD / NIBR Identifiers
    public string CaseNumber { get; set; } = string.Empty;
    public string UniqueNibrNumber { get; set; } = string.Empty;

    // Date & Times
    public DateTime? DateReported { get; set; }
    public DateTime? DateOccurred { get; set; }
    public string TimeOccurred { get; set; } = string.Empty;

    // LAPD Area/Reporting Info
    public string AreaCode { get; set; } = string.Empty;
    public string AreaName { get; set; } = string.Empty;
    public string ReportingDistrictNumber { get; set; } = string.Empty;

    // Offense Info
    public int? TotalOffenseCount { get; set; }
    public string Group { get; set; } = string.Empty;
    public string NibrCode { get; set; } = string.Empty;
    public string NibrDescription { get; set; } = string.Empty;
    public string CrimeAgainst { get; set; } = string.Empty;

    // Premise Info
    public string PremiseCode { get; set; } = string.Empty;
    public string PremiseDescription { get; set; } = string.Empty;

    // Weapon Info
    public string WeaponUsedCode { get; set; } = string.Empty;
    public string WeaponDescription { get; set; } = string.Empty;

    // Status Info
    public string StatusCode { get; set; } = string.Empty;
    public string StatusDescription { get; set; } = string.Empty;

    // Victim / Incident Flags
    public int? TotalVictimCount { get; set; }
    public bool? IsVictimShot { get; set; }
    public bool? IsDomesticViolence { get; set; }
    public bool? IsHateCrime { get; set; }
    public bool? IsGangRelated { get; set; }
    public bool? IsTransitRelated { get; set; }
    public bool? IsHomelessVictim { get; set; }
    public bool? IsHomelessSuspect { get; set; }
    public bool? IsHomelessArrestee { get; set; }

    // Location
    public string Location { get; set; } = string.Empty;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }


}