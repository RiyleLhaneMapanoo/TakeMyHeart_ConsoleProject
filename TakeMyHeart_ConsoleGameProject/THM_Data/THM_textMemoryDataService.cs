using Common_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    internal class THM_textMemoryDataService : IThm_DataService
    {
        string playerPath = "Players.txt";
        string storyLineFilePath = "storyLines.txt";
        string StoryDialougePath = "StoryDialouges.txt";
        string choicesLibraryPath = "choicesLibrary.txt";
        string routePath = "routes.txt";

        string[] storyLine = new string[15]; //chk
        string[] choicesA = new string[15]; //chk
        string[] choicesB = new string[15]; //chk
        string[] storyDialougeA = new string[15];//chk
        string[] storyDialougeB = new string[15];//chk
        string[] routesD = new string[15];//chk

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
        public string[] storyLineLibrary()//chk
        {
            string storyFileText = File.ReadAllText(storyLineFilePath);


            string[] rawStoryParts = storyFileText.Split('|');

            for (int i = 0; i < rawStoryParts.Length && i < storyLine.Length; i++)
            {
                storyLine[i] = rawStoryParts[i].Trim();
            }



            return storyLine;
        }
        public string[] choicesALibrary()//chkl
        {
            var Txtchoices = File.ReadAllLines(choicesLibraryPath);
            int indexA = 0;

            foreach (string rawLine in Txtchoices)
            {
                string line = rawLine.Trim();

                if ( indexA < choicesA.Length)
                {
                    choicesA[indexA++] = line.Trim();
                }
                
            }


            return choicesA;
        }
        public string[] choicesBLibrary()//chk
        {
            var Txtchoices = File.ReadAllLines(choicesLibraryPath);
            int indexB = 0;
            bool Bchecker = false;

            foreach (string rawLine in Txtchoices)
            {
                string line = rawLine.Trim();

                if (line == "| | |")
                {
                    Bchecker = true;
                    continue;
                }
                if (Bchecker && indexB < choicesB.Length)
                {
                    choicesB[indexB++] = line.Trim();
                }
            }


            return choicesB;
        }
        public string[] StoryDialougeA()//chk
        {
            var TxtstoryDialouge = File.ReadAllLines(StoryDialougePath);
            int dialogueIndexA = 0;
          
            foreach (string rawLine in TxtstoryDialouge)
            {
                string line = rawLine.Trim();
               
                if ( dialogueIndexA < storyDialougeA.Length)
                {
                    storyDialougeA[dialogueIndexA++] = line.Trim();
                }
               
            }

            return storyDialougeA;
        }
        public string[] StoryDialougeB()//chk
        {
            var TxtstoryDialouge = File.ReadAllLines(StoryDialougePath);

            int dialogueIndexB = 0;
            bool Bchecker = false;

            foreach (string rawLine in TxtstoryDialouge)
            {
                string line = rawLine.Trim();

                if (line == "| | |")
                {
                    Bchecker = true;
                    continue;
                }

                if (Bchecker && dialogueIndexB < storyDialougeB.Length)
                    {
                        storyDialougeB[dialogueIndexB++] = line.Trim();
                    }


                }
                
            

            return storyDialougeB;
        }
        public string[] routesData()//CHK
        {


            var txtRoute = File.ReadAllLines(routePath);

            if (File.Exists(routePath))
            {
                int routeIndex = 0;
                List<string> currentRoute = new List<string>();

                foreach (string line in txtRoute)
                {
                    if (line.Trim() == "| | |")
                    {
                        if (routeIndex < routesD.Length)
                        {
                            routesD[routeIndex++] = string.Join("\n", currentRoute);
                            currentRoute.Clear();
                        }
                    }
                    else
                    {
                        currentRoute.Add(line);
                    }
                }


                if (currentRoute.Count > 0 && routeIndex < routesD.Length)
                {
                    routesD[routeIndex++] = string.Join("\n", currentRoute);
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
       
        public void addHighScore( int highscoreNum, string playerName)
        {

            gs.HighScoreList.Add((highscoreNum, playerName));


            var lines = new List<string>();
            foreach (var (score, name) in gs.HighScoreList)
            {
                lines.Add($"{name} | {score}");
            }

            File.WriteAllLines(playerPath, lines);
        }
        public List<( int highscoreNum, string playerName)> getPlayerScoreList()
        {
            List<(int, string)> highScores = new List<(int, string)>();

            if (File.Exists(playerPath))
            {
                var lines = File.ReadAllLines(playerPath);

                foreach (string rawLine in lines)
                {
                    var parts = rawLine.Split('|');
                    highScores.Add((int.Parse(parts[1].Trim()), parts[0].Trim()));
                  
                }
            }

            return highScores;
        }
        public void removeItemonHSList()
        {
            if (File.Exists(playerPath))
            {
                var allLines = getPlayerScoreList();
        
                allLines.RemoveAt(allLines.Count - 1);
                gs.HighScoreList.Clear();

                foreach (var (score, name) in allLines)
                {
                    addHighScore(score, name);
                }


            }
        }


    }
}