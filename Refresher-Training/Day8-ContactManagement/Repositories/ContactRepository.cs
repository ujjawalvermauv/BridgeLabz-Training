using Microsoft.Data.SqlClient;
using Day8_ContactManagement.Models;

namespace Day8_ContactManagement.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly string connectionString;

        public ContactRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();

            using SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Id, name, phone FROM Contacts";

            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                contacts.Add(new Contact
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    name = reader["name"].ToString(),
                    phone = reader["phone"].ToString()
                });
            }

            return contacts;
        }

        public Contact GetById(int id)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Id, name, phone FROM Contacts WHERE Id = @Id";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Contact
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    name = reader["name"].ToString(),
                    phone = reader["phone"].ToString()
                };
            }

            return null;
        }

        public void Add(Contact contact)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = """
                INSERT INTO Contacts (name, phone)
                VALUES (@Name, @Phone)
                """;

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", contact.name);
            command.Parameters.AddWithValue("@Phone", contact.phone);

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Update(Contact contact)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = """
                UPDATE Contacts
                SET name = @Name,
                    phone = @Phone
                WHERE Id = @Id
                """;

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", contact.Id);
            command.Parameters.AddWithValue("@Name", contact.name);
            command.Parameters.AddWithValue("@Phone", contact.phone);

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = "DELETE FROM Contacts WHERE Id = @Id";

            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}