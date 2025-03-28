

namespace TMH_BusinessDataLogic
{

    public class THMProcess
    {
        public static string name;
        public static int lovePts = 0;
        public static string badEnd = "You go with him. He takes you to the local park near the forest. It was unnervingly empty. You look at him. He looks back at you with that handsome smile of his. huh. \r\nHad his eyes always been red? He walks towards you and your heart beats even faster. He touches your cheeks. \"You're so easy you know?\" He says before his hands slowly\r\ngoes down to your chest. His palms right above your heart. You can't hear anything anymore though. Only the fast beating of your heart and the overwhelming heat \r\nenveloping your whole being. He took a step back and you notice the thing he was holding. Hm. He really took your heart away huh.\r\n";
        public static string goodEnd = "You returned home. Exhausted. You still have that C# program project assignment that you have to do. Why did you choose this course? Did you do it because you liked it?\r\nOr did you just do it because your parents told you so and you have no idea what you want to do with your life so you just went along with whatever you think makes money\r\nthe most? You lay on your bed staring at the ceiling wondering what the future holds. You fail to notice red eyes staring at you from your window. \r\n";


        public static string pointAllocation(ref int mainLovePts, int ptsA, int ptsB, string choice)
        {

            if (choice == "a" || choice == "A")
            {
                mainLovePts += ptsA;
                return "A";
            }
            else if (choice == "b" || choice == "B")
            {
                mainLovePts += ptsB;
                return "B";
            }
            else
            {
                return "Invalid"; 
            }
        }



    }
}
