
namespace QueroTrabalharNoBexs
{
    public interface IAbstractFactory
    {
        ISubject createSubject();
        IObserver createObserver();
        ICommand createCommand(ISubject subject);

    }
}
