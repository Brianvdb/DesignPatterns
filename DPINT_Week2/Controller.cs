using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPINT_Week2
{
    public class Controller
    {
        private View view;
        private Task task;
        private bool[] baChoice;

        public Controller(bool[] baChoice)
        {
            this.baChoice = baChoice;
            view = new View();
            task = new Task();
        }

        public void Go()
        {
            task.Go(baChoice);
        }
    }
}
