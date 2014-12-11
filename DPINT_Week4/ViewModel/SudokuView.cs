using SudokuBasis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week4.ViewModel
{
    class SudokuView : INotifyPropertyChanged
    {
        private SudokuGame sudoku;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SudokuView()
        {
            this.sudoku = new SudokuGame();
            this.sudoku.NewGame();

            for (int i = 0; i < 81; i++)
            {

                Position p = new Position() {
                    X = (short) ((i / 9) + 1),
                    Y = (short) ((i % 9) + 1)
                };
                this.sudoku.GetValue(p);
                SudokuField[i] = p.Value;
            }
        }

        public int[] SudokuField
        {
            get
            {
                return sudokuField;
            }
            set
            {
                sudokuField = value;
                this.OnPropertyChanged("SudokuField");
            }
        }

        private int[] sudokuField = new int[81];
    }
}
