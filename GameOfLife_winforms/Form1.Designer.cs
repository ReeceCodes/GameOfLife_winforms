namespace GameOfLife_winforms
{
    partial class frmGOL
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPop = new System.Windows.Forms.Label();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.btnDeadColor = new System.Windows.Forms.Button();
            this.btnAliveColor = new System.Windows.Forms.Button();
            this.nmbInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPresets = new System.Windows.Forms.ComboBox();
            this.chkShortcut = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbRandom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grdLife = new GameOfLife_winforms.User_Controls.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.nmbInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(529, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(625, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(625, 98);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(529, 98);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 53);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Generate Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generation:";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(604, 166);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(0, 13);
            this.lblGen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Population:";
            // 
            // lblPop
            // 
            this.lblPop.AutoSize = true;
            this.lblPop.Location = new System.Drawing.Point(604, 204);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(0, 13);
            this.lblPop.TabIndex = 8;
            // 
            // chkLines
            // 
            this.chkLines.AutoSize = true;
            this.chkLines.Location = new System.Drawing.Point(34, 109);
            this.chkLines.Name = "chkLines";
            this.chkLines.Size = new System.Drawing.Size(103, 17);
            this.chkLines.TabIndex = 9;
            this.chkLines.Text = "Show Grid Lines";
            this.chkLines.UseVisualStyleBackColor = true;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(529, 52);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 10;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(625, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // clrDialog
            // 
            this.clrDialog.AnyColor = true;
            this.clrDialog.SolidColorOnly = true;
            // 
            // btnDeadColor
            // 
            this.btnDeadColor.BackColor = System.Drawing.Color.White;
            this.btnDeadColor.ForeColor = System.Drawing.Color.Black;
            this.btnDeadColor.Location = new System.Drawing.Point(93, 19);
            this.btnDeadColor.Name = "btnDeadColor";
            this.btnDeadColor.Size = new System.Drawing.Size(75, 23);
            this.btnDeadColor.TabIndex = 12;
            this.btnDeadColor.Text = "Dead Color";
            this.btnDeadColor.UseVisualStyleBackColor = false;
            // 
            // btnAliveColor
            // 
            this.btnAliveColor.BackColor = System.Drawing.Color.Black;
            this.btnAliveColor.ForeColor = System.Drawing.Color.White;
            this.btnAliveColor.Location = new System.Drawing.Point(3, 19);
            this.btnAliveColor.Name = "btnAliveColor";
            this.btnAliveColor.Size = new System.Drawing.Size(75, 23);
            this.btnAliveColor.TabIndex = 13;
            this.btnAliveColor.Text = "Alive Color";
            this.btnAliveColor.UseVisualStyleBackColor = false;
            // 
            // nmbInterval
            // 
            this.nmbInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmbInterval.Location = new System.Drawing.Point(107, 48);
            this.nmbInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmbInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbInterval.Name = "nmbInterval";
            this.nmbInterval.Size = new System.Drawing.Size(61, 20);
            this.nmbInterval.TabIndex = 14;
            this.nmbInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbInterval.ValueChanged += new System.EventHandler(this.nmbInterval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Interval (in ms):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboPresets);
            this.groupBox1.Controls.Add(this.chkShortcut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmbRandom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAliveColor);
            this.groupBox1.Controls.Add(this.nmbInterval);
            this.groupBox1.Controls.Add(this.chkLines);
            this.groupBox1.Controls.Add(this.btnDeadColor);
            this.groupBox1.Location = new System.Drawing.Point(518, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 237);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cboPresets
            // 
            this.cboPresets.FormattingEnabled = true;
            this.cboPresets.Items.AddRange(new object[] {
            "Pixel",
            "Glider (NW)",
            "Glider (NE)",
            "Glider (SW)",
            "Glider (SE)"});
            this.cboPresets.Location = new System.Drawing.Point(11, 177);
            this.cboPresets.Name = "cboPresets";
            this.cboPresets.Size = new System.Drawing.Size(121, 21);
            this.cboPresets.TabIndex = 19;
            // 
            // chkShortcut
            // 
            this.chkShortcut.AutoSize = true;
            this.chkShortcut.Location = new System.Drawing.Point(34, 132);
            this.chkShortcut.Name = "chkShortcut";
            this.chkShortcut.Size = new System.Drawing.Size(112, 17);
            this.chkShortcut.TabIndex = 18;
            this.chkShortcut.Text = "Allow Infinite Loop";
            this.chkShortcut.UseVisualStyleBackColor = true;
            this.chkShortcut.CheckedChanged += new System.EventHandler(this.chkShortcut_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Randomizer Fill %:";
            // 
            // nmbRandom
            // 
            this.nmbRandom.Location = new System.Drawing.Point(107, 74);
            this.nmbRandom.Name = "nmbRandom";
            this.nmbRandom.Size = new System.Drawing.Size(61, 20);
            this.nmbRandom.TabIndex = 16;
            this.nmbRandom.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmbRandom.ValueChanged += new System.EventHandler(this.nmbRandom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "On Click Add A:";
            // 
            // grdLife
            // 
            this.grdLife.AliveColor = System.Drawing.Color.Empty;
            this.grdLife.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdLife.Columns = 0;
            this.grdLife.DeadColor = System.Drawing.Color.Empty;
            this.grdLife.GridLinesVisible = false;
            this.grdLife.GridLineThickness = 0F;
            this.grdLife.Location = new System.Drawing.Point(12, 12);
            this.grdLife.Name = "grdLife";
            this.grdLife.Rows = 0;
            this.grdLife.Size = new System.Drawing.Size(500, 500);
            this.grdLife.TabIndex = 0;
            this.grdLife.TabStop = false;
            // 
            // frmGOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grdLife);
            this.Name = "frmGOL";
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.nmbInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Grid grdLife;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPop;
        private System.Windows.Forms.CheckBox chkLines;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.Button btnDeadColor;
        private System.Windows.Forms.Button btnAliveColor;
        private System.Windows.Forms.NumericUpDown nmbInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbRandom;
        private System.Windows.Forms.CheckBox chkShortcut;
        private System.Windows.Forms.ComboBox cboPresets;
        private System.Windows.Forms.Label label5;
    }
}

