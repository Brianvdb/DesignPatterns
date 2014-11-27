using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_week_3
{
    public abstract class Subject
    {
        private List<Observer> observers;

        public Subject(){
            observers = new List<Observer>();
        }
        public void Notify()
        {
            observers.ForEach(ob => ob.Update());
        }

        public void Attach(Observer observer){
            observers.Add(observer);
        }

        public void Detatch(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract Object setState(Object o);

        public abstract Object getState();
    }
}
