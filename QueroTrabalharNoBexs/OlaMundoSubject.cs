using System.Collections.Generic;

namespace QueroTrabalharNoBexs
{
    public class OlaMundoSubject : ISubject
    {
        private List<IObserver> observers;
        private string _str;

        public OlaMundoSubject()
        {
            observers = new List<IObserver>();
        }

        public void attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void deatch(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (var o in observers)
            {
                o.update(this);
            }
        }

        public string getStr()
        {
            return _str;
        }

        public void setStr(string value)
        {
            notifyObservers();
        }
    }

}
