using GameOfLife_winforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_winforms
{
    public partial class frmGOL : Form
    {
        #region Members
        private Life _lifeGame;
        private Timer _timer;

        #endregion

        #region Properties
        public double Probability { get; set; }
        public int GridSize { get; set; }
        public int StepNumber { get; set; }
        public bool InfiniteLoops { get; set; }

        #endregion

        #region Methods
        private void UpdateFormVisuals()
        {
            lblGen.Text = StepNumber.ToString();
            lblPop.Text = _lifeGame.LiveCellCount.ToString();

            grdLife.UpdateGrid(_lifeGame.CurrentStates);

            if (InfiniteLoops == false && _lifeGame.LastStates.Count == 10)
            {
                if (_lifeGame.ShortStop)
                {
                    //the game is in an infinite loop. stop it
                    _timer.Stop();
                    _lifeGame.LastStates.Clear();
                    MessageBox.Show("Ending because it will continue repeating as it is forever!");
                }
            }
        }
        #endregion

        #region Events
        public frmGOL()
        {
            InitializeComponent();

            cboPresets.SelectedIndex = 0;

            Probability = 0.25;
            GridSize = 250;
            StepNumber = 0;
            _lifeGame = new Life(GridSize);
            _timer = new Timer();

            //the defaults never worked in the user control code. 
            grdLife.Columns = GridSize;
            grdLife.Rows = GridSize;
            grdLife.AliveColor = Color.Black;
            grdLife.DeadColor = Color.White;
            grdLife.GridLinesVisible = chkLines.Checked;
            grdLife.GridLineThickness = 1; 

            _timer.Enabled = false;
            _timer.Interval = 1;

            //do I really need to define every event handler manually? Maybe that was a style choice. 
            _timer.Tick += new EventHandler(_timer_Tick);
            btnStart.Click += new EventHandler(btnStart_Click);
            btnStop.Click += new EventHandler(btnStop_Click);
            btnReset.Click += new EventHandler(btnReset_Click);
            btnStep.Click += new EventHandler(btnStep_Click);
            btnClear.Click += new EventHandler(btnClear_Click);
            btnRandom.Click += new EventHandler(btnRandom_Click);
            btnAliveColor.Click += new EventHandler(btnAliveColor_Click);
            btnDeadColor.Click += new EventHandler(btnDeadColor_Click);
            chkLines.CheckedChanged += new EventHandler(chkLines_CheckChanged);
            chkShortcut.CheckedChanged += new EventHandler(chkShortcut_CheckedChanged);
            nmbInterval.ValueChanged += new EventHandler(nmbInterval_ValueChanged);
            grdLife.MouseDown += new MouseEventHandler(Grid_MouseDown);
            nmbRandom.ValueChanged += new EventHandler(nmbRandom_ValueChanged);            
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _lifeGame.SaveGrid(); //added so that I could compare the last 3 states to make sure they changed
            _lifeGame.Step();
            StepNumber++;

            //original had code to update the visuals evvery 6th step. 
            UpdateFormVisuals();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _lifeGame.SaveGrid();
            _timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            UpdateFormVisuals();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.Step();
            StepNumber++;
            UpdateFormVisuals();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.ResetGrid();
            StepNumber = 0;
            UpdateFormVisuals();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.ClearGrid();
            StepNumber = 0;
            UpdateFormVisuals();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            _lifeGame.RandomFill(Probability);
            StepNumber = 0;
            UpdateFormVisuals();
        }

        private void btnAliveColor_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = clrDialog.ShowDialog();

            if (colorResult != DialogResult.Cancel && colorResult == DialogResult.OK)
            {
                btnAliveColor.BackColor = clrDialog.Color;

                int r = clrDialog.Color.R;
                int g = clrDialog.Color.G;
                int b = clrDialog.Color.B;

                btnAliveColor.ForeColor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                grdLife.AliveColor = clrDialog.Color;
            }
        }

        private void btnDeadColor_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = clrDialog.ShowDialog();

            if (colorResult != DialogResult.Cancel && colorResult == DialogResult.OK)
            {
                btnDeadColor.BackColor = clrDialog.Color;

                int r = clrDialog.Color.R;
                int g = clrDialog.Color.G;
                int b = clrDialog.Color.B;

                btnDeadColor.ForeColor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                grdLife.DeadColor = clrDialog.Color;
            }
        }

        private void chkLines_CheckChanged(object sender, EventArgs e)
        {
            grdLife.GridLinesVisible = chkLines.Checked;
            UpdateFormVisuals();
        }

        private void nmbInterval_ValueChanged(object sender, EventArgs e)
        {
            _timer.Interval = (int)nmbInterval.Value;
            UpdateFormVisuals();
        }

        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            int y = (int)(((float)e.Y) * grdLife.Rows / grdLife.Height);
            int x = (int)(((float)e.X) * grdLife.Columns / grdLife.Width);

            switch (cboPresets.SelectedItem.ToString())
            {
                case "Pixel":
                    _lifeGame.ToggleCellState(x, y);
                    break;              
                case "Glider (NE)":
                    _lifeGame.AddGlider(x, y, "ne", Width, Height);
                    break;
                case "Glider (NW)":
                    _lifeGame.AddGlider(x, y, "nw", Width, Height);
                    break;              
                case "Glider (SE)":
                    _lifeGame.AddGlider(x, y, "se", Width, Height);
                    break;
                case "Glider (SW)":
                    _lifeGame.AddGlider(x, y, "sw", Width, Height);
                    break;
                default:
                    _lifeGame.ToggleCellState(x, y);
                    break;
            }

            
            UpdateFormVisuals();
        }

        private void nmbRandom_ValueChanged(object sender, EventArgs e)
        {
            Probability = (double)nmbRandom.Value / 100;
        }

        private void chkShortcut_CheckedChanged(object sender, EventArgs e)
        {
            InfiniteLoops = chkShortcut.Checked;
        }
                
        #endregion


    }
}
