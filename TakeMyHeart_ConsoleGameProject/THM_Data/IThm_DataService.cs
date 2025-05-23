using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    internal interface IThm_DataService
    {

        public void addPlayer(String name);
        public int getLovePts();
        public int setLovePts(int value);

        public string getName();

        public string[] storyLineLibrary();

        public string[] choicesALibrary();
        public string[] choicesBLibrary();

        public string[] StoryDialougeA();
        public string[] StoryDialougeB();


    }
}
