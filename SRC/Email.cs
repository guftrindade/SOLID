namespace SOLID.SRC
{
    public class Email
    {
        public string EmailAddress { get; set; }

        public bool Verify()
        {
            //Check emailAddress
            return EmailAddress.Contains("@");
        }
    }
}
