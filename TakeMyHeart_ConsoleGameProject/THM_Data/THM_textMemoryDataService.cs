//using Common_Player;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace THM_Data
//{
//    internal class THM_textMemoryDataService : IThm_DataService
//    {
//        string playerPath = "Players.txt";
//        string storyLineFilePath = "storyLines.txt";
//        string StoryDialougeAPath = "StoryDialouges.txt";
//        string choicesALibraryPath= "choicesLibrary.txt";

//        string[] storyLine = new string[15];
//        string[] choicesA = new string[15];
//        string[] choicesB = new string[15]; 
//        string[] storyDialougeA = new string[2];
//        string[] storyDialougeB = new string[2];
//        public player Player = new player();

//         public THM_textMemoryDataService()
//        {
//            GetStoryFromFile();
//        }
//        private void GetStoryFromFile()
//        {
//            var storyLines = File.ReadAllLines(storyLineFilePath);
//             var TxtstoryDialouge = File.ReadAllLines(StoryDialougeAPath);
//            var Txtchoices = File.ReadAllLines(choicesALibraryPath);
          


        
//            for (int i = 0; i < storyLines.Length; i++)
//            {
//                if (string.IsNullOrWhiteSpace(storyLines[i]))
//                    continue;
//                storyLine[i] = storyLines[i];

             
//            }

//            int x = 0;
//            for (int i = 0; i < Txtchoices.Length; i++)
//            {
//                if (string.IsNullOrWhiteSpace(Txtchoices[i])) continue;

//                // Add this check before accessing TxtstoryDialouge
//                if (i >= TxtstoryDialouge.Length || string.IsNullOrWhiteSpace(TxtstoryDialouge[i]))
//                    continue;

//                var parts = Txtchoices[i].Split('|');
//                var partsDia = TxtstoryDialouge[i].Split('|');

//                // Rest of your code...
          
//                choicesA[i] = parts[0];
//                choicesB[i] = parts[1];
//                storyDialougeA[x] = partsDia[0];
//                storyDialougeB[x] = partsDia[1];
//                if (x > 2)
//                {

//                }
//                else { x++; } // increment x only if the line is not empty

//            }

         
//        }
      

//        public void addPlayer(string name)
//        {
//            Player.name = name;
//            var newLine = $"{Player.name} | { getlovePts()}";

//            File.AppendAllText(playerPath, newLine);
//        }
//        public int getlovePts()
//        {
//            return Player.lovePts;
//        }
      

//        public string getName()
//        {
//            return Player.name;
//        }

//        public int setlovePts(int value)
//        {
//           Player.lovePts = value;
//            var newLine = $"{Player.name} | {Player.lovePts}";
//            File.WriteAllText(playerPath, newLine);
          
//            return Player.lovePts;
//        }

//        public void clearPlayers() {
//            var newLine = $" ";
//            File.WriteAllText(playerPath, newLine);
//        }
//        public string[] storyLineLibrary()
//        {
//            return storyLine;
//        }

//        public string[] StoryDialougeA()
//        {
//            return storyDialougeA;
//        }

//        public string[] StoryDialougeB()
//        {
//           return storyDialougeB;
//        }

//        public string[] choicesALibrary()
//        {
//           return choicesA;
//        }

//        public string[] choicesBLibrary()
//        {
//           return choicesB;
//        }

      
//    }
//}
