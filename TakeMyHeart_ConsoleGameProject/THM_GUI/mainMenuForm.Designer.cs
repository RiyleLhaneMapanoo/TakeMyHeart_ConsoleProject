namespace THM_GUI
{
    partial class mainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            startButt = new Button();
            hsButt = new Button();
            guideButt = new Button();
            exitButt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mainMenuBG;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(992, 674);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // startButt
            // 
            startButt.BackColor = Color.White;
            startButt.FlatStyle = FlatStyle.Flat;
            startButt.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButt.Location = new Point(400, 285);
            startButt.Name = "startButt";
            startButt.Size = new Size(233, 55);
            startButt.TabIndex = 2;
            startButt.Text = "Start";
            startButt.UseVisualStyleBackColor = false;
            startButt.Click += startButt_Click;
            // 
            // hsButt
            // 
            hsButt.BackColor = Color.White;
            hsButt.FlatStyle = FlatStyle.Flat;
            hsButt.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hsButt.Location = new Point(400, 362);
            hsButt.Name = "hsButt";
            hsButt.Size = new Size(233, 55);
            hsButt.TabIndex = 3;
            hsButt.Text = "High Scores";
            hsButt.UseVisualStyleBackColor = false;
            hsButt.Click += hsButt_Click;
            // 
            // guideButt
            // 
            guideButt.BackColor = Color.White;
            guideButt.FlatStyle = FlatStyle.Flat;
            guideButt.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guideButt.Location = new Point(400, 448);
            guideButt.Name = "guideButt";
            guideButt.Size = new Size(233, 55);
            guideButt.TabIndex = 4;
            guideButt.Text = "Guide";
            guideButt.UseVisualStyleBackColor = false;
            guideButt.Click += guideButt_Click;
            // 
            // exitButt
            // 
            exitButt.BackColor = Color.White;
            exitButt.FlatStyle = FlatStyle.Flat;
            exitButt.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButt.Location = new Point(400, 522);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(233, 55);
            exitButt.TabIndex = 5;
            exitButt.Text = "Exit";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 672);
            Controls.Add(exitButt);
            Controls.Add(guideButt);
            Controls.Add(hsButt);
            Controls.Add(startButt);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take My Heart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button startButt;
        private Button hsButt;
        private Button guideButt;
        private Button exitButt;
    }
}
