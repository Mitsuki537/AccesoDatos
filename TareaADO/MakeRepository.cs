using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaADO
{
    public class MakeRepository: IRepository<Make>
    {
        private string _connectionString;

        public MakeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(int id)
        {

            string query = "DELETE FROM Makes WHERE Id = @id";

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error when trying to delete record from db");
            }

        }

        public IEnumerable<Make> GetAll()
        {
            List<Make> makes = new List<Make>();

            string query = "SELECT * FROM Makes";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            makes.Add(
                                new Make()
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    TimeStamp = reader.GetDateTime(2)
                                }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while trying to get data from db" + ex.Message);
            }

            return makes;
        }

        public Make GetById(int id)
        {
            string query = $"SELECT * FROM Makes WHERE Id = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Make make = new Make
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            TimeStamp = reader.GetDateTime(2)
                        };

                        return make;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while trying to get contact from db");
            }

            return null;
        }

        public void Insert(Make make)
        {

            string query = "INSERT INTO Makes(Name, TimeStamp)" +
                $"VALUES (@Name, @TimeStamp)";

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", make.Name);
                    command.Parameters.AddWithValue("@TimeStamp", DateTime.Now);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error when trying to insert record from db");
            }

        }

        public void Update(Make make)
        {
            string query = "UPDATE Makes SET" +
                " Name = @Name, TimeStamp = @TimeStamp WHERE Id = @Id";

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", make.Id);
                    command.Parameters.AddWithValue("@Name", make.Name);
                    command.Parameters.AddWithValue("@TimeStamp", DateTime.Now);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error when trying to update record from db");
            }
        }
    }
}
