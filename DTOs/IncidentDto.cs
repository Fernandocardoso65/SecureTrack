using System.ComponentModel.DataAnnotations;

namespace SecureTrack.Api.DTOs;

public class IncidentDto
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(500, MinimumLength = 5)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [RegularExpression("Low|Medium|High|Critical")]
    public string Severity { get; set; } = "Medium";

    [Required]
    [RegularExpression("Open|InProgress|Resolved")]
    public string Status { get; set; } = "Open";
}
