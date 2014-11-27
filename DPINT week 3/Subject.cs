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
            observers.ForEach(ob => ob.Update(this));
        }

        public void Attach(Observer observer){
            observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract void SetState(object o);

        public abstract object GetState();
    }
}
