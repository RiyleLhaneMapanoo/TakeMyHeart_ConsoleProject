using Common_Player;
using System;
using System.Drawing;
using THM_Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TMH_BusinessDataLogic
{

    public class THMProcess
    {

            

        public THM_DataService dataLogic = new THM_DataService();

    
        //get story stuff
        public string[] getstoryLineLibrary()
        {

            return dataLogic.storyLineLibrary();

        }
        public string[] getchoicesALibrary()
        {


            return dataLogic.choicesALibrary();
        }

        public string[] getchoicesBLibrary()
        {


            return dataLogic.choicesBLibrary();
        }

        public string[] getStoryDialougeA()
        {

            return dataLogic.StoryDialougeA();
        }
        public string[] getStoryDialougeB()
        {

            return dataLogic.StoryDialougeB();
        }

        public string[] getroutesData()
        {
            return dataLogic.routesData();
        }

   
        //player stuff
        public int getlovePts()
        {
            return dataLogic.getLovePts();
        }

        public int setLovePts(int loveP)
        {
            return dataLogic.setLovePts(loveP);
        }

        public string getName()
        {
            return dataLogic.getName();

        }

        public string addP(string name)
        {
            return dataLogic.addPlayer(name);

        }
        public string InvalidChoice()
        {
            return "I don't know if you're daring or just plain stupid. Try again please ^^";
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
     
        public List<( int highscoreNum, string playerName)> getPlayerScoreList()
        {
            return dataLogic.getPlayerScoreList();
        }


        public void removeItemonHSList()
        {
            dataLogic.removeItemonHSList();
        }
        public string pointAllocation(ref int mainLovePts, int ptsA, int ptsB, string choice)
        {



            if (choice == PlayerChoice.A.ToString().ToLower())
            {
                mainLovePts += ptsA;
                return "a";
            }
            else if (choice == PlayerChoice.B.ToString().ToLower())
            {
                mainLovePts += ptsB;
                return "b";
            }
            else
            {
                return "Invalid";
            }
        }
      
        public List<(int highscoreNum, string playerName)> SortHighScoreList()
        {

          
            var highScoreList = getPlayerScoreList();

           
            highScoreList.Sort((x,y)=> 
            {
                
                int scoreComparison = y.highscoreNum.CompareTo(x.highscoreNum);

                /*
                 ^^^^^ is descending order.

                  notes for compare to:
                How CompareTo() works:
                The.CompareTo() method returns:
                A negative number if the left - hand side is less than the right-hand side.
                0 if they are equal.
                A positive number if the left - hand side is greater than the right-hand side.
                
                thus its like saying: “Put higher scores first, because when y is greater than x, we want y to come before x in the list.”

                 */

           
               
                if (scoreComparison == 0)
                {
                    return x.playerName.CompareTo(y.playerName);
                }

                return scoreComparison;
            });

           
            if (highScoreList.Count > 10)
            {
                highScoreList = highScoreList.Take(10).ToList();
            }
         
            for (int i = 0; i < highScoreList.Count; i++)
            {
                highScoreList[i] = (highScoreList[i].highscoreNum, highScoreList[i].playerName);
                //how does this update the highscore slot without using the highScoreSlot parameter? apparently the "i + 1" stands for it and the highScoreList[i].highscoreNum, highScoreList[i].playerName
                //Why It Doesn’t Need highScoreSlot Parameter? its because the tuple list's first value is being rewritten like this nlng: (oldSlot, score, name) → (newSlot, sameScore, sameName)
                //Can’t we just change the highScoreSlot value in the tuple (e.g., by accessing the parameter or field directly) instead of rebuilding the entire tuple? No, because tuples in C# are immutable, meaning their individual elements can’t be changed directly once the tuple is created.
                //Solution: its easier to rewrite them all wholely while keeping the other elements the same and just changing the slot
            }



            return highScoreList;
        }

        






        }
    }
