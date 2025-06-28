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
    public partial class guideUIForm : Form
    {
        static THMProcess busPro = new THMProcess();
        public static string[] getroutesData = busPro.getroutesData();
        public guideUIForm()
        {
            InitializeComponent();
        }
        public void search()
        {

            string searchRoute = routeTxt.Text.ToLower().Trim();

            routeLBL.Text = "";
            routePanel.Visible = false;


            if (string.IsNullOrEmpty(searchRoute))
            {
                MessageBox.Show("Please enter a route keyword to search.", "Search Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool routeFound = false;

            if (searchRoute == "the fool")
            {



                routePanel.Visible = true;
                routeLBL.Text = getroutesData[0];
                routeFound = true;

                label1.Visible = false;
                label2.Visible = false;
                searchButt.Visible = false;
                routeTxt.Visible = false;
            }
            else if (searchRoute == "the hanged man")
            {



                routePanel.Visible = true;
                routeLBL.Text = getroutesData[1];
                routeFound = true;

                label1.Visible = false;
                label2.Visible = false;
                searchButt.Visible = false;
                routeTxt.Visible = false;
            }

            if (routeFound)
            {
                routePanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Keyword Invalid. Please try a different search term.",
                               "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButt_Click(object sender, EventArgs e)
        {
            mainMenuForm mainMenu = new mainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void searchButt_Click(object sender, EventArgs e)
        {
            search();
        }

        private void guideUIForm_Load(object sender, EventArgs e)
        {
            routePanel.Visible = false;
        }
    }
}
