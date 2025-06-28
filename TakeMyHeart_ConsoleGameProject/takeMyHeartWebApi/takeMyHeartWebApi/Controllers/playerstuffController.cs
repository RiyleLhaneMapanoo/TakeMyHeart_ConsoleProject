using Microsoft.AspNetCore.Mvc;
using TMH_BusinessDataLogic;

namespace takeMyHeartWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class playerstuffController : Controller
    {
        THMProcess pro = new THMProcess();

        [HttpGet("getlovePts")]
        public int getlovePts()
        {
            return pro.getlovePts();
        }

        [HttpPost("setLovePts")]
        public int setLovePts(int loveP)
        {
            return pro.setLovePts(loveP);
        }

        [HttpGet("getName")]
        public string getName()
        {
            return pro.getName();
        }

        [HttpPost("addP")]
        public string addP(string name)
        {
            return pro.addP(name);
        }

        [HttpGet("InvalidChoice")]
        public string InvalidChoice()
        {
            return pro.InvalidChoice();
        }

        [HttpPost("setfinalLovePts")]
        public int setfinalLovePts(int finalLovepts)
        {
            return pro.setfinalLovePts(finalLovepts);
        }

        [HttpGet("getfinalLovePts")]
        public int getfinalLovePts()
        {
            return pro.getfinalLovePts();
        }

        [HttpPost("addHighScore")]
        public void addHighScore(int highscoreNum, string playerName)
        {
            pro.addHighScore(highscoreNum, playerName);
        }

        [HttpGet("getPlayerScoreList")]
        public List<(int highscoreNum, string playerName)> getPlayerScoreList()
        {
            return pro.getPlayerScoreList();
        }

        [HttpDelete("removeItemonHSList")]
        public void removeItemonHSList()
        {
            pro.removeItemonHSList();
        }

        [HttpPost("pointAllocation")]
        public string pointAllocation(int mainLovePts, int ptsA, int ptsB, string choice)
        {
            return pro.pointAllocation(ref mainLovePts, ptsA, ptsB, choice);
        }

        [HttpGet("SortHighScoreList")]
        public List<(int highscoreNum, string playerName)> SortHighScoreList()
        {
            return pro.SortHighScoreList();
        }


    }
}
