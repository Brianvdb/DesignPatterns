using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DPINT_Week_3_XAML
{
    class ScreenViewer : INotifyPropertyChanged
    {
        BigScreen bigScreen = new BigScreen();
        SmallScreen smallScreen = new SmallScreen();
        Reclame reclame = new Reclame();
        public string Screen1
        {
            get
            {
                return smallScreen.Text;
            }
            set{
                smallScreen.Text = value;
            }
        }
        public string Screen2
        {
            get
            {
                return bigScreen.Text;
            }
            set
            {
               bigScreen.Text = value;
            }
        }




        public ScreenViewer()
        {

            

           Thread myThread = new System.Threading.Thread(new
            System.Threading.ThreadStart(Reclamebord));

           myThread.Start();

            reclame.Attach(bigScreen);
            reclame.Attach(smallScreen);

        }

        public void Reclamebord()
        {
            reclame.SetState("Mac Donalds");
            reclame.Notify();

            Thread.Sleep(5000);

            reclame.SetState("Burger King");
            reclame.Notify();
            #region
            RaisePropertyChanged("Screen2");
            RaisePropertyChanged("Screen1");
            #endregion
        }

        #region INotifyPropertyChanged Members


        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
