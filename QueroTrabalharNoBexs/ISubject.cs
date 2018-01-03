
namespace QueroTrabalharNoBexs
{
    public interface ISubject
    {
        void attach(IObserver observer);

        void deatch(IObserver observer);

        void notifyObservers();
    }
}
