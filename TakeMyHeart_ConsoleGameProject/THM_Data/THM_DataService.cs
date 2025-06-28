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

            //  dataLogic = new THM_textMemoryDataService();
            // dataLogic = new THM_InMemory();
            // dataLogic = new THM_JSONDataService();
            dataLogic = new THM_DatabaseService();
        }


        public string addPlayer(String name) {
           return dataLogic.addPlayer(name);
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
        public string[] routesData()
        {
            return dataLogic.routesData();
        }

        public int setfinalLovePts(int finalLovepts)
        {
            return dataLogic.setfinalLovePts(finalLovepts);
        }
        public int getfinalLovePts()
        {
            return dataLogic.getfinalLovePts();
        }
        public void addHighScore( int highscoreNum, string playerName)
        {
            dataLogic.addHighScore( highscoreNum, playerName);
        }
        public List<(int highscoreNum, string playerName)> getPlayerScoreList()
        {
            return dataLogic.getPlayerScoreList();
        }

        public void removeItemonHSList()
        {
            dataLogic.removeItemonHSList();
        }
        }
}
