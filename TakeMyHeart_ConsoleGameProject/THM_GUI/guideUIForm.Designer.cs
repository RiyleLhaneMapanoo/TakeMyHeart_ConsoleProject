namespace THM_GUI
{
    partial class guideUIForm
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
            routePanel = new Panel();
            routeLBL = new Label();
            label1 = new Label();
            routeTxt = new TextBox();
            searchButt = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            routePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.startGameBG1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(997, 677);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backButt
            // 
            backButt.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButt.Location = new Point(27, 12);
            backButt.Name = "backButt";
            backButt.Size = new Size(80, 44);
            backButt.TabIndex = 1;
            backButt.Text = "<<";
            backButt.UseVisualStyleBackColor = true;
            backButt.Click += backButt_Click;
            // 
            // routePanel
            // 
            routePanel.Controls.Add(routeLBL);
            routePanel.Location = new Point(250, 175);
            routePanel.Name = "routePanel";
            routePanel.Size = new Size(531, 368);
            routePanel.TabIndex = 2;
            // 
            // routeLBL
            // 
            routeLBL.AutoSize = true;
            routeLBL.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            routeLBL.Location = new Point(3, 0);
            routeLBL.Name = "routeLBL";
            routeLBL.Size = new Size(45, 19);
            routeLBL.TabIndex = 0;
            routeLBL.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(194, 184, 172);
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 145);
            label1.Name = "label1";
            label1.Size = new Size(368, 27);
            label1.TabIndex = 1;
            label1.Text = "Which route would you like to search?";
            // 
            // routeTxt
            // 
            routeTxt.BackColor = Color.White;
            routeTxt.BorderStyle = BorderStyle.FixedSingle;
            routeTxt.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeTxt.Location = new Point(250, 250);
            routeTxt.Name = "routeTxt";
            routeTxt.Size = new Size(531, 45);
            routeTxt.TabIndex = 3;
            routeTxt.TextChanged += textBox1_TextChanged;
            // 
            // searchButt
            // 
            searchButt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButt.Location = new Point(475, 350);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(94, 44);
            searchButt.TabIndex = 4;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = true;
            searchButt.Click += searchButt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(196, 186, 174);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 546);
            label2.Name = "label2";
            label2.Size = new Size(225, 16);
            label2.TabIndex = 5;
            label2.Text = "Tip: Notice anything with the dialogues?";
            label2.Click += label2_Click;
            // 
            // guideUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 672);
            Controls.Add(searchButt);
            Controls.Add(backButt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(routeTxt);
            Controls.Add(routePanel);
            Controls.Add(pictureBox1);
            Name = "guideUIForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "guideUIForm";
            Load += guideUIForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            routePanel.ResumeLayout(false);
            routePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button backButt;
        private Panel routePanel;
        private Label routeLBL;
        private Label label1;
        private TextBox routeTxt;
        private Button searchButt;
        private Label label2;
    }
}