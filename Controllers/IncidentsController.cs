using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecureTrack.Api.Data;
using SecureTrack.Api.DTOs;
using SecureTrack.Api.Models;

namespace SecureTrack.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IncidentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public IncidentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var incidents = await _context.Incidents
            .AsNoTracking()
            .OrderByDescending(i => i.CreatedAt)
            .ToListAsync();

        return Ok(incidents);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var incident = await _context.Incidents
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.Id == id);

        if (incident == null)
            return NotFound(new { message = "Incident not found." });

        return Ok(incident);
    }

    [HttpPost]
    public async Task<IActionResult> Create(IncidentDto dto)
    {
        var incident = new Incident
        {
            Title = dto.Title,
            Description = dto.Description,
            Category = dto.Category,
            Severity = dto.Severity,
            Status = dto.Status
        };

        _context.Incidents.Add(incident);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetById),
            new { id = incident.Id },
            incident);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, IncidentDto dto)
    {
        var incident = await _context.Incidents.FindAsync(id);

        if (incident == null)
            return NotFound(new { message = "Incident not found." });

        incident.Title = dto.Title;
        incident.Description = dto.Description;
        incident.Category = dto.Category;
        incident.Severity = dto.Severity;
        incident.Status = dto.Status;

        await _context.SaveChangesAsync();

        return Ok(incident);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var incident = await _context.Incidents.FindAsync(id);

        if (incident == null)
            return NotFound(new { message = "Incident not found." });

        _context.Incidents.Remove(incident);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
