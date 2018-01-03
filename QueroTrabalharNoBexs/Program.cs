using System;

namespace QueroTrabalharNoBexs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = OlaMundoSingleton.GetInstance().GetFactory();
            var subject = factory.createSubject();
            subject.attach(factory.createObserver());
            var command = factory.createCommand(subject);
            command.execute();

            Console.Read();
        }
    }
}
