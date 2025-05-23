using Common_Player;
using THM_Data;

namespace TMH_BusinessDataLogic
{

    public class THMProcess
    {



        public THM_DataService dataLogic = new THM_DataService();

        public string pointAllocation(ref int mainLovePts, int ptsA, int ptsB, string choice)
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

        //keep the records or restart all over

        public int getlovePts()
        {

            return dataLogic.getLovePts();
        }

        public int setLovePts(int loveP)
        {

            return dataLogic.setLovePts(loveP);
        }

        public bool YesChoiceProcess(string restartChoice)
        {

            if (restartChoice == "a" || restartChoice == "A")
            {
                setLovePts(0);
                return true;
            }
            else if (restartChoice == "b" || restartChoice == "B")
            {
                setLovePts(0);
                return false;
            }

            return false;



        }

        //invalid choice



        public string getName()
        {
            return dataLogic.getName();

        }

        public void addP(string name)
        {
            dataLogic.addPlayer(name);

        }
        public string InvalidChoice()
        {
            return "I don't know if you're daring or just plain stupid. Try again please ^^";
        }



    }
}
