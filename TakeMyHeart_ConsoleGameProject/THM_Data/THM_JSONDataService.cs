using Common_Player;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace THM_Data
{
    internal class THM_JSONDataService : IThm_DataService
    {

        private readonly string playersJsonPath = "Players_json.json";
        private readonly string storyLinesJsonPath = "storylines_json.json";
        private readonly string choicesJsonPath = "choices_json.json";
        private readonly string storyDialoguesJsonPath = "story_dialogues.json";


        private string[] storyLines = new string[15];
        private string[] choicesA = new string[15];
        private string[] choicesB = new string[15];
        private string[] storyDialogueA = new string[10];
        private string[] storyDialogueB = new string[10];

        public player Player = new player();



        public THM_JSONDataService()
        {
            InitializeJsonFiles();
            LoadDataFromJson();
         
            ClearPlayerFile();
        }

        private void InitializeJsonFiles()
        {

            if (!File.Exists(playersJsonPath))
            {
                var initialPlayersData = new { players = new List<object>() };
                string json = JsonSerializer.Serialize(initialPlayersData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                File.WriteAllText(playersJsonPath, json);
            }


            if (!File.Exists(storyLinesJsonPath))
            {
                var initialStoryData = new { storyLines = new List<string>() };
                string json = JsonSerializer.Serialize(initialStoryData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                File.WriteAllText(storyLinesJsonPath, json);
            }

            if (!File.Exists(choicesJsonPath))
            {
                var initialChoicesData = new { choices = new List<object>() };
                string json = JsonSerializer.Serialize(initialChoicesData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                File.WriteAllText(choicesJsonPath, json);
            }

            if (!File.Exists(storyDialoguesJsonPath))
            {
                var initialDialoguesData = new { dialogues = new List<object>() };
                string json = JsonSerializer.Serialize(initialDialoguesData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                File.WriteAllText(storyDialoguesJsonPath, json);
            }
        }

        private void LoadDataFromJson()
        {
                LoadStoryLines();
                LoadChoices();
                LoadStoryDialogues();
                LoadPlayer();
          
           
        }

      
        private void LoadStoryLines()
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
        }

        private void LoadChoices()
        {
            if (File.Exists(choicesJsonPath))
            {
                string jsonContent = File.ReadAllText(choicesJsonPath);
                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("choices", out JsonElement choicesElement))
                    {
                        var choicesArray = choicesElement.EnumerateArray();
                        int index = 0;

                        foreach (var choice in choicesArray)
                        {
                            if (index >= choicesA.Length) break;

                            if (choice.TryGetProperty("choiceA", out JsonElement choiceAElement))
                                choicesA[index] = choiceAElement.GetString();

                            if (choice.TryGetProperty("choiceB", out JsonElement choiceBElement))
                                choicesB[index] = choiceBElement.GetString();

                            index++;
                        }
                    }
                }
            }
        }

        private void LoadStoryDialogues()
        {
            if (File.Exists(storyDialoguesJsonPath))
            {
                string jsonContent = File.ReadAllText(storyDialoguesJsonPath);
                using (JsonDocument document = JsonDocument.Parse(jsonContent))
                {
                    if (document.RootElement.TryGetProperty("dialogues", out JsonElement dialoguesElement))
                    {
                        var dialoguesArray = dialoguesElement.EnumerateArray();
                        int index = 0;

                        foreach (var dialogue in dialoguesArray)
                        {
                            if (index >= storyDialogueA.Length) break;

                            if (dialogue.TryGetProperty("dialogueA", out JsonElement dialogueAElement))
                                storyDialogueA[index] = dialogueAElement.GetString();

                            if (dialogue.TryGetProperty("dialogueB", out JsonElement dialogueBElement))
                                storyDialogueB[index] = dialogueBElement.GetString();

                            index++;
                        }
                    }
                }
            }
        }

        private void LoadPlayer()
        {
            // Try to load existing player data
            if (File.Exists(playersJsonPath))
            {
              
                    string jsonContent = File.ReadAllText(playersJsonPath);
                    using (JsonDocument document = JsonDocument.Parse(jsonContent))
                    {
                        if (document.RootElement.TryGetProperty("players", out JsonElement playersElement))
                        {
                            var playersArray = playersElement.EnumerateArray();
                            var playersList = playersArray.ToList();

                            if (playersList.Count > 0)
                            {
                                var lastPlayer = playersList.Last();
                                if (lastPlayer.TryGetProperty("name", out JsonElement nameElement))
                                    Player.name = nameElement.GetString();
                                if (lastPlayer.TryGetProperty("lovePts", out JsonElement lovePtsElement))
                                    Player.lovePts = lovePtsElement.GetInt32();
                                return;
                            }
                        }
                    }
            
              
            }

        
            Player.name = "";
            Player.lovePts = 0;
        }

  
        private void SavePlayerToJson()
        {
          
                var playerData = new
                {
                    name = Player.name,
                    lovePts = Player.lovePts
                };

                var playersData = new { players = new[] { playerData } };
                string json = JsonSerializer.Serialize(playersData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                });
                File.WriteAllText(playersJsonPath, json);
        
        }

        private void ClearPlayerFile()
        {
            try
            {
                var emptyPlayersData = new { players = new List<object>() };
                string json = JsonSerializer.Serialize(emptyPlayersData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                File.WriteAllText(playersJsonPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing player file: {ex.Message}");
            }
        }

     
   
        public void addPlayer(string name)
        {
            Player.name = name;
            Player.lovePts = 0;
            SavePlayerToJson(); 
        }

        public int getLovePts()
        {
            return Player.lovePts;
        }

        public string getName()
        {
            return Player.name;
        }

        public int setLovePts(int value)
        {
            Player.lovePts = value;
            SavePlayerToJson(); 
            return Player.lovePts;
        }

        public string[] storyLineLibrary()
        {
            return storyLines;
        }

        public string[] choicesALibrary()
        {
            return choicesA;
        }

        public string[] choicesBLibrary()
        {
            return choicesB;
        }

        public string[] StoryDialougeA()
        {
            return storyDialogueA;
        }

        public string[] StoryDialougeB()
        {
            return storyDialogueB;
        }
    }
}