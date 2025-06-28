using Common_Player;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THM_Data
{
    public class THM_DatabaseService : IThm_DataService
    {

        string connectionString = "Data Source = DESKTOP-NAC05LQ\\SQLEXPRESS; initial Catalog = tmhdb;  Integrated Security = True; TrustServerCertificate = True;";
        static SqlConnection sqlConnection;

        private string[] storyLines = new string[15];//chk
        private string[] choicesA = new string[15];//chk
        private string[] choicesB = new string[15];//chk
        private string[] storyDialogueA = new string[10];//chk
        private string[] storyDialogueB = new string[10];//chk
        private string[] routesD = new string[15];

        public player Player = new player();

        public GameSystem gs = new GameSystem();



        public THM_DatabaseService()
        {
            sqlConnection = new SqlConnection(connectionString);

        }

        //get and set player info methods
        public string addPlayer(String name)
        {
            Player.name = name;

            return Player.name;

            //sqlConnection.Open();
            //var insertStatement = "INSERT INTO playerTable(playerName) VALUES (@name)";
            //SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            //insertCommand.Parameters.AddWithValue("@name",name);



            //insertCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //return name;
        }
        public string getName()
        {
            return Player.name;
        }
        public int getlovePts()
        { 
            return Player.lovePts;
        }
        public int setlovePts(int value)
        {
            Player.lovePts = value;

            return Player.lovePts;
        }
        public int setfinalLovePts(int finalLovepts)
        {
            Player.finalLovePts = finalLovepts;



            return Player.finalLovePts;
          
        }
        public int getfinalLovePts()
        {
            return Player.finalLovePts;
        }
        public void addHighScore(int highscoreNum, string playerName)
        {
            sqlConnection.Open();
            var insertStatement = "INSERT INTO playerTable (playerName, playerHighScore) VALUES (@name,@hs)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", playerName );
            insertCommand.Parameters.AddWithValue("@hs", highscoreNum);


            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
           
        }
        public List<(int highscoreNum, string playerName)> getPlayerScoreList()
        {
            List<(int highscoreNum, string playerName)> highScoreList = new List<(int, string)>();
            var selectStatement = "Select playerName, playerHighScore FROM playerTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            SqlDataReader sqlRead = selectCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                string playerName = sqlRead["playerName"].ToString();
                int playerHighScore = Convert.ToInt32(sqlRead["playerHighScore"]);
                highScoreList.Add((playerHighScore, playerName));
            }

            sqlConnection.Close();
            return highScoreList;
        }
        public void removeItemonHSList()
        {
            var deleteStatement = "DELETE FROM playerTable WHERE id = (SELECT MAX(id) FROM playerTable)";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }




        //story methods
        public string[] storyLineLibrary()
        {
            var selectStatement = "Select storyLines  FROM storyLineTable";
               sqlConnection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                storyLines[i] = sqlRead["storyLines"].ToString();
                i++;

            }
            sqlConnection.Close();
             return storyLines;
            
        }//chk

        public string[] choicesALibrary()
        {
            var selectStatement = "Select choicesLinesA  FROM choicesLineTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                choicesA[i] = sqlRead["choicesLinesA"].ToString();
                i++;

            }
            sqlConnection.Close();
            return choicesA;
        }//chk
        public string[] choicesBLibrary()
        {
            var selectStatement = "Select choicesLinesB  FROM choicesLineTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                choicesB[i] = sqlRead["choicesLinesB"].ToString();
                i++;

            }
            sqlConnection.Close();
            return choicesB;
        }//chk

        public string[] StoryDialougeA()//chk
        {
            var selectStatement = "Select dialougeLineA  FROM dialougesLineTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                storyDialogueA[i] = sqlRead["dialougeLineA"].ToString();
                i++;

            }
            sqlConnection.Close();
            return storyDialogueA;
        }
        public string[] StoryDialougeB()
        {

            var selectStatement = "Select dialougeLineB  FROM dialougesLineTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                storyDialogueB[i] = sqlRead["dialougeLineB"].ToString();
                i++;

            }
            sqlConnection.Close();
            return storyDialogueB;
        }//chk

        public string[] routesData()
        {
            var selectStatement = "Select routeKind  FROM routeLineTable";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                string rawData = sqlRead["routeKind"].ToString();
                routesD[i] = rawData.Replace("\\n", "\n");
                i++;

            }
            sqlConnection.Close();
            return routesD;
        }


        

      


    }
}
