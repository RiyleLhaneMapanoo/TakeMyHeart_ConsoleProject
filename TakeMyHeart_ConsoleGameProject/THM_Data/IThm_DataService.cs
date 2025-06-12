using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    internal interface IThm_DataService
    {

        public void addPlayer(String name);
        public int getlovePts();
        public int setlovePts(int value);

        public string getName();

        public string[] storyLineLibrary();

        public string[] choicesALibrary();
        public string[] choicesBLibrary();

        public string[] StoryDialougeA();
        public string[] StoryDialougeB();

        public int setfinalLovePts(int finalLovepts);

        public int getfinalLovePts();

        public void addHighScore(int highScoreSlot, int highscoreNum, string playerName);

        public List<(int highScoreSlot, int highscoreNum, string playerName)> getHighScoreList();

        public void removeItemonHSList();
       //s public int highscoreslotIncrementor();


        //for tuple list 
        //   public void SaveGame(int slotId, int lovePoints, List<int> storyProgress);


        }
}
