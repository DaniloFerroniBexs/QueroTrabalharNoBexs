
namespace QueroTrabalharNoBexs
{
    public class OlaMundoCommand : ICommand
    {
        private OlaMundoSubject _subject;
        private const string Mensagem = "";

        public OlaMundoCommand(ISubject subject)
        {
            _subject = (OlaMundoSubject)subject;
        }

        public void execute()
        {
            _subject.setStr(Mensagem);
        }
    }

}
