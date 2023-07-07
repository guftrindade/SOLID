namespace SOLID.DIP.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
