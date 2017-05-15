using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_winforms.User_Controls
{
    public partial class Grid : UserControl
    {
        #region Properties
        [DefaultValue(typeof(Color), "Black")] //couldn't use the ?? operator for this
        public Color AliveColor
        {
            get
            {
                return _aliveColor;
            }
            set
            { //TODO fix? invalidate is not working. the paint is called on the first run but never repaints even though it hits invalidate.
                //tried with Refresh to no effect
                _aliveColor = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "White")] //couldn't use the ?? operator for this
        public Color DeadColor
        {
            get
            {
                return _deadColor;
            }
            set
            {
                _deadColor = value;
                Invalidate();
            }
        }

        [DefaultValue(100)]
        public int Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
                CreateGrid();
            }
        }

        [DefaultValue(100)]
        public int Columns
        {
            get
            {
                return _columns;
            }
            set
            {
                _columns = value;
                CreateGrid();
            }
        }

        [DefaultValue(true)]
        public bool GridLinesVisible
        {
            get
            {
                return _gridLinesVisible;
            }
            set
            {
                _gridLinesVisible = value;
                Invalidate();
            }
        }

        [DefaultValue(1)]
        public float GridLineThickness
        {
            get
            {
                return _gridLineThickness;
            }
            set
            {
                _gridLineThickness = value;
                Invalidate();
            }
        }

        #endregion

        #region Members
        private bool[] _gridStates = new bool[100 * 100];
        private bool _gridLinesVisible;
        private float _gridLineThickness;
        private int _rows;
        private int _columns;
        private Color _aliveColor;
        private Color _deadColor;

        #endregion
        public Grid() : this(100, 100, Color.Black, Color.White) { }
        public Grid(int x, int y, Color ac, Color dc)
        {
            InitializeComponent();

            DoubleBuffered = true;
            TabStop = false;


            Rows = x;
            Columns = y;
            AliveColor = ac; //haha
            DeadColor = dc;

            this.Paint += new PaintEventHandler(Grid_Paint);
        }
        #region Constructors

        #endregion

        #region Public Methods
        public void UpdateGrid(bool[] gridStates)
        {
            if (gridStates.Length == _gridStates.Length)
            {
                gridStates.CopyTo(_gridStates, 0);
                Invalidate();
            }
            else
            {
                //throw an error!?
            }
        }

        private void CreateGrid()
        {
            _gridStates = new bool[Columns * Rows];
            Invalidate();
        }

        #endregion

        #region Events
        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            float CellWidth = (float)Width / Columns;
            float CellHeight = (float)Height / Rows;
            float line = 0;
            if (GridLinesVisible)
            {
                line = GridLineThickness;
            }

            Graphics painter = e.Graphics;
            SolidBrush AliveBrush = new SolidBrush(AliveColor);
            SolidBrush DeadBrush = new SolidBrush(DeadColor);
            //these variables are from the form. was confused where they came from
            painter.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    if (_gridStates[x + (y * Columns)]) //had the grouping backwards
                    {
                        painter.FillRectangle(AliveBrush, x * CellWidth, y * CellHeight, CellWidth - line, CellHeight - line);
                    }
                    else
                    {
                        painter.FillRectangle(DeadBrush, x * CellWidth, y * CellHeight, CellWidth - line, CellHeight - line);
                    }
                }
            }

        }
        #endregion

    }
}
