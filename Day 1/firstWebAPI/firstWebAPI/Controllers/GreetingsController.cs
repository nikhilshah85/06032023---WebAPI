using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {


        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            return Ok("Hello and Welcome to WebAPI Development");
        }

        [HttpGet]
        [Route("greet/guestName")]
        public IActionResult Greetings(string guestName)
        {
            string message = "Hello " + guestName + " good morning";
            return Ok(message);
        }

           static List<string> techList = new List<string>()
           {
               ".Net","Java","SQL Server","Web Services"
           };

        [HttpGet]
        [Route("techlist")]
        public IActionResult GettechList()
        {
            return Ok(techList);
        }
        [HttpGet]
        [Route("techlist/{idx}")]
        public IActionResult TechbyIndex(int idx)
        {
            try
            {
                return Ok(techList[idx]);
            }
            catch (Exception es)
            {
                return NotFound("No Technology at this index");
            }
        }


        [HttpPost]
        [Route("techlist/add/{newtech}")]
        public IActionResult AddNewTech(string newtech)
        {
            techList.Add(newtech);
            return Created("","Technology Added To List");
        }

        [HttpDelete]
        [Route("techlist/delete/{idx}")]
        public IActionResult DeleteTech(int idx)
        {
            techList.RemoveAt(idx);
            return Accepted("Technology Removed from the list");

        }

        [HttpPut]
        [Route("techlist/edit/{idx}/{newName}")]
        public  IActionResult EditTech(int idx, string newName)
        {
            techList[idx] = newName;
            return Accepted("Technology name changed successfull");
        }








    }
}
