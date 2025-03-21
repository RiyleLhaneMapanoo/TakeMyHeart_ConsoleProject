using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace TakeMyHeart_ConsoleGameProject
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                string name;
                int lovePts = 0;
                string badEnd = "You go with him. He takes you to the local park near the forest. It was unnervingly empty. You look at him. He looks back at you with that handsome smile of his. huh. \r\nHad his eyes always been red? He walks towards you and your heart beats even faster. He touches your cheeks. \"You're so easy you know?\" He says before his hands slowly\r\ngoes down to your chest. His palms right above your heart. You can't hear anything anymore though. Only the fast beating of your heart and the overwhelming heat \r\nenveloping your whole being. He took a step back and you notice the thing he was holding. Hm. He really took your heart away huh.\r\n";
                string goodEnd = "You returned home. Exhausted. You still have that C# program project assignment that you have to do. Why did you choose this course? Did you do it because you liked it?\r\nOr did you just do it because your parents told you so and you have no idea what you want to do with your life so you just went along with whatever you think makes money\r\nthe most? You lay on your bed staring at the ceiling wondering what the future holds. You fail to notice red eyes staring at you from your window. \r\n";

                Console.WriteLine("♥ Take My Heart ♥ \n");
                Console.WriteLine("\n♥ Recommended to play in a wide console ♥ \n");
                Console.WriteLine("\nHello there! hmm...What's your name?");
                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.WriteLine($"\nI see! Welcome {name}. Goodluck ;) ");
                Choices("A.) Thank you", "B.) uh..");
              

                //2
                GameChoices(ref lovePts, 5, 10, "\nIt's a beautiful, sunny day, but unfortunately, you have classes. You get dressed and prepare yourself for the day. After a few minutes, you're ready! Stepping outside, you pause for a moment, wondering how you’d like to get to school today.", "\nIt's a beautiful, sunny day, but unfortunately, you have classes. You get dressed and prepare yourself for the day. After a few minutes, you're ready! Stepping outside, you pause for a moment, wondering how you’d like to get to school today.");

                //2.1
                Choices("A.) Walk to school", "B.) Ride a pedicab");
              

                GameChoicesVer2(ref lovePts, 5, 10, "\n While walking to school, you see a stranger. He's quite handsome..", "\nA.) \"Meh. not my type\"\nB.) \"He is pretty cute\"\n", "\nYou take a pedicab, and as it picks up speed, your eyes catch a fleeting glimpse of a handsome stranger. The moment is too brief to process, and before you know it, he’s gone. You shake it off and dismiss the thought.\r\n");
              

                //3
                Console.WriteLine("You're finally at school. You walk to your class and as you turned into a corner, you bump into someone!");
                Choices("A.) \"oh! sorry.\"", "B.) \"watch where you're going!\"");
               GameChoices(ref lovePts, 2, 10, "", "");

                //4
                Console.WriteLine("\nThe person you bumped into turns around. it's the handsome stranger from earlier! He locks eyes with you for a brief moment before a small smile tugs at his lips. \"I'm sorry, I didn’t mean to bump into you,\" he says, his voice smooth yet sincere.");
                Choices("A.)\"...it's ok. don't do it again next time i guess.\"", "B.) \"oh no! no! it's my fault anyways. I'm really sorry too.\"");
                GameChoices(ref lovePts, 10, 2, "", "");


                //5
                Console.WriteLine("\nHe looked at the class nameplate hanging above the door to the classroom you're both standing in. He turns to you once more. \"Is this your class?\" He politely says.");
                Choices("A.)\"ah, yes! are you in this class too?\"", "B.) \"what's it to you?\"");
                GameChoices(ref lovePts, 2, 10, "\n\"Yes, I'm in this class too\" He looks around ", "\n\"I'm in this class too you see\" He looks around");

                //6
                Console.WriteLine("\n\"I know that you don't know me yet but would it be possible to sit together? I'm new and I don't know anyone just yet. you seem nice\" He asks you, a hint of hope and hesitation in his voice. Although his eyes flickered with...something for a moment before it dissapeared completely. huh.");
               Choices("A.)\"Sure... I wouldn't mind,\" you replied, your cheeks heating up as you tucked a strand of hair behind your ear. You can't help it. There's just something in him that draws you in.\""
                    , "B.) \"...\" You stay silent for a while before replying. \"No. I don't sit with weird people\" You said decisively. He looks normal. But there's just something not right with him.\r\n\"");
               
                GameChoices(ref lovePts, 2, 10
                    , "\n\"Really? Thank you so much!\" He flashes you with the most handsome smile you have ever seen. Your heart skipped a beat. You two entered the classroom and you see the two remaining empty seat at the back. What a coincidence! must be fate right?\r\n"
                       , "\n\"What? I'm not weird\" He furrows his eyebrows as he looks at you, a hint of concern in his eyes—almost as if he's worried about the first impression he's making. You dismiss him and walked inside the classroom. You notice the two remaining empty seat at the back. You frown for a bit. You had no choice after all. \r\n");


                //7
                Console.WriteLine("\nYou took a seat, and he followed right after. Turning to you with an easygoing smile, he struck up a conversation. \"So! Since we're going to be seatmates for the rest of the semester, we might as well get to know each other, right? I haven't even introduced myself yet—sorry, that was quite rude of me.\" He flashed you an apologetic smile before his expression shifted into something more mischievous. \"My name is Ren.\"");
        
                Choices($"\nA.) \"It's nice to meet you Ren! My name is {name}\" You smiled back. Your cheeks flushed and heart beating fast. It skipped a beat again. if this continues you might\r\nactually die of a heart attack.", "B.) \"Did I ask?\"");
                GameChoices(ref lovePts, 2, 10, "", "");


                //8
                Console.WriteLine("\nClass started and before you knew it, it's the end of the day. As you're packing up your stuff, Ren turned towards you and stares for a moment. You notice him staring.\r\n");
               Choices("A.)\"W-what is it? Is there something on my face?\" You ask with embarrasment and lifted your hand to check your face. You felt your heart being squeezed. With emotion? or with something else? You didn't know.", "B.) \"What are you staring at? \"You narrowed your eyes and stared back at him. You shortly looked away after, feeling embarrassed.  Even though he was a little odd, you couldn’t deny it—his looks were still something you couldn’t just brush off.\r\n");
                GameChoices(ref lovePts, 2, 10, "", "");


                Console.WriteLine("\nHe gives you a breathtaking smile, his kind eyes locked onto yours. His ears turn visibly pink as he hesitates for a moment before asking. \"I was wondering…would you like to spend some time with me?\" \r\n");
                Choices("A.)\"...\" You stay silent. Your face red. Your heart beating at record speed. Is this normal?. Your heart eased just for a moment.\r"
                    , "\"B.) Are you crazy? Why the hell would I spend time with you? \" You rudely say to him as you wear your bag and walked out the door. \r\n");
                Endings(ref lovePts, badEnd, goodEnd, name);



                YesOrNo("\nI see. That's a shame.", "\nI'll take that as a No. Bye! ^^");


            }//whole program while loop

        }
        //Note: used ref in mainLovePts to reduce method GameChoices declaration directly to the main method's int ecquivalent 'lovePts'

    
     public static string InvalidChoice()
        {
            return "I don't know if you're daring or just plain stupid. Try again please ^^";
        }
     public static void GameChoices(ref int mainLovePts, int ptsA, int ptsB, string dialougeA, string dialougeB)
        {
            string choice;
            while (true)
            {
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine(dialougeA);
                        mainLovePts += ptsA;
                        break;
                    case "b":
                        Console.WriteLine(dialougeB);
                        mainLovePts += ptsB;
                        break;
                    default:
                        Console.WriteLine(InvalidChoice());
                        continue;
                }
                break;
            }
          
        }

     public static void GameChoicesVer2(ref int mainLovePts, int ptsA, int ptsB, string dialougeA,string additionalA, string dialougeB)
        {
            string choice;
            while (true)
            {
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine(dialougeA);
                        Console.WriteLine(additionalA);
                        mainLovePts += ptsA;

                        GameChoices(ref mainLovePts, 10, 2, "", "");

                        break;
                    case "b":
                        Console.WriteLine(dialougeB);
                        mainLovePts += ptsB;
                        break;
                    default:
                        Console.WriteLine(InvalidChoice());
                        continue;
                }
                break;
            }
         
        }

    public static void Endings(ref int mainLovePts,string badEnding,string goodEnding,string player)
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

   public static void BadEndLoop(string badEndNotif, string badEndResist,string badEnding)
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

   public static void Choices(string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
}
        
  public static void YesOrNo(string no, string otherAnswer)
        {
            while (true)
            {
                Console.Write("Choice: ");
                string restartChoice = Console.ReadLine().ToLower();
                if (restartChoice == "y")
                {
                    Console.WriteLine("\nGreat! Better luck this time ♥\n. But first, would you like to keep your records or have a frest start? ^^ ");
                    Choices("A.) Keep Records", "B.) Have a fresh start.");
                    Console.Write("Choice: ");
                    restartChoice = Console.ReadLine().ToLower();
                    if (restartChoice == "b")
                    {
                        Console.Clear();
                        break;
                    }
                    break;
                }
                else if (restartChoice == "n")
                {
                    Console.WriteLine(no);
                    return;
                }
                else
                {
                    Console.WriteLine(otherAnswer);
                    return;
                }
            }
        }



    }
}