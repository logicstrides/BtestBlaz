using Microsoft.AspNetCore.Mvc;
using BtestShared.Models;

namespace BtestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        

        [HttpGet(Name = "GetStudents")]
        public IEnumerable<Students> GetAllStudents()
        {
           List<Students> list = new List<Students>();
            Students student = new Students();
            student.Id = 100;
            student.FirstName = "Godwin";
            student.LastName = "Ugbegban";
            list.Add(student);

            student = new Students();
            student.Id = 101;
            student.FirstName = "Emeka";
            student.LastName = "David";
            list.Add(student);



            student = new Students();
            student.Id = 102;
            student.FirstName = "Elom";
            student.LastName = "Ericson";
            list.Add(student);





            student = new Students();
            student.Id = 103;
            student.FirstName = "Bill";
            student.LastName = "Gates";
            list.Add(student);




            student = new Students();
            student.Id = 104;
            student.FirstName = "James";
            student.LastName = "Brown";
            list.Add(student);



            student = new Students();
            student.Id = 105;
            student.FirstName = "Felix";
            student.LastName = "Okeke";
            list.Add(student);


            student = new Students();
            student.Id = 106;
            student.FirstName = "Akindele";
            student.LastName = "Mark";
            list.Add(student);



            student = new Students();
            student.Id = 107;
            student.FirstName = "Oluwole";
            student.LastName = "Ogaba";
            list.Add(student);



            student = new Students();
            student.Id = 108;
            student.FirstName = "Oguygbe";
            student.LastName = "Philips";
            list.Add(student);





            student = new Students();
            student.Id = 109;
            student.FirstName = "Hope";
            student.LastName = "Ubiaroko";
            list.Add(student);




            student = new Students();
            student.Id = 200;
            student.FirstName = "Kazeem";
            student.LastName = "Okeke";
            list.Add(student);




            return list.ToArray();
            
        }
    }
}