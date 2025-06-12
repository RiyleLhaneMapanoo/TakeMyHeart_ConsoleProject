using Common_Player;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using TMH_BusinessDataLogic;

namespace TakeMyHeart_ConsoleGameProject
{
    internal class Program
    {
        static THMProcess busPro = new THMProcess();
        public static int setlvPTs ;
        public static int finalLovePts;

        //public static int highScoreSlot; //= busPro.highscoreslotIncrementor();
        public static int getlvPTs = busPro.getlovePts();
        public static int getfinalLovePts = busPro.getfinalLovePts();

        public static string[] storyLine = busPro.getstoryLineLibrary();
        public static string[] A_Choices = busPro.getchoicesALibrary();
        public static string[] B_Choices = busPro.getchoicesBLibrary();
        public static string[] storyLine_A = busPro.getStoryDialougeA();
        public static string[] storyLine_B = busPro.getStoryDialougeB();
        public static string Pname;

        public static string invalidMess = busPro.InvalidChoice();
        public static string[] mainmenuUI = { "[1] Start ", "[2] High Score Records ", "[3] Guide ", "[4] Exit" };
        public static string[] ingameUI = { "[1] Main Menu ", "[2] Exit" };

       

        static void Main(string[] args)
        {

            

            MainCodeLoop();


        }
        public static void MainCodeLoop() {

            Console.WriteLine("♥ Take My Heart ♥ \n");
            Console.WriteLine("\n♥ Recommended to play in a wide console ♥ \n");
            MainUIChoices();
            double playerChoice = playerChoiceNumber();

            while (playerChoice != 4)
            {

                switch (playerChoice)
                {
                    case 1:
                        StartMainGame();
                        Console.Clear();
                        break;
                    case 2:
                        
                        displayHighscoreList();
                        break;
                    case 3:
                        Console.WriteLine("♥ Guide Test ♥");
                        break;
                    case 4:
                        //for safety measures nrin; in case exit debugs occurs 
                       Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Was that a typo or something? If not then choose correctly >:[ ");
                        break;

                }

              
                MainUIChoices();
                playerChoice = playerChoiceNumber();
            }




        }
        public static void StartMainGame()
        {

            Console.WriteLine("\n"+"Choose wisely—you only get one chance ;)" +"\n");
            Console.WriteLine("Tips: Those are some oddly place capital letters...hm" + "\n");


            busPro.setLovePts(0);
            setlvPTs = getlvPTs;

            while (true)
            {
                //string player;
                Console.WriteLine("\nHello there! hmm...What's your name?");
                Console.Write("Name: ");
                Pname = Console.ReadLine();
                busPro.addP(Pname);
                Pname = busPro.getName();

                Console.WriteLine($"\nI see! Welcome {Pname}. Goodluck ;) ");
                Choices(A_Choices[0], B_Choices[0]);
                InGameChoicesUI();

                int id = 1;
                while (true)
                {

                    switch (id)
                    {

                        case 1:
                            id = GameChoices(5, 10, storyLine[0], storyLine[0], invalidMess, 3, 3);
                            Choices(A_Choices[1], B_Choices[1]);
                          
                            Console.WriteLine("Love Points: " + setlvPTs);
                          
                            break;
                        case 2:
                            Console.WriteLine(storyLine[1]);
                            Choices(A_Choices[2], B_Choices[2]);
                            InGameChoicesUI();
                            id = GameChoices(10, 2, "", "", invalidMess, 5, 5);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            
                            break;
                        case 3:
                            //  Console.WriteLine(storyLine[2]);
                            InGameChoicesUI();
                            id = GameChoices(5, 10, "", "", invalidMess, 2, 4);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 4:
                            Console.WriteLine(storyLine[2]);
                            goto case 5;
                        case 5:
                            //u arrivce at school
                            Console.WriteLine(storyLine[3]);
                            Choices(A_Choices[3], B_Choices[3]);
                            InGameChoicesUI();
                            id = GameChoices(2, 10, "", "", invalidMess, 6, 6);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 6:
                            Console.WriteLine(storyLine[4]);
                            Choices(A_Choices[4], B_Choices[4]);
                            InGameChoicesUI();
                            id = GameChoices(10, 2, "", "", invalidMess, 7, 7);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 7:
                            //5
                            Console.WriteLine(storyLine[5]);
                            Choices(A_Choices[5], B_Choices[5]);
                            InGameChoicesUI();
                            id = GameChoices(2, 10, storyLine_A[0], storyLine_B[0], invalidMess, 8, 8);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 8:
                            //6
                            Console.WriteLine(storyLine[6]);
                            Choices(A_Choices[6], B_Choices[6]);
                            InGameChoicesUI();
                            id = GameChoices(2, 10, storyLine_A[1], storyLine_B[1], invalidMess, 9, 9);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 9:
                            //7
                            Console.WriteLine(storyLine[7]);
                            Choices(A_Choices[7], B_Choices[7]);
                            InGameChoicesUI();
                            id = GameChoices(2, 10, "", "", invalidMess, 10, 10);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 10:

                            //8
                            Console.WriteLine(storyLine[8]);
                            Choices(A_Choices[8], B_Choices[8]);
                            InGameChoicesUI();
                            id = GameChoices(2, 10, "", "", invalidMess, 11, 11);
                            Console.WriteLine("Love Points: " + setlvPTs);
                            break;
                        case 11:
                            Console.WriteLine(storyLine[9]);
                            Choices(A_Choices[9], B_Choices[9]);
                            // setting lvpts here to final lvpts
                            finalLovePts = getfinalLovePts;
                            finalLovePts = busPro.setLovePts(setlvPTs);

                           
                            Console.WriteLine("Love Points: " + setlvPTs);
                            Console.WriteLine("Love Points: " + finalLovePts);

                            //add item on highscore list 
                            busPro.addHighScore(0, finalLovePts, Pname);


                         //   var testList = busPro.getHighScoreList();
                         //   Console.WriteLine($"[TEST] Highscore count: {testList.Count}");
                            id = Endings(storyLine[10], storyLine[11], Pname, invalidMess);
                            
                            goto case 12;
                        case 12:
                            break;
                        default:
                            break;


                    }

                    if (id == 12) break;


                }break;
            
            }

        }
        public static void MainUIChoices() {

            foreach (var menuUI in mainmenuUI)
            {
                Console.WriteLine(menuUI);
            }
        }

        public static void InGameChoicesUI() {

            Console.WriteLine("");
            foreach (var menuUI in ingameUI) {
                Console.Write(menuUI);
                
            }
            Console.WriteLine(""+"\n");
        }
        public static double playerChoiceNumber() {

            Console.Write("\nChoice: ");
            double playerChoice = Convert.ToDouble(Console.ReadLine().Trim());
            return playerChoice;
        }

        public static string playerChoiceLetter() {
            Console.Write("Choice: ");
           string choice = Console.ReadLine().Trim().ToLower();
            return choice;

        }

       

        public static int GameChoices(int ptsA, int ptsB, string dialougeA, string dialougeB, string invChoice, int nextRouteA, int nextRouteB)
        {


            string choice;

                while (true)
                {
               

                    choice = playerChoiceLetter();



                    string pointsProcess = busPro.pointAllocation(ref setlvPTs, ptsA, ptsB, choice);

                    if (pointsProcess == "a")
                    {
                        Console.WriteLine(dialougeA);
                        return nextRouteA;

                    }
                    else if (pointsProcess == "b")
                    {
                        Console.WriteLine(dialougeB);
                        Console.WriteLine(dialougeB);
                        return nextRouteB;

                    }
                    else if (int.TryParse(choice, out int number) && number >= 1 && number <= 2) //this tries to convert the string choice into an integer and if its successful it converts it to thats 'number'.
                {
                    Console.WriteLine("This is 1-4");

                    continue;  
                  }
                else
                    {
                        Console.WriteLine(invChoice);
                        continue;

                    }
                }
                }
            
        




        public static void YesOrNo(string no, string otherAnswer)
        {
            while (true)
            {
               
                string restartChoice = playerChoiceLetter();

                if (restartChoice == "y" )
                {
                   //resatarts the current run and removes the name and love points recorded in the list should the player wanna start over
                    busPro.removeItemonHSList();
                    
                    Console.Clear();
                    StartMainGame();
                   
                    break;

                }
                else if (restartChoice == "n" )
                {

                    Console.WriteLine(no+ "\n");
                    Console.Clear();
                   // MainCodeLoop();
                    return;

                }

                else
                {
                    Console.WriteLine(otherAnswer);
                    Environment.Exit(0);
                }
                break;
            }
        }


        public static void Choices(string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static int Endings( string badEnding, string goodEnding, string player, string invChoice)
        {
            while (true)
            {
                
                int mainLovePts = setlvPTs;
                string choice = playerChoiceLetter();

                if (mainLovePts < 60)
                {
                    //Bad End


                    switch (choice)
                    {
                        case "a":
                            Console.WriteLine(badEnding);
                            Console.WriteLine("You've Reached a Bad End :( . Would you like to start over? \nY/N");
                            break;
                        case "b":
                            Console.WriteLine("\nHaha. You're so funny. Would you like to spend time with him?");
                            Console.WriteLine("\nA.) Yes \nB.) Absolutely ");

                            BadEndLoop("You've Reached a Bad End :( . Would you like to start over? \nY/N", $"\nTrying to escape are we? Too late {player} :) ♥ ", badEnding);

                            break;
                        default:
                            Console.WriteLine(invChoice);
                            continue;
                    }

                }
                else if (mainLovePts >= 60)
                {
                    //Good End (?)
                    Console.WriteLine("\n" + goodEnding);
                    Console.WriteLine("You've Reached a Good End(?) :) ♥ . Would you like to start over? \nY/N");
                }
              
                Console.WriteLine("\nFinal Love Points: " + mainLovePts);
          
                YesOrNo("\nI see. That's a shame. ", "\nI'll take that as a bye ^^");
                return 12;

            }
        }

        static void BadEndLoop(string badEndNotif, string badEndResist, string badEnding)
        {
            while (true)
            {
                string choice = playerChoiceLetter();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("\n" + badEnding);
                        Console.WriteLine(badEndNotif);
                        break;
                    case "b":
                        Console.WriteLine("\n" + badEnding);
                        Console.WriteLine(badEndNotif);
                        break;
                    default:
                        Console.WriteLine(badEndResist);
                        continue;
                }
                break;
            }
        }

        public static void displayHighscoreList() {
            var highscoreList = busPro.SortHighScoreList(); 

            if (highscoreList.Count == 0)
            {
                Console.WriteLine("\n"+"No high scores yet!"+"\n" );
                return;
            }

            foreach (var entry in highscoreList)
            {
                 
                Console.WriteLine($"Slot {entry.highScoreSlot}: {entry.playerName} - {entry.highscoreNum} points");
            }

        }

        //List of stuff to implement:
        //remove exclusive method GameChoicesVer2 for choice 2; inefficient
        //implement a more flexible game choice method; use number for each route choices as identification maybe; switch case maybe?
        //find a way to separate ending logic ui switch loops   
        //create seperate string method for endings maybe?
        //create a dialouge library; with string array method maybe? CHECK 

        //update prog as of bl/dl and ui:
        //fixed invalid choices point accumulation bug; fixed continued accumulation of points upon restarting; added OR in if else choices

        // add search feature, a guide search for the choices for bad and good end
        //add main menu 
        // see maams menu list for reference
        // fix yes or no
        //if any other than y or n were typed it will exit


        // may update
        // how my current code works:
        //program.cs /ui layer
        // just inputting data and displaying data
        //thmprocess/ business
        // processing data inputed and outputted
        // thm_info/data layer
        //stores datas
        //has to manage the syate of the data
        //common (stores main data)
        // common --> datalayer(get and set methods) --> business (also get and set methods that references the get and set methods in data) ---> UI
    }
}