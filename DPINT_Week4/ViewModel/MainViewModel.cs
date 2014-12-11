using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SudokuBasis;
using System;
using System.Collections.ObjectModel;

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
        private SudokuGame sudoku;

        public ObservableCollection<ViewLocation> Locations { get; set; }

        public RelayCommand NewGameCommand { get; private set; }


        public MainViewModel()
        {
            Locations = new ObservableCollection<ViewLocation>();
            this.sudoku = new SudokuGame();

            this.sudoku.NewGame();

            for (int i = 0; i < 81; i++)
            {

                Position p = new Position()
                {
                    X = (short)((i / 9) + 1),
                    Y = (short)((i % 9) + 1)
                };
                this.sudoku.GetValue(p);
                Locations.Add(new ViewLocation(sudoku, p));
            }

            NewGameCommand = new RelayCommand(NewGame, DummyTrue);
        }

        public bool DummyTrue()
        {
            return true;
        }

        public void NewGame()
        {
            this.sudoku.NewGame();

            for (int i = 0; i < 81; i++)
            {

                Position p = new Position()
                {
                    X = (short)((i / 9) + 1),
                    Y = (short)((i % 9) + 1)
                };
                this.sudoku.GetValue(p);
                Locations[i].Value = p.Value;
            }
        }
    }
}