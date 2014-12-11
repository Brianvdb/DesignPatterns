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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
