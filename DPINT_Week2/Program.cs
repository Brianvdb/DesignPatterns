﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPINT_Week2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Clown clown = new Linkeroog(new Rechteroog(new ClownKaal()));
            clown.Actie();*/

            bool[] baChoice = new bool[] { true, true, true, true, false, false, false, false, false, false, false };

            Controller controller = new Controller(baChoice);
            controller.Go();
        }
    }
}
