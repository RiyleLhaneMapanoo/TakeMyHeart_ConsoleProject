namespace THM_GUI
{
    partial class highscoreUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            backButt = new Button();
            highscoreListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.startGameBG1;
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1001, 678);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backButt
            // 
            backButt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButt.Location = new Point(24, 23);
            backButt.Name = "backButt";
            backButt.Size = new Size(69, 43);
            backButt.TabIndex = 1;
            backButt.Text = "<<";
            backButt.UseVisualStyleBackColor = true;
            backButt.Click += backButt_Click;
            // 
            // highscoreListBox
            // 
            highscoreListBox.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            highscoreListBox.FormattingEnabled = true;
            highscoreListBox.ItemHeight = 30;
            highscoreListBox.Location = new Point(278, 185);
            highscoreListBox.Name = "highscoreListBox";
            highscoreListBox.Size = new Size(478, 334);
            highscoreListBox.TabIndex = 2;
            highscoreListBox.SelectedIndexChanged += highscoreListBox_SelectedIndexChanged;
            // 
            // highscoreUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 672);
            Controls.Add(highscoreListBox);
            Controls.Add(backButt);
            Controls.Add(pictureBox1);
            Name = "highscoreUIForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "highscoreUIForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backButt;
        private ListBox highscoreListBox;
    }
}