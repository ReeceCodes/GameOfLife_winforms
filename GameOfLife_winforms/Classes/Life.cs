using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_winforms.Classes
{
    class Life
    {
        #region Properties
        public int Columns
        {
            get { return _columns; }
            set { _columns = value; }
        }

        public int Rows
        {
            get { return _rows; }
            set { _rows = value; }
        }

        public int Cells
        {
            get { return _cells; }
            set { _cells = value; }
        }

        public int LiveCellCount
        {
            get { return _liveCellCount; }
            set { _liveCellCount = value; }
        }

        public bool[] CurrentStates
        {
            get { return _currentStates; }
            set { _currentStates = value; }
        }

        public bool[] NewStates
        {
            get { return _newStates; }
            set { _newStates = value; }
        }

        public bool[] StartStates
        {
            get { return _startStates; }
            set { _startStates = value; }
        }

        //instead of optional rules just use static ones
        public static readonly List<int> SurviveRules = new List<int>() { 2,3 }; //const doesn't work here
        public const int BirthRules = 3; //initially was a list

        #endregion

        #region Members
        private int _columns;
        private int _rows;
        private int _cells;
        private int _liveCellCount;        
        private bool[] _currentStates;
        private bool[] _newStates;
        private bool[] _startStates;
        
        #endregion

        #region Constructors        
        //grid sizes initializer        
        public Life() { }
        //set the columns and rows to the same number
        public Life(int xy)
        {
            //_rows = xy; original code used a lot of the private members instead of properties...why??
            Rows = xy;
            Columns = xy;
            Cells = Rows * Columns;

            ClearGrid();
            StartStates = new bool[Cells];
        }

        //set the columns and rows individually
        public Life(int x, int y)
        {
            Rows = x;
            Columns = y;
        }
        #endregion

        #region Methods

        public void ClearGrid()
        {
            LiveCellCount = 0;
            CurrentStates = new bool[Cells];
            NewStates = new bool[Cells];                       
        }

        public void RandomFill(double percent)
        {
            Random rnd = new Random();
            LiveCellCount = 0;
            for (int i = 0; i < Cells; i++)
            {
                CurrentStates[i] = rnd.NextDouble() <= percent; //set the current value to true/false if the randome is less than the percentage passed (percent is 1/100 to 100/100
                if (CurrentStates[i])
                {
                    LiveCellCount++;
                }
            }
        }

        //sets the grid to a previous state
        public void ResetGrid()
        {
            StartStates.CopyTo(CurrentStates, 0);
        }

        //save state that reset will revert to
        public void SaveGrid()
        {
            CurrentStates.CopyTo(StartStates, 0);
        }

        public void Step()
        {
            AdvancePopulation();
            NewStates.CopyTo(CurrentStates, 0); 
        }

        public bool GetCellState(int x, int y)
        {
            //the value is outside of the available coordinates
            if (y < 0 || y >= Rows || x < 0 || x >= Columns)
            {
                return false;
            }

            return CurrentStates[(x + y) * Columns]; //return the cell's value, this is one of the things I had trouble getting my head around. Getting the correct coordinate value from the value list
        }

        public void ToggleCellState(int x, int y)
        {
            if (!(y < 0 || y >= Rows || x < 0 || x >= Columns))
            {
                //only do something if it's inside the grid
                int index = (x + y) * Columns;
                CurrentStates[index] = !(CurrentStates[index]); //set to the opposite of the currrent value at that index

                //depending on if it was flipped update the count accordingly.
                if (CurrentStates[index])
                {
                    LiveCellCount++;
                }
                else
                {
                    LiveCellCount--;
                }
            }
        }

        //dead = . , alive = * 
        //the original notes say this converts the grid to a string representation. 
        //TODO find the reason it needs an override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    sb.Append(CurrentStates[(x + y) * Columns] ? "*" : ".");
                }
            }

            return sb.ToString();
        }

        private void AdvancePopulation()
        {
            //only do stuff if there was cells
            if (LiveCellCount > 1)
            {
                LiveCellCount = 0;

                int contacts; //number of cells surrounding the current
                int index;
                bool alive;

                for (int y = 0; y < Rows; y++)
                {
                    for (int x = 0; x < Columns; x++)
                    {
                        contacts = GetContacts(x, y);
                        index = (x + y) * Columns;
                        alive = CurrentStates[index];

                        if ((alive && SurviveRules.Contains(contacts)) || (!alive && BirthRules == contacts) )
                        {
                            NewStates[index] = true;
                            LiveCellCount++;
                        }
                        else
                        {
                            NewStates[index] = false;
                        }
                    }
                }
            }
        }

        //this was always the function that I could never wrap my head around
        private int GetContacts(int x, int y)
        {
            //TODO fix this. logic is wrong, getting out of bounds errors
            int ContactCount = 0;

            //have to test each because it could have up to 8 neighbors. probably could find a way to shortcut the number of checks if it's already over the number of birth rules
            //top left
            if ((x > 0 && y > 0) && CurrentStates[(x-1 + y-1) * Columns])
            {
                ContactCount++;
            }
            //top
            if (y > 0 && CurrentStates[(x + y - 1) * Columns])
            {
                ContactCount++;
            }
            //top right
            if (y > 0 && x + 1 < Columns && CurrentStates[(x + y) * Columns])
            {
                ContactCount++;
            }
            //left
            if (x + 1 < Columns && CurrentStates[(x + 1 + y) * Columns])
            {
                ContactCount++;
            }
            //bottom left
            if (x+1 < Columns && y+1 < Rows && CurrentStates[(x+1 + y+1) * Columns])
            {
                ContactCount++;
            }
            //bottom
            if (y+1 < Rows && CurrentStates[(x+y+1) * Columns])
            {
                ContactCount++;
            }
            //bottom right
            if (x>0 && y+1 < Rows && CurrentStates[(x+y) * Columns])
            {
                ContactCount++;
            }
            //right
            if ((x > 0) && CurrentStates[(x - 1 + y) * Columns])
            {
                ContactCount++;
            }

            return ContactCount++;

        }

        #endregion

    }
}
