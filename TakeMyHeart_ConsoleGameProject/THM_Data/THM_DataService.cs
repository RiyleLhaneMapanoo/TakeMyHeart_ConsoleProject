using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    public class THM_DataService
    {
        IThm_DataService dataLogic;
        public THM_DataService() { 
        
           // dataLogic = new THM_textMemoryDataService();
            dataLogic = new THM_InMemory();
          // dataLogic = new THM_JSONDataService();
        }


        public void addPlayer(String name) {
            dataLogic.addPlayer(name);
        }
        public int getLovePts() {
            return dataLogic.getlovePts();
        }
        public int setLovePts(int value) {
            return dataLogic.setlovePts(value);
        }
        public string getName() {
            return dataLogic.getName();
        }
        public string[] storyLineLibrary() {
            return dataLogic.storyLineLibrary();
        }
        public string[] choicesALibrary() {
            return dataLogic.choicesALibrary();
        }
        public string[] choicesBLibrary() {
            return dataLogic.choicesBLibrary();
        }
        public string[] StoryDialougeA() {
            return dataLogic.StoryDialougeA();
        }
        public string[] StoryDialougeB() {
            return dataLogic.StoryDialougeB();
        }

        public int setfinalLovePts(int finalLovepts)
        {
            return dataLogic.setfinalLovePts(finalLovepts);
        }
        public int getfinalLovePts()
        {
            return dataLogic.getfinalLovePts();
        }
        public void addHighScore(int highScoreSlot, int highscoreNum, string playerName)
        {
            dataLogic.addHighScore(highScoreSlot, highscoreNum, playerName);
        }
        public List<(int highScoreSlot, int highscoreNum, string playerName)> getHighScoreList()
        {
            return dataLogic.getHighScoreList();
        }

        public void removeItemonHSList()
        {
            dataLogic.removeItemonHSList();
        }
        }
}
