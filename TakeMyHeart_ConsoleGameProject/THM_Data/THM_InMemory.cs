using Common_Player;
using System.Xml.Linq;

namespace THM_Data;


    public class THM_InMemory : IThm_DataService
{
    //for player
    public player Player = new player();
    //for game system

    public GameSystem gs = new GameSystem();

    //int highScoreSlot = 0;
    // redundant/unused
    //public int lovePts=0;
    public string[] storyLineLibrary()
    {
        string[] storyLine = new string[15];
        storyLine[0] = "\nIt's a beautiful, sunny day, but unfortunately, you have classes. You get dressed and prepare yourself for the day. After a few minutes, you're ready! Stepping outside, you pause for a moment, wondering how you’d like to get to school today.";
        storyLine[1] = "\n While walking to school, you see a stranger. He's quite handsome..";
        storyLine[2] = "\nYou take a pedicab, and as it picks up speed, your eyes catch a fleeting glimpse of a handsome stranger. The moment is too brief to process, and before you know it, he’s gone. You shake it off and dismiss the thought.\n";
        storyLine[3] = "You're finally at school. You walk to your class and as you turned into a corner, you bump into someone!";
        storyLine[4] = "\nThe person you bumped into turns around. it's the handsome stranger from earlier! He locks eyes with you for a brief moment before a small smile tugs at his lips. \"I'm sorry, I didn’t mean to bump into you,\" he says, his voice smooth yet sincere.";
        storyLine[5] = "\nHe looked at the class nameplate hanging above the door to the classroom you're both standing in. He turns to you once more. \"Is this your class?\" He politely says.";
        storyLine[6] = "\n\"I know that you don't know me yet but would it be possible to sit together? I'm new and I don't know anyone just yet. you seem nice\" He asks you, a hint of hope and hesitation in his voice. Although his eyes flickered with...something for a moment before it dissapeared completely. huh.";
        storyLine[7] = "\nYou took a seat, and he followed right after. Turning to you with an easygoing smile, he struck up a conversation. \"So! Since we're going to be seatmates for the rest of the semester, we might as well get to know each other, right? I haven't even introduced myself yet—sorry, that was quite rude of me.\" He flashed you an apologetic smile before his expression shifted into something more mischievous. \"My name is Ren.\"";
        storyLine[8] = "\nClass started and before you knew it, it's the end of the day. As you're packing up your stuff, Ren turned towards you and stares for a moment. You notice him staring.\r\n";
        storyLine[9] = "\nHe gives you a breathtaking smile, his kind eyes locked onto yours. His ears turn visibly pink as he hesitates for a moment before asking. \"I was wondering…would you like to spend some time with me?\" \n";

        //Bad End
        storyLine[10] = "You go with him. He takes you to the local park near the forest. It was unnervingly empty. You look at him. He looks back at you with that handsome smile of his. huh. \r\nHad his eyes always been red? He walks towards you and your heart beats even faster. He touches your cheeks. \"You're so easy you know?\" He says before his hands slowly\r\ngoes down to your chest. His palms right above your heart. You can't hear anything anymore though. Only the fast beating of your heart and the overwhelming heat \r\nenveloping your whole being. He took a step back and you notice the thing he was holding. Hm. He really took your heart away huh.\r\n";

        //GoodEnd
        storyLine[11] = "You returned home. Exhausted. You still have that C# program project assignment that you have to do. Why did you choose this course? Did you do it because you liked it?\r\nOr did you just do it because your parents told you so and you have no idea what you want to do with your life so you just went along with whatever you think makes money\r\nthe most? You lay on your bed staring at the ceiling wondering what the future holds. You fail to notice red eyes staring at you from your window. \r\n";

        storyLine[12] = "...";


        return storyLine;

    }

    public  string[] choicesALibrary()
    {
        string[] A_choices = new string[15];

        //system beginning
        A_choices[0] = "A.) Thank you";

        //Main storyLine
        A_choices[1] = "A.) walk To school";
        A_choices[2] = "A.) \"meh. not my type\"";
        A_choices[3] = "A.) \"oh! sorry.\"";
        A_choices[4] = "A.)\"...it's ok. don't do it again next time i guess.\"";
        A_choices[5] = "A.)\"ah, yes! are you in tHis class too?\"";
        A_choices[6] = "A.)\"surE... i wouldn't mind,\" you replied, your cheeks Heating up as you tucked a strand of hAir behind your ear. You caN't help it. There's just somethinG in him that draws you in.";
        A_choices[7] = "A.) \"it's nice to meet you Ren! My name is placeholder\" You smiled back. your chEeks flusheD and heart beating fast. it skipped a beat again. if this continues you might\r\nactually die of a heart attack.";
        A_choices[8] = "A.)\"w-what is it? is there something on my face?\" you ask with eMbarrasment and lifted your hand to check your fAce. you felt your heart beiNg squeezed. with emotion? or with something else? you didn't know.";
        A_choices[9] = "A.)\"...\" you stay silent. your face red. your heart beating at record speed. is this normal?. your heart eased just for a moment.";
       // A_choices[10] = "";
        

        return A_choices;
    }

