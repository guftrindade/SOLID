namespace SOLID.SRC
{
    public static class ClientService
    {
        public static string AddClient(Client cliente)
        {
            //Check
            if (!cliente.Verify())
                return "Erro";

            //Save in database
            var repo = new ClientRepository();
            repo.AddClient(cliente);

            //Send e-mail
            EmailService.Send("empresa@empresa.com", cliente.Email.EmailAddress, "Welcome", "Congratulations");

            return "Client registred!";

        }
    }
}
