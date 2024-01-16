// PatientController.cs
using MedicalConsultancyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/patients")]
[Authorize(Roles = "Admin,Doctor")] // Adjust roles based on your needs
public class PatientController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public PatientController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult GetPatients()
    {
        var patients = _dbContext.Patients.ToList();
        return Ok(patients);
    }

    [HttpPost]
    public IActionResult AddPatient([FromBody] PatientModel patient)
    {
        _dbContext.Patients.Add(patient);
        _dbContext.SaveChanges();
        return Ok(patient);
    }

    // Add other CRUD operations for Patient as needed
}
