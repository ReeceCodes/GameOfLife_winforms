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
            {
                _aliveColor = value;
                Invalidate(); //never heard of that one before. sounds useful
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
                Invalidate(); //never heard of that one before. sounds useful
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

        public Grid()
        {
            InitializeComponent();
        }

        public Grid(int x, int y, Color AliveColor, Color DeadColor)
        {
            InitializeComponent();
        }
    }
}
