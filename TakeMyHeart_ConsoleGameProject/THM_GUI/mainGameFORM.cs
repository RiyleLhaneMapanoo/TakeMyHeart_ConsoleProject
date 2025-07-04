﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMH_BusinessDataLogic;

namespace THM_GUI
{
    public partial class mainGameFORM : Form
    {
        static THMProcess busPro = new THMProcess();
        public static int setlvPTs;
        public static int finalLovePts;

        //public static int highScoreSlot; //= busPro.highscoreslotIncrementor();
        public static int getlvPTs = busPro.getlovePts();
        public static int getfinalLovePts = busPro.getfinalLovePts();

        public static string[] storyLine = busPro.getstoryLineLibrary();
        public static string[] A_Choices = busPro.getchoicesALibrary();
        public static string[] B_Choices = busPro.getchoicesBLibrary();
        public static string[] storyLine_A = busPro.getStoryDialougeA();
        public static string[] storyLine_B = busPro.getStoryDialougeB();
        public static string[] getroutesData = busPro.getroutesData();
        public static string Pname;

        public static string invalidMess = busPro.InvalidChoice();
        public int currentRouteIndex = 1;

        public mainGameFORM()
        {
            InitializeComponent();

        
            panelVisibilities("intro");
           

        }

       
        public void panelVisibilities(string target)
        {
            // Hide all main panels first
            introPanel.Visible = false;
            introPanel2.Visible = false;
            choice1.Visible = false;

            // Hide shared UI elements
            aButton.Visible = false;
            bButton.Visible = false;
            storyLineLBL.Visible = false;
            storyPanel.Visible = false;
            nextButt.Visible = false;

            switch (target)
            {
                case "intro":
                    introPanel.Visible = true;
                    break;

                case "intro2":
                    introPanel2.Visible = true;
                    aButton.Visible = true;
                    bButton.Visible = true;
                    choicesButton(A_Choices[0], B_Choices[0], aButton, bButton);
                    break;

                case "story":
                    choice1.Visible = true;
                    
                    storyLineLBL.Visible = true;
                    storyPanel.Visible = true;
                    nextButt.Visible = true;
                    //aButton.Visible = true;
                    //bButton.Visible = true;
                    break;

                case "choice":
                    choice1.Visible = true;
                    //storyLineLBL.Visible = true;
                    //storyPanel.Visible = true;
                    aButton.Visible = true;
                    bButton.Visible = true;
                    break;
            }
        }



        public void GameChoicesRouter(string choice, Button aButt, Button bButt)
        {
            
            switch (currentRouteIndex)
            {
                case 1:
                    updateCG("choiceOneCG");
                    choicesButton(A_Choices[1], B_Choices[1], aButt, bButt);
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 5, 10, 3, 3, storyLine[0] , "", "");
                    break;
                case 2:
                    
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 10, 2, 5, 5, storyLine[1], "", "");
                    updateCG("wtsCG");
                    choicesButton(A_Choices[2], B_Choices[2], aButt, bButt);
                    break;

                case 3:
                    string result = busPro.pointAllocation(ref setlvPTs, 5, 10, choice);
                 

                    if (result == "a")
                    {
                        goto case 2;
                    }
                    else if (result == "b")
                    {
                        goto case 4;
                    }
                    break;
                case 4:
                   
                    storyLineDisp(storyLine[2], storyLineLBL, "");
                  
                    choicesButton("A.) :]", "B.) :]", aButt, bButt);
                    updateCG("rp2");
                    panelVisibilities("story");
                    currentRouteIndex = 5;
                    break;

                case 5:
                    choicesButton(A_Choices[3], B_Choices[3], aButt, bButt);
                    updateCG("schoolBG");
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 2, 10, 6, 6, storyLine[3],  "", "");
                    break;

