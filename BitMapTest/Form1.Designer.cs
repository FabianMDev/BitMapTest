namespace BitMapTest
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonColorPoints = new System.Windows.Forms.Button();
            this.buttonColorDots = new System.Windows.Forms.Button();
            this.buttonColorBackground = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonResetBM = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.PointsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelMainScreen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.buttonColorPoints);
            this.panelSideMenu.Controls.Add(this.buttonColorDots);
            this.panelSideMenu.Controls.Add(this.buttonColorBackground);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.checkBoxAnimation);
            this.panelSideMenu.Controls.Add(this.checkBox1);
            this.panelSideMenu.Controls.Add(this.buttonResetBM);
            this.panelSideMenu.Controls.Add(this.buttonReset);
            this.panelSideMenu.Controls.Add(this.numericUpDown1);
            this.panelSideMenu.Controls.Add(this.checkedListBox1);
            this.panelSideMenu.Controls.Add(this.PointsCount);
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.buttonSave);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(185, 674);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonColorPoints
            // 
            this.buttonColorPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorPoints.Location = new System.Drawing.Point(8, 269);
            this.buttonColorPoints.Name = "buttonColorPoints";
            this.buttonColorPoints.Size = new System.Drawing.Size(171, 23);
            this.buttonColorPoints.TabIndex = 14;
            this.buttonColorPoints.Text = "Color Points";
            this.buttonColorPoints.UseVisualStyleBackColor = true;
            this.buttonColorPoints.Click += new System.EventHandler(this.buttonColorPoints_Click);
            // 
            // buttonColorDots
            // 
            this.buttonColorDots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorDots.Location = new System.Drawing.Point(8, 241);
            this.buttonColorDots.Name = "buttonColorDots";
            this.buttonColorDots.Size = new System.Drawing.Size(171, 23);
            this.buttonColorDots.TabIndex = 13;
            this.buttonColorDots.Text = "Color Dots";
            this.buttonColorDots.UseVisualStyleBackColor = true;
            this.buttonColorDots.Click += new System.EventHandler(this.buttonColorDots_Click);
            // 
            // buttonColorBackground
            // 
            this.buttonColorBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorBackground.Location = new System.Drawing.Point(8, 212);
            this.buttonColorBackground.Name = "buttonColorBackground";
            this.buttonColorBackground.Size = new System.Drawing.Size(171, 23);
            this.buttonColorBackground.TabIndex = 12;
            this.buttonColorBackground.Text = "Color Background";
            this.buttonColorBackground.UseVisualStyleBackColor = true;
            this.buttonColorBackground.Click += new System.EventHandler(this.buttonColorBackground_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset Points";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Location = new System.Drawing.Point(99, 36);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(53, 19);
            this.checkBoxAnimation.TabIndex = 10;
            this.checkBoxAnimation.Text = "anim";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            this.checkBoxAnimation.CheckedChanged += new System.EventHandler(this.checkBoxAnimation_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Cant Go To Same Point Again";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonResetBM
            // 
            this.buttonResetBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetBM.Location = new System.Drawing.Point(12, 581);
            this.buttonResetBM.Name = "buttonResetBM";
            this.buttonResetBM.Size = new System.Drawing.Size(167, 23);
            this.buttonResetBM.TabIndex = 7;
            this.buttonResetBM.Text = "Reset BitMap";
            this.buttonResetBM.UseVisualStyleBackColor = true;
            this.buttonResetBM.Click += new System.EventHandler(this.buttonResetBM_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(12, 610);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(167, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset All";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 148);
            this.checkedListBox1.TabIndex = 4;
            // 
            // PointsCount
            // 
            this.PointsCount.AutoSize = true;
            this.PointsCount.Location = new System.Drawing.Point(67, 37);
            this.PointsCount.Name = "PointsCount";
            this.PointsCount.Size = new System.Drawing.Size(13, 15);
            this.PointsCount.TabIndex = 3;
            this.PointsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkte: ";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(12, 639);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(167, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Play";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelMainScreen
            // 
            this.panelMainScreen.Controls.Add(this.pictureBox1);
            this.panelMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainScreen.Location = new System.Drawing.Point(185, 0);
            this.panelMainScreen.Name = "panelMainScreen";
            this.panelMainScreen.Size = new System.Drawing.Size(789, 674);
            this.panelMainScreen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 668);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 674);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "BitMapTest";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelMainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Button buttonSave;
        private Panel panelMainScreen;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private Label PointsCount;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button buttonReset;
        private Button buttonResetBM;
        private CheckBox checkBox1;
        private CheckBox checkBoxAnimation;
        private Button button1;
        private Button buttonColorPoints;
        private Button buttonColorDots;
        private Button buttonColorBackground;
    }
}