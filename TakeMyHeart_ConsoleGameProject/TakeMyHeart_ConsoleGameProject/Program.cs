using System.Diagnostics.Metrics;
using System.Xml.Linq;
using TMH_BusinessDataLogic;

namespace TakeMyHeart_ConsoleGameProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            while (true)
            {
                
                Console.WriteLine("♥ Take My Heart ♥ \n");
                Console.WriteLine("\n♥ Recommended to play in a wide console ♥ \n");
                Console.WriteLine("\nHello there! hmm...What's your name?");
                Console.Write("Name: ");
                THMProcess.name = Console.ReadLine();

                Console.WriteLine($"\nI see! Welcome {THMProcess.name}. Goodluck ;) ");
                 Choices("A.) Thank you", "B.) uh..");


                //2
                GameChoices(5, 10, "\nIt's a beautiful, sunny day, but unfortunately, you have classes. You get dressed and prepare yourself for the day. After a few minutes, you're ready! Stepping outside, you pause for a moment, wondering how you’d like to get to school today.", "\nIt's a beautiful, sunny day, but unfortunately, you have classes. You get dressed and prepare yourself for the day. After a few minutes, you're ready! Stepping outside, you pause for a moment, wondering how you’d like to get to school today.", InvalidChoice());

                //2.1
         Choices("A.) Walk to school", "B.) Ride a pedicab");


                GameChoicesVer2( 5, 10, "\n While walking to school, you see a stranger. He's quite handsome..", "\nA.) \"Meh. not my type\"\nB.) \"He is pretty cute\"\n", "\nYou take a pedicab, and as it picks up speed, your eyes catch a fleeting glimpse of a handsome stranger. The moment is too brief to process, and before you know it, he’s gone. You shake it off and dismiss the thought.\r\n", InvalidChoice());
              

                //3
                Console.WriteLine("You're finally at school. You walk to your class and as you turned into a corner, you bump into someone!");
              Choices("A.) \"oh! sorry.\"", "B.) \"watch where you're going!\"");
                GameChoices( 2, 10, "", "", InvalidChoice());

                //4
                Console.WriteLine("\nThe person you bumped into turns around. it's the handsome stranger from earlier! He locks eyes with you for a brief moment before a small smile tugs at his lips. \"I'm sorry, I didn’t mean to bump into you,\" he says, his voice smooth yet sincere.");
           Choices("A.)\"...it's ok. don't do it again next time i guess.\"", "B.) \"oh no! no! it's my fault anyways. I'm really sorry too.\"");
               GameChoices(10, 2, "", "", InvalidChoice());


                //5
                Console.WriteLine("\nHe looked at the class nameplate hanging above the door to the classroom you're both standing in. He turns to you once more. \"Is this your class?\" He politely says.");
               Choices("A.)\"ah, yes! are you in this class too?\"", "B.) \"what's it to you?\"");
                GameChoices( 2, 10, "\n\"Yes, I'm in this class too\" He looks around ", "\n\"I'm in this class too you see\" He looks around", InvalidChoice());

                //6
                Console.WriteLine("\n\"I know that you don't know me yet but would it be possible to sit together? I'm new and I don't know anyone just yet. you seem nice\" He asks you, a hint of hope and hesitation in his voice. Although his eyes flickered with...something for a moment before it dissapeared completely. huh.");
             Choices("A.)\"Sure... I wouldn't mind,\" you replied, your cheeks heating up as you tucked a strand of hair behind your ear. You can't help it. There's just something in him that draws you in.\""
                    , "B.) \"...\" You stay silent for a while before replying. \"No. I don't sit with weird people\" You said decisively. He looks normal. But there's just something not right with him.\r\n\"");

                GameChoices(2, 10
                    , "\n\"Really? Thank you so much!\" He flashes you with the most handsome smile you have ever seen. Your heart skipped a beat. You two entered the classroom and you see the two remaining empty seat at the back. What a coincidence! must be fate right?\r\n"
                       , "\n\"What? I'm not weird\" He furrows his eyebrows as he looks at you, a hint of concern in his eyes—almost as if he's worried about the first impression he's making. You dismiss him and walked inside the classroom. You notice the two remaining empty seat at the back. You frown for a bit. You had no choice after all. \r\n", InvalidChoice());


                //7
                Console.WriteLine("\nYou took a seat, and he followed right after. Turning to you with an easygoing smile, he struck up a conversation. \"So! Since we're going to be seatmates for the rest of the semester, we might as well get to know each other, right? I haven't even introduced myself yet—sorry, that was quite rude of me.\" He flashed you an apologetic smile before his expression shifted into something more mischievous. \"My name is Ren.\"");
        
            Choices($"\nA.) \"It's nice to meet you Ren! My name is {THMProcess.name}\" You smiled back. Your cheeks flushed and heart beating fast. It skipped a beat again. if this continues you might\r\nactually die of a heart attack.", "B.) \"Did I ask?\"");
                GameChoices(2, 10, "", "", InvalidChoice());


                //8
                Console.WriteLine("\nClass started and before you knew it, it's the end of the day. As you're packing up your stuff, Ren turned towards you and stares for a moment. You notice him staring.\r\n");
              Choices("A.)\"W-what is it? Is there something on my face?\" You ask with embarrasment and lifted your hand to check your face. You felt your heart being squeezed. With emotion? or with something else? You didn't know.", "B.) \"What are you staring at? \"You narrowed your eyes and stared back at him. You shortly looked away after, feeling embarrassed.  Even though he was a little odd, you couldn’t deny it—his looks were still something you couldn’t just brush off.\r\n");
               GameChoices( 2, 10, "", "", InvalidChoice());


                Console.WriteLine("\nHe gives you a breathtaking smile, his kind eyes locked onto yours. His ears turn visibly pink as he hesitates for a moment before asking. \"I was wondering…would you like to spend some time with me?\" \r\n");
              Choices("A.)\"...\" You stay silent. Your face red. Your heart beating at record speed. Is this normal?. Your heart eased just for a moment.\r"
                    , "\"B.) Are you crazy? Why the hell would I spend time with you? \" You rudely say to him as you wear your bag and walked out the door. \r\n");
                Endings(ref THMProcess.lovePts, THMProcess.badEnd, THMProcess.goodEnd, THMProcess.name);



                YesOrNo("\nI see. That's a shame.", "\nI'll take that as a No. Bye! ^^");

                
            }//whole program while loop

        }
        //Note: used ref in mainLovePts to reduce method GameChoices declaration directly to the main method's int ecquivalent 'lovePts'


    
     public static string InvalidChoice()
        {
            return "I don't know if you're daring or just plain stupid. Try again please ^^";
        }

        public static void GameChoices(int ptsA, int ptsB, string dialougeA, string dialougeB, string invChoice)
        {
            string choice;
            while (true)
            {
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();

                string pointsProcess = THMProcess.pointAllocation(ref THMProcess.lovePts, ptsA, ptsB, choice);

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


           public static void GameChoicesVer2(int ptsA, int ptsB, string dialougeA, string additionalA, string dialougeB, string invChoice)
        {
            while (true)
            {
                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToLower();

                string pointsProcess = THMProcess.pointAllocation(ref THMProcess.lovePts, ptsA, ptsB, choice);

                if (pointsProcess == "A" || pointsProcess == "a")
                {
                    Console.WriteLine(dialougeA);
                    Console.WriteLine(additionalA);


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
                    Console.WriteLine("\nGreat! Better luck this time ♥\n. But first, would you like to keep your records or have a frest start? ^^ ");
                    Choices("A.) Keep Records", "B.) Have a fresh start.");
                    Console.Write("Choice: ");
                    restartChoice = Console.ReadLine().ToLower();
                    if (restartChoice == "b" || restartChoice == "B")
                    {
                        Console.Clear();
                        break;
                    } else if (restartChoice == "a" || restartChoice == "A") {

                        THMProcess.lovePts = 0;
                        

                    }
                        break;

                }
                else if (restartChoice == "n" || restartChoice == "N")
                {
                    Console.WriteLine(no);
                    Environment.Exit(0);
                    //alternative fr return; used return but it keeps looping back regardless
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

        public static void Endings(ref int mainLovePts, string badEnding, string goodEnding, string player)
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
                            Console.WriteLine("I don't know if you're daring or just plain stupid. Try again please ^^");
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
        //create a dialouge library; with string array method maybe?

        //update prog as of bl/dl and ui:
        //fixed invalid choices point accumulation bug; fixed continued accumulation of points upon restarting; added OR in if else choices
    }
}