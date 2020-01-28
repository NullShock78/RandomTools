namespace EmoteWallGUI
{
    partial class ImageSplitform
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
            this.buttonDoit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelEmoteName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.radioButtonSans = new System.Windows.Forms.RadioButton();
            this.radioButtonFlags = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxTrollMode = new System.Windows.Forms.CheckBox();
            this.numericUpDownBombs = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateMS = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMSEmoteName = new System.Windows.Forms.TextBox();
            this.textBoxMSOut = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxL3 = new System.Windows.Forms.TextBox();
            this.buttonGenSquare = new System.Windows.Forms.Button();
            this.textBoxCenter = new System.Windows.Forms.TextBox();
            this.textBoxL2 = new System.Windows.Forms.TextBox();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.textBoxL0 = new System.Windows.Forms.TextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxBoomOut = new System.Windows.Forms.TextBox();
            this.textBoxBoomIn = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxEscaped = new System.Windows.Forms.TextBox();
            this.textBoxEscape = new System.Windows.Forms.TextBox();
            this.buttonSliceGif = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.confIn = new System.Windows.Forms.TextBox();
            this.confOut = new System.Windows.Forms.TextBox();
            this.buttonConf = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoit
            // 
            this.buttonDoit.Location = new System.Drawing.Point(16, 35);
            this.buttonDoit.Name = "buttonDoit";
            this.buttonDoit.Size = new System.Drawing.Size(158, 36);
            this.buttonDoit.TabIndex = 0;
            this.buttonDoit.Text = "Slice Image";
            this.buttonDoit.UseVisualStyleBackColor = true;
            this.buttonDoit.Click += new System.EventHandler(this.buttonDoit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 91);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(369, 223);
            this.textBoxOutput.TabIndex = 2;
            // 
            // labelEmoteName
            // 
            this.labelEmoteName.AutoSize = true;
            this.labelEmoteName.Location = new System.Drawing.Point(13, 12);
            this.labelEmoteName.Name = "labelEmoteName";
            this.labelEmoteName.Size = new System.Drawing.Size(71, 13);
            this.labelEmoteName.TabIndex = 3;
            this.labelEmoteName.Text = "Emote Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 59);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOut
            // 
            this.textBoxOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxOut.Location = new System.Drawing.Point(6, 75);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(370, 172);
            this.textBoxOut.TabIndex = 5;
            // 
            // radioButtonSans
            // 
            this.radioButtonSans.AutoSize = true;
            this.radioButtonSans.Location = new System.Drawing.Point(6, 253);
            this.radioButtonSans.Name = "radioButtonSans";
            this.radioButtonSans.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSans.TabIndex = 6;
            this.radioButtonSans.Text = "Sans";
            this.radioButtonSans.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlags
            // 
            this.radioButtonFlags.AutoSize = true;
            this.radioButtonFlags.Checked = true;
            this.radioButtonFlags.Location = new System.Drawing.Point(61, 253);
            this.radioButtonFlags.Name = "radioButtonFlags";
            this.radioButtonFlags.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFlags.TabIndex = 7;
            this.radioButtonFlags.TabStop = true;
            this.radioButtonFlags.Text = "Flags";
            this.radioButtonFlags.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(387, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 302);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.radioButtonFlags);
            this.tabPage1.Controls.Add(this.textBoxOut);
            this.tabPage1.Controls.Add(this.radioButtonSans);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxTrollMode);
            this.tabPage2.Controls.Add(this.numericUpDownBombs);
            this.tabPage2.Controls.Add(this.buttonGenerateMS);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxMSEmoteName);
            this.tabPage2.Controls.Add(this.textBoxMSOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrollMode
            // 
            this.checkBoxTrollMode.AutoSize = true;
            this.checkBoxTrollMode.Location = new System.Drawing.Point(100, 41);
            this.checkBoxTrollMode.Name = "checkBoxTrollMode";
            this.checkBoxTrollMode.Size = new System.Drawing.Size(42, 17);
            this.checkBoxTrollMode.TabIndex = 6;
            this.checkBoxTrollMode.Text = "troll";
            this.checkBoxTrollMode.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBombs
            // 
            this.numericUpDownBombs.Location = new System.Drawing.Point(204, 38);
            this.numericUpDownBombs.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownBombs.Name = "numericUpDownBombs";
            this.numericUpDownBombs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBombs.TabIndex = 5;
            this.numericUpDownBombs.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // buttonGenerateMS
            // 
            this.buttonGenerateMS.Location = new System.Drawing.Point(6, 38);
            this.buttonGenerateMS.Name = "buttonGenerateMS";
            this.buttonGenerateMS.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateMS.TabIndex = 4;
            this.buttonGenerateMS.Text = "Generate";
            this.buttonGenerateMS.UseVisualStyleBackColor = true;
            this.buttonGenerateMS.Click += new System.EventHandler(this.buttonGenerateMS_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emote Name";
            // 
            // textBoxMSEmoteName
            // 
            this.textBoxMSEmoteName.Location = new System.Drawing.Point(276, 6);
            this.textBoxMSEmoteName.Name = "textBoxMSEmoteName";
            this.textBoxMSEmoteName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSEmoteName.TabIndex = 1;
            this.textBoxMSEmoteName.Text = "HOO";
            // 
            // textBoxMSOut
            // 
            this.textBoxMSOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMSOut.Location = new System.Drawing.Point(6, 67);
            this.textBoxMSOut.Multiline = true;
            this.textBoxMSOut.Name = "textBoxMSOut";
            this.textBoxMSOut.ReadOnly = true;
            this.textBoxMSOut.Size = new System.Drawing.Size(370, 203);
            this.textBoxMSOut.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxL3);
            this.tabPage3.Controls.Add(this.buttonGenSquare);
            this.tabPage3.Controls.Add(this.textBoxCenter);
            this.tabPage3.Controls.Add(this.textBoxL2);
            this.tabPage3.Controls.Add(this.textBoxL1);
            this.tabPage3.Controls.Add(this.textBoxL0);
            this.tabPage3.Controls.Add(this.textBoxSquare);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(382, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxL3
            // 
            this.textBoxL3.Location = new System.Drawing.Point(4, 85);
            this.textBoxL3.Name = "textBoxL3";
            this.textBoxL3.Size = new System.Drawing.Size(100, 20);
            this.textBoxL3.TabIndex = 15;
            // 
            // buttonGenSquare
            // 
            this.buttonGenSquare.Location = new System.Drawing.Point(146, 31);
            this.buttonGenSquare.Name = "buttonGenSquare";
            this.buttonGenSquare.Size = new System.Drawing.Size(75, 23);
            this.buttonGenSquare.TabIndex = 14;
            this.buttonGenSquare.Text = "button1";
            this.buttonGenSquare.UseVisualStyleBackColor = true;
            this.buttonGenSquare.Click += new System.EventHandler(this.buttonGenSquare_Click);
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.Location = new System.Drawing.Point(268, 31);
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenter.TabIndex = 13;
            // 
            // textBoxL2
            // 
            this.textBoxL2.Location = new System.Drawing.Point(4, 58);
            this.textBoxL2.Name = "textBoxL2";
            this.textBoxL2.Size = new System.Drawing.Size(100, 20);
            this.textBoxL2.TabIndex = 12;
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(4, 30);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(100, 20);
            this.textBoxL1.TabIndex = 11;
            // 
            // textBoxL0
            // 
            this.textBoxL0.Location = new System.Drawing.Point(4, 4);
            this.textBoxL0.Name = "textBoxL0";
            this.textBoxL0.Size = new System.Drawing.Size(100, 20);
            this.textBoxL0.TabIndex = 10;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSquare.Location = new System.Drawing.Point(3, 122);
            this.textBoxSquare.Multiline = true;
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.ReadOnly = true;
            this.textBoxSquare.Size = new System.Drawing.Size(374, 151);
            this.textBoxSquare.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxBoomOut);
            this.tabPage4.Controls.Add(this.textBoxBoomIn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(382, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxBoomOut
            // 
            this.textBoxBoomOut.Location = new System.Drawing.Point(17, 82);
            this.textBoxBoomOut.Multiline = true;
            this.textBoxBoomOut.Name = "textBoxBoomOut";
            this.textBoxBoomOut.Size = new System.Drawing.Size(301, 152);
            this.textBoxBoomOut.TabIndex = 1;
            // 
            // textBoxBoomIn
            // 
            this.textBoxBoomIn.Location = new System.Drawing.Point(3, 3);
            this.textBoxBoomIn.Name = "textBoxBoomIn";
            this.textBoxBoomIn.Size = new System.Drawing.Size(238, 20);
            this.textBoxBoomIn.TabIndex = 0;
            this.textBoxBoomIn.TextChanged += new System.EventHandler(this.textBoxBoomIn_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxEscaped);
            this.tabPage5.Controls.Add(this.textBoxEscape);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(382, 276);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxEscaped
            // 
            this.textBoxEscaped.Location = new System.Drawing.Point(13, 37);
            this.textBoxEscaped.Multiline = true;
            this.textBoxEscaped.Name = "textBoxEscaped";
            this.textBoxEscaped.Size = new System.Drawing.Size(276, 180);
            this.textBoxEscaped.TabIndex = 1;
            // 
            // textBoxEscape
            // 
            this.textBoxEscape.Location = new System.Drawing.Point(13, 10);
            this.textBoxEscape.Name = "textBoxEscape";
            this.textBoxEscape.Size = new System.Drawing.Size(276, 20);
            this.textBoxEscape.TabIndex = 0;
            this.textBoxEscape.TextChanged += new System.EventHandler(this.textBoxEscape_TextChanged);
            // 
            // buttonSliceGif
            // 
            this.buttonSliceGif.Location = new System.Drawing.Point(180, 35);
            this.buttonSliceGif.Name = "buttonSliceGif";
            this.buttonSliceGif.Size = new System.Drawing.Size(138, 36);
            this.buttonSliceGif.TabIndex = 9;
            this.buttonSliceGif.Text = "Slice Gif";
            this.buttonSliceGif.UseVisualStyleBackColor = true;
            this.buttonSliceGif.Click += new System.EventHandler(this.buttonSliceGif_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonConf);
            this.tabPage6.Controls.Add(this.confOut);
            this.tabPage6.Controls.Add(this.confIn);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(382, 276);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // confIn
            // 
            this.confIn.Location = new System.Drawing.Point(6, 17);
            this.confIn.Multiline = true;
            this.confIn.Name = "confIn";
            this.confIn.Size = new System.Drawing.Size(138, 73);
            this.confIn.TabIndex = 0;
            // 
            // confOut
            // 
            this.confOut.Location = new System.Drawing.Point(177, 17);
            this.confOut.Multiline = true;
            this.confOut.Name = "confOut";
            this.confOut.Size = new System.Drawing.Size(178, 73);
            this.confOut.TabIndex = 1;
            // 
            // buttonConf
            // 
            this.buttonConf.Location = new System.Drawing.Point(6, 96);
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size(75, 23);
            this.buttonConf.TabIndex = 2;
            this.buttonConf.Text = "button1";
            this.buttonConf.UseVisualStyleBackColor = true;
            this.buttonConf.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // ImageSplitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 326);
            this.Controls.Add(this.buttonSliceGif);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelEmoteName);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDoit);
            this.MinimumSize = new System.Drawing.Size(467, 273);
            this.Name = "ImageSplitform";
            this.Text = "Create Emote Wall";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelEmoteName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.RadioButton radioButtonSans;
        private System.Windows.Forms.RadioButton radioButtonFlags;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMSEmoteName;
        private System.Windows.Forms.TextBox textBoxMSOut;
        private System.Windows.Forms.Button buttonGenerateMS;
        private System.Windows.Forms.NumericUpDown numericUpDownBombs;
        private System.Windows.Forms.CheckBox checkBoxTrollMode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxCenter;
        private System.Windows.Forms.TextBox textBoxL2;
        private System.Windows.Forms.TextBox textBoxL1;
        private System.Windows.Forms.TextBox textBoxL0;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.Button buttonGenSquare;
        private System.Windows.Forms.TextBox textBoxL3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxBoomOut;
        private System.Windows.Forms.TextBox textBoxBoomIn;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TextBox textBoxEscaped;
        private System.Windows.Forms.TextBox textBoxEscape;
        private System.Windows.Forms.Button buttonSliceGif;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.TextBox confOut;
        private System.Windows.Forms.TextBox confIn;
    }
}

