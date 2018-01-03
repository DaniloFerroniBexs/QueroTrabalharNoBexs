
namespace QueroTrabalharNoBexs
{
    public class OlaMundoFactory : IAbstractFactory
    {

        public ISubject createSubject()
        {
            return new OlaMundoSubject();
        }

        public IObserver createObserver()
        {
            return new OlaMundoObserver();
        }

        public ICommand createCommand(ISubject subject)
        {
            return new OlaMundoCommand(subject);
        }
    }
}
