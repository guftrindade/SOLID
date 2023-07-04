namespace SOLID.SRC
{
    public class Cpf
    {
        public string IdentificationNumber { get; set; }

        public bool Verify()
        {
            //Check Unique identification
            return IdentificationNumber.Length == 11;
        }
    }
}
