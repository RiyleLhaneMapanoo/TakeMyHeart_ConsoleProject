using Common_Player;
using System;

namespace Common_Player
{
    public class player
    {
        public int lovePts { get; set; }
        public string name { get; set; }
        public int finalLovePts { get; set; } 
    }

    public class GameSystem
    {
        //tuple
        public List<(int highscoreNum, string playerName)> HighScoreList { get; set; } = new List<( int, string)>();
       
    }


}

// tuple list, apparently a list that groups multiple values together without creating a class.
//but will convert to class to accomodate json and txzt
// ---> public List<(int SaveId, int SaveLovePoints, List<int> StoryProgress)> Saves { get; set; } = new List<(int, int, List<int>)>();


// i needed it like this because i'm using a constructor method for the save function. 
//Constructors are special methods used to initialize objects when they are created.
// why? pra di n manually iset isa isa. automatically na daw naiinitialize ung objects
//public class SaveFile //--> class
//{
//    public int SaveId { get; set; }
//    public int CurrentSaveLovePoints { get; set; }
//    public List<int> StoryProgress { get; set; } //*--this and the stuff up

//    public SaveFile(int id, int lovePoints, List<int> progress) //--> constructor of class, initiallizes the stuff up --*
//    {
//        SaveId = id;
//        CurrentSaveLovePoints = lovePoints;
//        StoryProgress = progress;
//    }

// i could technically use player instead but its not part of the save system. 

//opted for a class-based structure because it makes my save system easier to expand, manage, and serialize later
// what is serialized? process of converting an object into a format that can be saved or transmitted 
// deserialized - taking a stored format (like JSON, XML, or binary) and converting it back into an object
// object? Object = Actual Instance ex: player p1 = new player(); -- p1 is object

//Removed this at the end
// public Save(int id, int lovePoints, List<int> progress)
//{
//    SaveId = id;
//    CurrentSaveLovePoints = lovePoints;
//    StoryProgress = progress;
//}

