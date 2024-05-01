using FLIPMED.Model;
using FLIPMED.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FLIPMED.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        
        private readonly IDoctorService _service;

        public DoctorController(IDoctorService service)
        {
     
            this._service = service;
        }


        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        [HttpPost("/register")]

        public IActionResult RegisterDoctors(Doctor doctor)
        {
            try
            {
                if (doctor.Id != 0)
                {
                    var createdDoctor = _service.CreateDoctor(doctor);
                    Console.WriteLine($"{doctor.Id}, {doctor.Name}, {doctor.DocSpeciality}");
                    return Ok(createdDoctor);
                }

                return BadRequest("Id cannot be null");
            }
            catch (Exception)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        //public Doctor RegisterDoctor(Doctor doctor) {
        //    Console.WriteLine($"{doctor.Id},{doctor.Name},{doctor.DocSpeciality});
        //    return _service.CreateDoctor(doctor);
        //    //Console.WriteLine("Doctor uis clled via function");
        //   // return "Heyy Doctor!";
        //}
    }
}
