using SudokuBasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week4.ViewModel
{
    public class ViewLocation
    {
        private SudokuGame game;
        private Position position;

        public ViewLocation(SudokuGame game, Position position)
        {
            this.game = game;
            this.position = position;
        }
        public short Value
        {
            get
            {
                return this.position.Value;
            }
            set
            {
                this.position.Value = value;
                this.game.SetValue(position);
                Console.WriteLine("change, valid input: " + this.game.IsValid());
            }
        }
    }
}