    public  string[] choicesBLibrary()
    {
        string[] B_choices = new string[15];
        //System beginning
        B_choices[0] = "B.) uh..";

        //Main story line
        B_choices[1] = "B.) ride a pedicab";
        B_choices[2] = "B.) \"he is pretty cute\"\n";
        B_choices[3] = "B.) \"waTcH wherE you're going!\"";
        B_choices[4] = "B.) \"oh no! no! it's my fault anyways. I'm really sorry too.\"";
        B_choices[5] = "B.) \"what's it to you?\"";
        B_choices[6] = "B.) \"...\" You stay siLent for a while beFore replying. \"No. I dOn't sit with weird peOple\" You said decisiveLy. He looks normal. But there's just something not right with him.";
        B_choices[7] = "B.) \"Did I ask?\"";
        B_choices[8] = "B.) \"What are you staring at? \"You narrowed your eyes and stared back at him. You shortly looked away after, feeling embarrassed.  Even though he was a little odd, you couldn’t deny it—his looks were still something you couldn’t just brush off.\n";
        B_choices[9] = "B.) Are you crazy? Why the hell would I spend time with you? \" You rudely say to him as you wear your bag and walked out the door. \n";
       // B_choices[10] = "";


        return B_choices;
    }

    public  string[] StoryDialougeA()
    {
        string[] storyd_A = new string[10];

        storyd_A[0] = "\n\"Yes, I'm in this class too\" He looks around ";
        storyd_A[1] = "\n\"Really? Thank you so much!\" He flashes you with the most handsome smile you have ever seen. Your heart skipped a beat. You two entered the classroom and you see the two remaining empty seat at the back. What a coincidence! must be fate right?\n";


        return storyd_A;
    }

    public  string[] StoryDialougeB()
    {
        string[] storyd_B = new string[10];

        storyd_B[0] = "\n\"I'm in this class too you see\" He looks around";
        storyd_B[1] = "\n\"What? I'm not weird\" He furrows his eyebrows as he looks at you, a hint of concern in his eyes—almost as if he's worried about the first impression he's making. You dismiss him and walked inside the classroom. You notice the two remaining empty seat at the back. You frown for a bit. You had no choice after all. \n";


        return storyd_B;
    }

   public string[] routesData()
    {
        string[] route = new string[3];

        string[] A_choices = choicesALibrary();
        string[] B_choices = choicesBLibrary();

        route[0] = "The Fool's Route:\n" +
        $"1. {B_choices[0]} +10\n" +
        $"2. {A_choices[1]} +10\n" +
        "If A:\n" +
        $"A.2) {A_choices[2]} +10\n" +
        $"3. {B_choices[3]} +10\n" +
        $"4. {A_choices[4]} +10\n" +
        $"5. {B_choices[5]} +10\n" +
        $"6. {B_choices[6]} +10\n" +
        $"7. {B_choices[7]} +10\n" +
        $"8. {B_choices[8]} +10\n";

        route[1] = "The Hanged Man's Route:\n" +
        $"1. {A_choices[0]} +5\n" +
        $"2. {B_choices[1]} +5\n" +
        "If A:\n" +
        $"A.2) {B_choices[2]} +2\n" +
        $"3. {A_choices[3]} +2\n" +
        $"4. {B_choices[4]} +2\n" +
        $"5. {A_choices[5]} +2\n" +
        $"6. {A_choices[6]} +2\n" +
        $"7. {A_choices[7]} +2\n" +
        $"8. {A_choices[8]} +2\n";

        return route;
    }
    public string addPlayer(string name)
    {
        Player.name = name;
        return Player.name;
       // Player.lovePts = 0;
    }


    public string getName() {
        return Player.name;
    }

    public int getlovePts()
    {
        return Player.lovePts;
    }

    public int  setlovePts(int value)
    {
       return   Player.lovePts = value;
    }

    public int setfinalLovePts(int finalLovepts) {

        return Player.finalLovePts = finalLovepts;

    }
    public int getfinalLovePts()
    {

        return Player.finalLovePts;
    }

    //adjusted june 21
    public void addHighScore( int highscoreNum, string playerName)
    {
        gs.HighScoreList.Add(( highscoreNum, playerName));
    }
    //adjusted june 21
    public List<(int highscoreNum, string playerName)> getPlayerScoreList()
    {
        return gs.HighScoreList;
    }

    public void removeItemonHSList()
    {

        getPlayerScoreList().RemoveAt(getPlayerScoreList().Count - 1);
    }

}



