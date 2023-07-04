namespace SOLID.SRC
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime CreatedDate { get; set; }

        public bool Verify()
        {
            return Email.Verify() && Cpf.Verify();
        }
    }
}
