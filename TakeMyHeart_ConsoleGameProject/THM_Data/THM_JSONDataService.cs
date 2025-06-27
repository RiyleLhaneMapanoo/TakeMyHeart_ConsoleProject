using Common_Player;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace THM_Data
{
    internal class THM_JSONDataService : IThm_DataService
    {

        static string playersJsonPath = "Players_json.json";
        static string storyLinesJsonPath = "storylines_json.json";//chk
        static string choicesJsonPath = "choices_json.json"; //chck
        static string storyDialoguesJsonPath = "story_dialogues.json";//chk
        static string routesJsonPath = "routes_json.json";

        private string[] storyLines = new string[15];//chk
        private string[] choicesA = new string[15];//chk
        private string[] choicesB = new string[15];//chk
        private string[] storyDialogueA = new string[10];//chk
        private string[] storyDialogueB = new string[10];//chk
        private string[] routesD = new string[15]; 

        public player Player = new player();

        public GameSystem gs = new GameSystem();

       
       
   


        public string addPlayer(string name)
        {
            Player.name = name;
           
            return Player.name;
           
        }

        public int getlovePts()
        {
            return Player.lovePts;
        }

        public int setlovePts(int value)
        {
            Player.lovePts = value;
            
            return Player.lovePts;
        }
        public string getName()
        {
            return Player.name;
        }

         

        public string[] storyLineLibrary()
        {
            if (File.Exists(storyLinesJsonPath))
            {
                string jsonContent = File.ReadAllText(storyLinesJsonPath);
                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("storyLines", out JsonElement storyLinesElement))
                    {
                        var storyLinesList = JsonSerializer.Deserialize<List<string>>(storyLinesElement.GetRawText());
                        for (int i = 0; i < Math.Min(storyLinesList.Count, storyLines.Length); i++)
                        {
                            storyLines[i] = storyLinesList[i] ?? "";
                        }
                    }
                }
            }
            return storyLines;
        }

        public string[] choicesALibrary()
        {

            if (File.Exists(choicesJsonPath))
            {
                string jsonContent = File.ReadAllText(choicesJsonPath);

                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("choices", out JsonElement choicesElement))
                    {
                    
                        if (choicesElement.TryGetProperty("choiceA", out JsonElement choiceAArray))
                        {
                            int index = 0;
                            foreach (var item in choiceAArray.EnumerateArray())
                            {
                                if (index >= choicesA.Length) break;
                                choicesA[index++] = item.GetString();
                            }
                        }

                    }//
                }
            }

            return choicesA;
        }

        public string[] choicesBLibrary()
        {
            if (File.Exists(choicesJsonPath))
            {
                string jsonContent = File.ReadAllText(choicesJsonPath);

                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("choices", out JsonElement choicesElement))
                    {

                        if (choicesElement.TryGetProperty("choiceB", out JsonElement choiceBArray))
                        {
                            int index = 0;
                            foreach (var item in choiceBArray.EnumerateArray())
                            {
                                if (index >= choicesB.Length) break;
                                choicesB[index++] = item.GetString();
                            }
                        }
                    }//
                }
            }

            return choicesB;
        }

        public string[] StoryDialougeA()
        {
            if (File.Exists(storyDialoguesJsonPath))
            {
                string jsonContent = File.ReadAllText(storyDialoguesJsonPath);

                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("dialogues", out JsonElement dialougesElement))
                    {

                        if (dialougesElement.TryGetProperty("dialogueA", out JsonElement dialougeA_Array))
                        {
                            int index = 0;
                            foreach (var item in dialougeA_Array.EnumerateArray())
                            {
                                if (index >= storyDialogueA.Length) break;
                                storyDialogueA[index++] = item.GetString();
                            }
                        }


                    }
                }
            }
            return storyDialogueA;
        }

        public string[] StoryDialougeB()
        {

            if (File.Exists(storyDialoguesJsonPath))
            {
                string jsonContent = File.ReadAllText(storyDialoguesJsonPath);

                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("dialogues", out JsonElement dialougesElement))
                    {

                     
                        if (dialougesElement.TryGetProperty("dialogueB", out JsonElement dialougeB_Array))
                        {
                            int index = 0;
                            foreach (var item in dialougeB_Array.EnumerateArray())
                            {
                                if (index >= storyDialogueB.Length) break;
                                storyDialogueB[index++] = item.GetString();
                            }
                        }
                    }
                }
            }
            return storyDialogueB;
        }

        public string[] routesData()
        {
            if (File.Exists(routesJsonPath))
            {
                string jsonContent = File.ReadAllText(routesJsonPath);
                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("routes", out JsonElement routesElement))
                    {
                        int index = 0;
                        foreach (JsonElement routeItem in routesElement.EnumerateArray())
                        {
                            if (index >= routesD.Length) break;

                            if (routeItem.TryGetProperty("routeKind", out JsonElement routeKindElement))
                            {
                                routesD[index++] = routeKindElement.GetString() ?? "";
                            }
                        }
                    }
                }
            }
            return routesD;
        }

        public int setfinalLovePts(int finalLovepts)
        {
            Player.finalLovePts = finalLovepts;
           
         
           
            return Player.finalLovePts;
        }

        public int getfinalLovePts()
        {
            return Player.finalLovePts;
        }


        public void addHighScore(int highscoreNum, string playerName)
        {

            var playersList = getPlayerScoreList();

            playersList.Add((highscoreNum, playerName));

            var playersData = new
            {
                players = playersList.Select(player => new
                {
                    name = player.playerName,
                    lovepts = player.highscoreNum
                })
                /* format of the json file. 
                 * question 1: what is => 
                 * its a lambda expression
                 * basically a one liner loop/expression condition. its like using an if without using an if or like having a function/method without having a function/method
                 * “For each player in playersList, return a new object that contains name and lovepts.”
                 * question 2: what is .select and what does it do
                 *  It's used to transform each element of a collection into something else and then returns a new list of the transformed elements.
                 *  (which is weird cause its named "Select" and its suppose to select but instead transforms but whatever)
                 *  for the context above its like: “For each player tuple in playersList, create a new object with properties name and lovepts, and make a new list of those objects.”
                */

            };

            string json = JsonSerializer.Serialize(playersData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            });

            File.WriteAllText(playersJsonPath, json);
            gs.HighScoreList.Add((highscoreNum, playerName));
        }
        public List<(int highscoreNum, string playerName)> getPlayerScoreList()
        {
            List<(int highscoreNum, string playerName)> highScoreList = new List<(int, string)>();

            if (File.Exists(playersJsonPath) && new FileInfo(playersJsonPath).Length > 0)//for checking kung may laman b ung json or if nageexist ung file; pra matrigger/macall maayos ung list and ung no records message
            {
                string existingJson = File.ReadAllText(playersJsonPath);

                using (JsonDocument doc = JsonDocument.Parse(existingJson))
                {
                    if (doc.RootElement.TryGetProperty("players", out JsonElement playersArray))
                    {
                        foreach (var player in playersArray.EnumerateArray())
                        {
                            string name = player.GetProperty("name").GetString();
                            int lovepts = player.GetProperty("lovepts").GetInt32();

                            highScoreList.Add((lovepts, name));

                            /*question arose:
                             is this line necessary when i already have this gs.HighScoreList.Add((highscoreNum, playerName)); in the addHighscore method?
                            answer: 
                            
                             is absolutely necessary inside getPlayerScoreList() if you're using that method to read data from the file and return it.
                              Even if you have gs.HighScoreList.Add(...) elsewhere, that only affects your in-memory list — it doesn’t populate or return a 
                              list of scores from the file, which is what getPlayerScoreList() is designed to do.

                             //why update ung nsa player cs common kung meron na database? cause un ung gamit ko s majority ng classes ko so . bale panstore lng ung json ng data self.
                             */

                        }
                    }
                }
            }

            return highScoreList;
        }

        public void removeItemonHSList()
        {
            if (File.Exists(playersJsonPath))
            {
                string jsonContent = File.ReadAllText(playersJsonPath);
                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("players", out JsonElement playersElement))
                    {
                        var playersArray = playersElement.EnumerateArray().ToList();
                        if (playersArray.Count > 0)
                        {
                            playersArray.RemoveAt(playersArray.Count - 1); 
                            var updatedPlayersData = new { players = playersArray };
                            string updatedJson = JsonSerializer.Serialize(updatedPlayersData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
                            File.WriteAllText(playersJsonPath, updatedJson);
                        }
                    }
                }
            }
        }
    }
}