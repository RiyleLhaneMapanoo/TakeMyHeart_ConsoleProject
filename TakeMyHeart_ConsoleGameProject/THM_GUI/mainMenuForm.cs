namespace THM_GUI
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startLbl_Click(object sender, EventArgs e)
        {

        }

        private void startButt_Click(object sender, EventArgs e)
        {
            mainGameFORM newForm = new mainGameFORM();  
            newForm.Show();             
            this.Hide();                  
        }
    }
}