                case 6:
                    choicesButton(A_Choices[4], B_Choices[4], aButt, bButt);
                    updateCG("schoolneutral");
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 10, 2, 7, 7, storyLine[4], "", "");
                    break;

                case 7:
                    choicesButton(A_Choices[5], B_Choices[5], aButt, bButt);
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 2, 10, 8, 8, storyLine[5] , "","");
                    break;

                case 8:
                    choicesButton(A_Choices[6], B_Choices[6], aButt, bButt);
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 2, 10, 9, 9, storyLine[6] , storyLine_A[0], storyLine_B[0]);
                    break;

                case 9:
                    choicesButton(A_Choices[7].Replace("placeholder", busPro.getName()), B_Choices[7], aButt, bButt);
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 2, 10, 10, 10, storyLine[7], storyLine_A[1], storyLine_B[1]);
                   
                    if (choice == "a")
                    {
                        updateCG("schoolsmirk");
                    }
                    else if (choice == "b")
                    {
                        updateCG("schoolfrown");
                    }
                    break;

                case 10:
                    choicesButton(A_Choices[8], B_Choices[8], aButt, bButt);
                    currentRouteIndex = GameChoices(choice, aButt, bButt, 2, 10, 11, 11, storyLine[8], "", "");
                    updateCG("clBG");
                    break;
                case 11:
                    storyLineDisp(storyLine[9], storyLineLBL, "");
                    finalLovePts = busPro.setLovePts(setlvPTs);
                    busPro.addHighScore(finalLovePts, Pname);

                
                    currentRouteIndex = Endings(storyLine[10], storyLine[11], Pname, invalidMess);

              
                    panelVisibilities("story");
                    break;
                case 12:
                    break;
                case 13:
                    YesOrNoRestart(choice);
                    break;
                default:
                    MessageBox.Show("End of route or invalid index.");
                    break;
            }
        }


        public int GameChoices(string choice, Button aButt, Button bButt,int ptsA, int ptsB, int nextRouteA, int nextRouteB,string storyline, string sDA, string sDB)
        {
            string result = busPro.pointAllocation(ref setlvPTs, ptsA, ptsB, choice);

            if (result == "a")
            {
                storyLineDisp(storyline, storyLineLBL, sDA);
                return nextRouteA;
            }
            else if (result == "b")
            {
                storyLineDisp(storyline, storyLineLBL, sDB);
                return nextRouteB;
            }
            else
            {
                MessageBox.Show(invalidMess);
                return 0;
            }
        }

        public void YesOrNoRestart(string choice)
        {
            if (choice == "a") 
            {
             
                busPro.removeItemonHSList();
                RestartGame();
            }
            else if (choice == "b") 
            {
                GoToMainMenu();
            }
            else
            {
                MessageBox.Show("Invalid choice. Please select A or B.");
            }
        }

        public int Endings(string badEnding, string goodEnding, string player, string invChoice)
        {
            int mainLovePts = setlvPTs;

            if (mainLovePts < 60)
            {
                storyLineDisp(badEnding, storyLineLBL, "");
                updateCG("badEndCG");
                choicesButton("A.) Restart Game", "B.) Main Menu", aButton, bButton);
               
               // MessageBox.Show("You've Reached a Bad End :[ . Would you like to start over?");
                return 13; 
            }
            else if (mainLovePts >= 60)
            {
                
                storyLineDisp(goodEnding, storyLineLBL, "");
                updateCG("goodEndCG");
                choicesButton("A.) Restart Game", "B.) Main Menu", aButton, bButton);

               // MessageBox.Show("You've Reached a Good End(?) :) ♥ . Would you like to start over?");

                return 13; 
            }

            return 12; 
        }

      
        private void RestartGame()
        {
            
            setlvPTs = 0;
            finalLovePts = 0;
            currentRouteIndex = 1;

            panelVisibilities("intro");

            nameTxtBox.Text = "";
          //  lvptsLBL.Text = "0";
        }

        private void GoToMainMenu()
        {
            this.Hide();

             mainMenuForm mainMenu = new mainMenuForm();
            mainMenu.Show();
        }

        public void choicesButton(string choiceA, string choiceB, Button aButt, Button bButt)
        {

            aButt.Text = choiceA;

            bButt.Text = choiceB;
        }

        public void storyLineDisp(string storyL, Label sl,string storyLChoice)
        {
            string formattedStory = storyL.Replace(".", ".\n");
            sl.Text = storyLChoice  +formattedStory;
        }
        public void updateCG(string photoname)
        {
            try
            {
                
                var resourceManager = Properties.Resources.ResourceManager;
                var image = resourceManager.GetObject(photoname) as System.Drawing.Image;

                if (image != null)
                {
                    pictureBox3.Image = image;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show($"Image '{photoname}' not found in resources.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image '{photoname}': {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void proButt_Click(object sender, EventArgs e)
        {
            Pname = nameTxtBox.Text.Trim();
            busPro.addP(Pname);
            nameLBL.Text = Pname;
            panelVisibilities("intro2");

        }

        private void mainGameFORM_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aButton_Click(object sender, EventArgs e)
        {
            // Assume you're on route 3
           
                panelVisibilities("story");
                
           

            GameChoicesRouter("a", aButton, bButton);
            //introPanel.Visible = false;
            //introPanel2.Visible = false;
            //choice1.Visible = true;
            //aButton.Visible = false;
            //bButton.Visible = false;

        }

        private void bButton_Click(object sender, EventArgs e)
        {
            //introPanel.Visible = false;
            //introPanel2.Visible = false;
            //choice1.Visible = true;
            //aButton.Visible = false;
            //bButton.Visible = false;
           
                 panelVisibilities("story");
                  

            GameChoicesRouter("b", aButton, bButton);
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void nextButt_Click(object sender, EventArgs e)
        {

            panelVisibilities("choice");
           }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
