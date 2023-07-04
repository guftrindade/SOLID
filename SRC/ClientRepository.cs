using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRC
{
    public class ClientRepository
    {
        public void AddClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.Cpf);
                cmd.Parameters.AddWithValue("dataCad", client.CreatedDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
