using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    public class THM_DatabaseService : IThm_DataService
    {

       public THM_DatabaseService()
        {


        }
        public string addPlayer(String name)
        {
            // Implementation for adding a player
            return name;
        }
        public int getlovePts()
        {
            // Implementation for getting love points
            return 0;
        }
        public int setlovePts(int value)
        {
            // Implementation for setting love points
            return value;
        }

        public string getName()
        {
            // Implementation for getting player name
            return "PlayerName";
        }

        public string[] storyLineLibrary()
        {
            // Implementation for getting story line library
            return new string[] { "StoryLine1", "StoryLine2" };
        }

        public string[] choicesALibrary()
        {
            // Implementation for getting choices A library
            return new string[] { "ChoiceA1", "ChoiceA2" };
        }
        public string[] choicesBLibrary()
        {
            // Implementation for getting choices B library
            return new string[] { "ChoiceB1", "ChoiceB2" };
        }

        public string[] StoryDialougeA()
        {
            // Implementation for getting story dialogue A
            return new string[] { "DialogueA1", "DialogueA2" };
        }
        public string[] StoryDialougeB()
        {
            // Implementation for getting story dialogue B
            return new string[] { "DialogueB1", "DialogueB2" };
        }

        public string[] routesData()
        {
            // Implementation for getting routes data
            return new string[] { "Route1", "Route2" };
        }
        public int setfinalLovePts(int finalLovepts)
        {
            // Implementation for setting final love points
            return finalLovepts;
        }

        public int getfinalLovePts()
        {
            // Implementation for getting final love points
            return 0;
        }

        public void addHighScore(int highscoreNum, string playerName)
        {
            // Implementation for adding a high score
        }

        public List<(int highscoreNum, string playerName)> getPlayerScoreList()
        {
            // Implementation for getting player score list
            return new List<(int highscoreNum, string playerName)>
            {
                (100, "Player1"),
                (200, "Player2")
            };
        }

        public void removeItemonHSList()
        {
            // Implementation for removing an item from the high score list
        }


    }
}
