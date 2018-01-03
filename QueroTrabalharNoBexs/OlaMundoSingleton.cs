
namespace QueroTrabalharNoBexs
{
    public class OlaMundoSingleton
    {
        private static OlaMundoSingleton _instance;
        private IAbstractFactory factory = new OlaMundoFactory();

        public static OlaMundoSingleton GetInstance()
        {
            return _instance;
        }

        public IAbstractFactory GetFactory()
        {
            return factory;
        }
    }
}
