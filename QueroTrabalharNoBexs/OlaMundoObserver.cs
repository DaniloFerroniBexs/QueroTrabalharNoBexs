using System;

namespace QueroTrabalharNoBexs
{
    public class OlaMundoObserver : IObserver
    {

        public void update(ISubject subject)
        {
            OlaMundoSubject sub = (OlaMundoSubject)subject;
            Console.WriteLine(sub.getStr());
        }
    }
}
