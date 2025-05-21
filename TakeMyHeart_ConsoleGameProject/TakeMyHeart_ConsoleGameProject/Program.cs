using Common_Player;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using TMH_BusinessDataLogic;

namespace TakeMyHeart_ConsoleGameProject
{
    internal class Program
    {
        static THMProcess busPro = new THMProcess();
        public static int lvPTs = busPro.setLovePts(lvPTs);

        static void Main(string[] args)
        {

            string[] storyLine = busPro.getstoryLineLibrary();
            string[] A_Choices = busPro.getchoicesALibrary();
            string[] B_Choices = busPro.getchoicesBLibrary();
            string[] storyLine_A = busPro.getStoryDialougeA();
            string[] storyLine_B = busPro.getStoryDialougeB();

            string invalidMess = busPro.InvalidChoice();


            Console.WriteLine("♥ Take My Heart ♥ \n");
            Console.WriteLine("\n♥ Recommended to play in a wide console ♥ \n");


            while (true)
            {
                string player;
                Console.WriteLine("\nHello there! hmm...What's your name?");
                Console.Write("Name: ");
                player = Console.ReadLine();
                busPro.addP(player);
                player = busPro.getName();



                Console.WriteLine($"\nI see! Welcome {player}. Goodluck ;) ");
                Choices(A_Choices[0], B_Choices[0]);

                int id = 1;
                while (true)
                {

                    switch (id)
                    {

                        case 1:
                            id = GameChoices(5, 10, storyLine[0], storyLine[0], invalidMess, 3, 3);
                            Choices(A_Choices[1], B_Choices[1]);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 2:
                            Console.WriteLine(storyLine[1]);
                            Choices(A_Choices[2], B_Choices[2]);
                            id = GameChoices(10, 2, "", "", invalidMess, 5, 5);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 3:
                            //  Console.WriteLine(storyLine[2]);
                            id = GameChoices(5, 10, "", "", invalidMess, 2, 4);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 4:
                            Console.WriteLine(storyLine[2]);
                            goto case 5;
                        case 5:
                            //u arrivce at school
                            Console.WriteLine(storyLine[3]);
                            Choices(A_Choices[3], B_Choices[3]);
                            id = GameChoices(2, 10, "", "", invalidMess, 6, 6);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 6:
                            Console.WriteLine(storyLine[4]);
                            Choices(A_Choices[4], B_Choices[4]);
                            id = GameChoices(10, 2, "", "", invalidMess, 7, 7);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 7:
                            //5
                            Console.WriteLine(storyLine[5]);
                            Choices(A_Choices[5], B_Choices[5]);
                            id = GameChoices(2, 10, storyLine_A[0], storyLine_B[0], invalidMess, 8, 8);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 8:
                            //6
                            Console.WriteLine(storyLine[6]);
                            Choices(A_Choices[6], B_Choices[6]);
                            id = GameChoices(2, 10, storyLine_A[1], storyLine_B[1], invalidMess, 9, 9);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 9:
                            //7
                            Console.WriteLine(storyLine[7]);
                            Choices(A_Choices[7], B_Choices[7]);
                            id = GameChoices(2, 10, "", "", invalidMess, 10, 10);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 10:

                            //8
                            Console.WriteLine(storyLine[8]);
                            Choices(A_Choices[8], B_Choices[8]);
                            id = GameChoices(2, 10, "", "", invalidMess, 11, 11);
                            Console.WriteLine("Love Points: " + lvPTs);
                            break;
                        case 11:
                            Console.WriteLine(storyLine[9]);
                            Choices(A_Choices[9], B_Choices[9]);
                            Console.WriteLine("Love Points: " + lvPTs);
                            id = Endings( storyLine[10], storyLine[11], player , invalidMess);
                            Console.WriteLine("Love Points: " + lvPTs);
                            goto case 12;
                        case 12:
                            break;
                        default:
                            break;


                    }

                    if (id == 12) break;


                }
            }
        }



        public static int GameChoices(int ptsA, int ptsB, string dialougeA, string dialougeB, string invChoice, int nextRouteA, int nextRouteB)
        {
            string choice;
            while (true)
            {
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                string pointsProcess = busPro.pointAllocation(ref lvPTs, ptsA, ptsB, choice);

                if (pointsProcess == "a" || pointsProcess == "A")
                {
                    Console.WriteLine(dialougeA);
                    return nextRouteA;

                }
                else if (pointsProcess == "b" || pointsProcess == "B")
                {
                    Console.WriteLine(dialougeB);
                    return nextRouteB;

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
                Console.Write("Choice: ");
                string restartChoice = Console.ReadLine().ToLower();
                if (restartChoice == "y" || restartChoice == "Y")
                {
                    Console.WriteLine("\nGreat! Better luck this time ♥\nBut first, would you like to keep your records or have a frest start? ^^ ");
                    Choices("A.) Keep Records", "B.) Have a fresh start.");
                    Console.Write("Choice: ");
                    restartChoice = Console.ReadLine().ToLower();


                    busPro.YesChoiceProcess(restartChoice);


                    break;

                }
                else if (restartChoice == "n" || restartChoice == "N")
                {
                    Console.WriteLine(no);
                    Environment.Exit(0);

                }

                else
                {
                    Console.WriteLine(otherAnswer);
                    Environment.Exit(0);
                }
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
                Console.Write("Choice: ");
                int mainLovePts = lvPTs;
                string choice = Console.ReadLine().ToLower();

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
                lvPTs = 0;
                YesOrNo("\nI see. That's a shame.", "\nI'll take that as a No. Bye! ^^");
                return 12;

            }
        }

        static void BadEndLoop(string badEndNotif, string badEndResist, string badEnding)
        {
            while (true)
            {
                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToLower();
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
    }
}