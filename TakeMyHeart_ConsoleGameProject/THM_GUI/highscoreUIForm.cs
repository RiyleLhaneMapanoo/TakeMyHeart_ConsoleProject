using System;
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
    public partial class highscoreUIForm : Form
    {
        static THMProcess busPro = new THMProcess();
     
        
      
        public highscoreUIForm()
        {
            InitializeComponent();
            displayHighscoreList();
        }

        public void displayHighscoreList()
        {
            var highscoreList = busPro.SortHighScoreList();


            highscoreListBox.Items.Clear();

            if (highscoreList.Count == 0)
            {
                highscoreListBox.Items.Add("No high scores yet!");
                return;
            }

            int highScoreSlot = 1;
            foreach (var entry in highscoreList)
            {
                string highScoreEntry = $"Slot {highScoreSlot}: {entry.playerName} - {entry.highscoreNum} points";
                highscoreListBox.Items.Add(highScoreEntry);
                highScoreSlot++;
            }
        }


        private void backButt_Click(object sender, EventArgs e)
        {

            mainMenuForm mainMenu = new mainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void highscoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
