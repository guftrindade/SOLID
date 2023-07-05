namespace SOLID.ISP.Interfaces
{
    public interface IRegisterClient : IRegister
    {
        void VerifyData();
        void SendEmail();
    }
}
