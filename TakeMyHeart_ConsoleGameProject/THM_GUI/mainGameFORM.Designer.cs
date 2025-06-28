namespace THM_GUI
{
    partial class mainGameFORM
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
            introPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            proButt = new Button();
            nameTxtBox = new TextBox();
            pictureBox1 = new PictureBox();
            bButton = new Button();
            aButton = new Button();
            introPanel2 = new Panel();
            nameLBL = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            choice1 = new Panel();
            storyPanel = new Panel();
            storyLineLBL = new Label();
            nextButt = new Button();
            pictureBox3 = new PictureBox();
            startPanel = new Panel();
            introPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            introPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            choice1.SuspendLayout();
            storyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // introPanel
            // 
            introPanel.Controls.Add(label3);
            introPanel.Controls.Add(label2);
            introPanel.Controls.Add(label1);
            introPanel.Controls.Add(proButt);
            introPanel.Controls.Add(nameTxtBox);
            introPanel.Controls.Add(pictureBox1);
            introPanel.Location = new Point(-4, -2);
            introPanel.Name = "introPanel";
            introPanel.Size = new Size(1000, 637);
            introPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(479, 554);
            label3.Name = "label3";
            label3.Size = new Size(297, 16);
            label3.TabIndex = 4;
            label3.Text = "Tips: Those are some oddly place capital letters...hm";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 264);
            label2.Name = "label2";
            label2.Size = new Size(380, 35);
            label2.TabIndex = 3;
            label2.Text = "Hello there! what's your name?";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 196);
            label1.Name = "label1";
            label1.Size = new Size(500, 35);
            label1.TabIndex = 2;
            label1.Text = "Choose wisely—you only get one chance ;)";
            label1.Click += label1_Click;
            // 
            // proButt
            // 
            proButt.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proButt.Location = new Point(444, 439);
            proButt.Name = "proButt";
            proButt.Size = new Size(144, 54);
            proButt.TabIndex = 1;
            proButt.Text = "Proceed";
            proButt.TextImageRelation = TextImageRelation.ImageBeforeText;
            proButt.UseVisualStyleBackColor = true;
            proButt.Click += proButt_Click;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTxtBox.Location = new Point(339, 328);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(373, 52);
            nameTxtBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.startGameBG1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(996, 634);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bButton
            // 
            bButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bButton.Location = new Point(300, 369);
            bButton.Name = "bButton";
            bButton.Size = new Size(379, 107);
            bButton.TabIndex = 5;
            bButton.Text = "placeholder";
            bButton.UseVisualStyleBackColor = true;
            bButton.Click += bButton_Click;
            // 
            // aButton
            // 
            aButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aButton.Location = new Point(300, 262);
            aButton.Name = "aButton";
            aButton.Size = new Size(379, 101);
            aButton.TabIndex = 3;
            aButton.Text = "placeholder";
            aButton.UseVisualStyleBackColor = true;
            aButton.Click += aButton_Click;
            // 
            // introPanel2
            // 
            introPanel2.Controls.Add(nameLBL);
            introPanel2.Controls.Add(label5);
            introPanel2.Controls.Add(label6);
            introPanel2.Controls.Add(pictureBox2);
            introPanel2.Location = new Point(-2, -1);
            introPanel2.Name = "introPanel2";
            introPanel2.Size = new Size(1000, 637);
            introPanel2.TabIndex = 2;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.BackColor = Color.Transparent;
            nameLBL.FlatStyle = FlatStyle.Flat;
            nameLBL.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLBL.Location = new Point(564, 196);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(146, 35);
            nameLBL.TabIndex = 4;
            nameLBL.Text = "placeholder";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 139);
            label5.Name = "label5";
            label5.Size = new Size(144, 35);
            label5.TabIndex = 3;
            label5.Text = "Goodluck ;)";
            label5.Click += label5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 196);
            label6.Name = "label6";
            label6.Size = new Size(194, 35);
            label6.TabIndex = 2;
            label6.Text = "I see! Welcome";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.startGameBG1;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(996, 634);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // choice1
            // 
            choice1.Controls.Add(storyPanel);
            choice1.Controls.Add(nextButt);
            choice1.Controls.Add(pictureBox3);
            choice1.Location = new Point(-2, -7);
            choice1.Name = "choice1";
            choice1.Size = new Size(1016, 643);
            choice1.TabIndex = 3;
            // 
            // storyPanel
            // 
            storyPanel.BackColor = Color.White;
            storyPanel.BackgroundImageLayout = ImageLayout.None;
            storyPanel.BorderStyle = BorderStyle.FixedSingle;
            storyPanel.Controls.Add(storyLineLBL);
            storyPanel.Location = new Point(39, 364);
            storyPanel.Name = "storyPanel";
            storyPanel.Size = new Size(909, 211);
            storyPanel.TabIndex = 4;
            storyPanel.Paint += panel1_Paint;
            // 
            // storyLineLBL
            // 
            storyLineLBL.AutoSize = true;
            storyLineLBL.BackColor = Color.White;
            storyLineLBL.FlatStyle = FlatStyle.Flat;
            storyLineLBL.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            storyLineLBL.Location = new Point(16, 18);
            storyLineLBL.Name = "storyLineLBL";
            storyLineLBL.Size = new Size(96, 23);
            storyLineLBL.TabIndex = 2;
            storyLineLBL.Text = "placeholder";
            // 
            // nextButt
            // 
            nextButt.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButt.Location = new Point(850, 589);
            nextButt.Name = "nextButt";
            nextButt.Size = new Size(102, 40);
            nextButt.TabIndex = 8;
            nextButt.Text = ">>";
            nextButt.UseVisualStyleBackColor = true;
            nextButt.Click += nextButt_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.choiceOneCG;
            pictureBox3.Location = new Point(-6, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1001, 643);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // startPanel
            // 
            startPanel.Location = new Point(0, 0);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(997, 634);
            startPanel.TabIndex = 1;
            startPanel.Paint += startPanel_Paint;
            // 
            // mainGameFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 634);
            Controls.Add(aButton);
            Controls.Add(bButton);
            Controls.Add(choice1);
            Controls.Add(introPanel);
            Controls.Add(introPanel2);
            Controls.Add(startPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainGameFORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take My Heart";
            Load += mainGameFORM_Load;
            introPanel.ResumeLayout(false);
            introPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            introPanel2.ResumeLayout(false);
            introPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            choice1.ResumeLayout(false);
            storyPanel.ResumeLayout(false);
            storyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel introPanel;
        private PictureBox pictureBox1;
        private TextBox nameTxtBox;
        private Button proButt;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel introPanel2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Label nameLBL;
        private Button bButton;
        private Button aButton;
        private Panel choice1;
        private Label storyLineLBL;
        private PictureBox pictureBox3;
        private Panel storyPanel;
        private Button nextButt;
        private Panel startPanel;
        private Label lvptsLBL;
    }
}