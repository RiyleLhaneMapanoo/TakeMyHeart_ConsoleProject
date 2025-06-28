using Microsoft.AspNetCore.Mvc;
using TMH_BusinessDataLogic;

namespace takeMyHeartWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class storystuffController : Controller
   
    {
        THMProcess pro = new THMProcess();


        [HttpGet(Name = "GetWeatherForecast")]

        [HttpGet("getstoryLineLibrary")]
        public string[] getstoryLineLibrary() { 
        
        return pro.getstoryLineLibrary();
        }

        [HttpGet("getchoicesALibrary")]
        public string[] getchoicesALibrary() { 
        
            return pro.getchoicesALibrary();
        }

        [HttpGet("getchoicesBLibrary")]
        public string[] getchoicesBLibrary() {
            return pro.getchoicesBLibrary();
                }

        [HttpGet("getStoryDialougeA")]
        public string[] getStoryDialougeA() {

            return pro.getStoryDialougeA();
        }

        [HttpGet("getStoryDialougeB")]
        public string[] getStoryDialougeB() {

            return pro.getStoryDialougeB();
        }

        [HttpGet("getroutesData")]
        public string[] getroutesData() {

            return pro.getroutesData();
        }




    }
}
