using System.ComponentModel.DataAnnotations;

namespace SecureTrack.Api.Models;

public class Incident
{
    public int Id { get; set; }

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
    [StringLength(20)]
    public string Severity { get; set; } = "Medium";

    [Required]
    [StringLength(20)]
    public string Status { get; set; } = "Open";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
