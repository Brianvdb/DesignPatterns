using GalaSoft.MvvmLight;

namespace DPINT_Week4.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 

        public int[] SudokuField
        {
            get
            {
                return sudokuField;
            }
            set
            {
                
            }
        }

        private int[] sudokuField;

        public MainViewModel()
        {
            sudokuField = new int[81];

            sudokuField[0] = 4;
        }
    }
}