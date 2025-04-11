using Common_Player;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using TMH_BusinessDataLogic;

namespace TakeMyHeart_ConsoleGameProject
{
    internal class Program
    {
        static THMProcess busPro = new THMProcess();
        static void Main(string[] args)
        {
            
            string[] storyLine = busPro.getstoryLineLibrary();
            string[] A_Choices = busPro.getchoicesALibrary();
            string[] B_Choices = busPro.getchoicesBLibrary();
            string[] storyLine_A = busPro.getStoryDialougeA();
            string[] storyLine_B = busPro.getStoryDialougeB();

            string invalidMess = busPro.InvalidChoice();
            int lvPT = busPro.getlovePts();

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


                Console.WriteLine(busPro.getName());

                Console.WriteLine($"\nI see! Welcome {player}. Goodluck ;) ");
                Choices(A_Choices[0], B_Choices[0]);


                //2
                GameChoices(5, 10, storyLine[0], storyLine[0], invalidMess);
                Console.WriteLine("\nFinal Love Points: " + busPro.getlovePts());
                //2.1
                Choices(A_Choices[1], B_Choices[1]);
                    
                GameChoicesVer2( 5, 10, storyLine[1], A_Choices[2], B_Choices[2], storyLine[2], invalidMess);


                //3
                Console.WriteLine(storyLine[3]);
                Choices(A_Choices[3], B_Choices[3]);
                GameChoices( 2, 10, "", "", invalidMess);

                //4
                Console.WriteLine(storyLine[4]);
                Choices(A_Choices[4], B_Choices[4]);
               GameChoices(10, 2, "", "", invalidMess);


                //5
                Console.WriteLine(storyLine[5]);
                Choices(A_Choices[5], B_Choices[5]);
                GameChoices( 2, 10, storyLine_A[0], storyLine_B[0], invalidMess);

                //6
                Console.WriteLine(storyLine[6]);
                Choices(A_Choices[6], B_Choices[6]);

                GameChoices(2, 10, storyLine_A[1], storyLine_B[1], invalidMess);


                //7
                Console.WriteLine(storyLine[7]);
        
                Choices(A_Choices[7], B_Choices[7]);
                GameChoices(2, 10, "", "", invalidMess);


                //8
                Console.WriteLine(storyLine[8]);
                Choices(A_Choices[8], B_Choices[8]);
               GameChoices( 2, 10, "", "", invalidMess);


                Console.WriteLine(storyLine[9]);
                Choices(A_Choices[9], B_Choices[9]);

              
                Endings(ref lvPT, storyLine[10], storyLine[11], player, invalidMess);



                YesOrNo("\nI see. That's a shame.", "\nI'll take that as a No. Bye! ^^");

                
            }//whole program while loop

        }
        //Note: used ref in mainLovePts to reduce method GameChoices declaration directly to the main method's int ecquivalent 'lovePts'


    
     
        public static void GameChoices(int ptsA, int ptsB, string dialougeA, string dialougeB, string invChoice)
        {
            int lvPT = busPro.getlovePts();
            string choice;
            while (true)
            {
               
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                string pointsProcess = busPro.pointAllocation (ref lvPT, ptsA, ptsB, choice);

                if (pointsProcess == "a" || pointsProcess == "A")
                {
                    Console.WriteLine(dialougeA);
                    break;
                }
                else if (pointsProcess == "b" || pointsProcess == "B")
                {
                    Console.WriteLine(dialougeB);
                    break;
                }
                else
                {
                    Console.WriteLine(invChoice);
                    continue;


                    
                }

            }
        }


           public static void GameChoicesVer2(int ptsA, int ptsB, string dialougeA, string additionalA,string additionalB, string dialougeB, string invChoice)
        {
            int lvPT = busPro.getlovePts();
            while (true)
            {
                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToLower();

                string pointsProcess = busPro.pointAllocation(ref lvPT, ptsA, ptsB, choice);

                if (pointsProcess == "A" || pointsProcess == "a")
                {
                    Console.WriteLine(dialougeA);
                    Console.WriteLine(additionalA);
                    Console.WriteLine(additionalB);


                    GameChoices(10, 2, "", "", invChoice);
                    break;
                }
                else if (pointsProcess == "B" || pointsProcess == "b")
                {
                    Console.WriteLine(dialougeB);
                    break;
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

                    busPro.YesChoiceProcess(restartChoice) ;


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

        public static void Endings(ref int mainLovePts, string badEnding, string goodEnding, string player, string invChoice)
        {
            while (true)
            {
                Console.Write("Choice: ");
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
                break;
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
    }
}