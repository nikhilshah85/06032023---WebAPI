using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DI_Demo.Model;
namespace DI_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        //this is a bad code, if do not implement IDisposable
        //Employee empObj = new Employee(); 

       private Employee _empObj;

        //runtime will create the object and pass the reference to controller in a variables - _empObjREF
        public EmployeeController(Employee _empObjREF)
        {
            _empObj = _empObjREF;
        }



        [HttpGet]
        [Route("elist")]
        public IActionResult GetAllEmployees()
        {
            var result = _empObj.GetAllEmployees();
            return Ok(result);
        }


    }
}
