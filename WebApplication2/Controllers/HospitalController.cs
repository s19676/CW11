using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalDbContext _context;
        public HospitalController(HospitalDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctors = _context.Doctors.ToList();
            return Ok(doctors);
        }

        [HttpPut]
        public IActionResult AddDoctor(Doctor doctor)
        {
            try
            {
                _context.Doctors.Add(doctor);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return BadRequest(doctor);
            }
        }


        [HttpPost]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            try
            {
                _context.Doctors.Update(doctor);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return BadRequest(doctor);
            }
        }

        [HttpDelete]
        public IActionResult RemoveDoctor(Doctor doctor)
        {
            try
            {
                _context.Doctors.Remove(doctor);
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return BadRequest(doctor);
            }
        }
    }
}