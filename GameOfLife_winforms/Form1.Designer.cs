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
            this.grdLife = new GameOfLife_winforms.User_Controls.Grid();
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
            this.btnRandom.Text = "Random Generate";
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
            this.chkLines.Location = new System.Drawing.Point(535, 495);
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
            this.btnDeadColor.Location = new System.Drawing.Point(625, 413);
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
            this.btnAliveColor.Location = new System.Drawing.Point(535, 413);
            this.btnAliveColor.Name = "btnAliveColor";
            this.btnAliveColor.Size = new System.Drawing.Size(75, 23);
            this.btnAliveColor.TabIndex = 13;
            this.btnAliveColor.Text = "Alive Color";
            this.btnAliveColor.UseVisualStyleBackColor = false;
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
            // 
            // frmGOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 662);
            this.Controls.Add(this.btnAliveColor);
            this.Controls.Add(this.btnDeadColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.chkLines);
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
    }
}

