// DoctorController.cs
using MedicalConsultancyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/doctors")]
[Authorize(Roles = "Admin")] // Adjust role based on your needs
public class DoctorController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public DoctorController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetDoctors()
    {
        var doctors = _dbContext.Doctors.ToList();
        return Ok(doctors);
    }

    [HttpPost]
    public IActionResult AddDoctor([FromBody] DoctorModel doctor)
    {
        _dbContext.Doctors.Add(doctor);
        _dbContext.SaveChanges();
        return Ok(doctor);
    }

    // Add other CRUD operations for Doctor as needed
}
