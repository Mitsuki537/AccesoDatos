using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaADO
{
    public class PetRepository: IRepository<Pet>
    {
        private string _connectionString;

        public PetRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(int id)
        {

            string query = "DELETE FROM Inventory WHERE Id = @id";

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

        public IEnumerable<Pet> GetAll()
        {
            List<Pet> pets = new List<Pet>();

            string query = "SELECT * FROM Inventory";

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
                            pets.Add(
                                new Pet()
                                {
                                    Id = reader.GetInt32(0),
                                    MakeId = reader.GetInt32(1),
                                    Color = reader.GetString(2),
                                    PetName = reader.GetString(3),
                                    TimeStamp = reader.GetDateTime(4)
                                }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while trying to get inventory from db" + ex.Message);
            }

            return pets;
        }

        public Pet GetById(int id)
        {
            string query = $"SELECT * FROM Inventory WHERE Id = @id";

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
                        Pet Pet = new Pet
                        {
                            Id = reader.GetInt32(0),
                            MakeId = reader.GetInt32(1),
                            Color = reader.GetString(2),
                            PetName = reader.GetString(3),
                            TimeStamp = reader.GetDateTime(4)
                        };

                        return Pet;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while trying to get Pet from db");
            }

            return null;
        }

        public void Insert(Pet Pet)
        {

            string query = "INSERT INTO Inventory(MakeId, Color, PetName, TimeStamp)" +
                $"VALUES (@MakeId, @Color, @PetName, @TimeStamp)";

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@MakeId", Pet.MakeId);
                    command.Parameters.AddWithValue("Color", Pet.Color);
                    command.Parameters.AddWithValue("@PetName", Pet.PetName);
                    command.Parameters.AddWithValue("@TimeStamp", DateTime.Now);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error when trying to insert record from db");
            }

        }

        public void Update(Pet Pet)
        {
            string query = "UPDATE Inventory SET" +
                " MakeId = @MakeId, Color = @Color, PetName = @PetName, TimeStamp = @TimeStamp WHERE Id = @Id";

            try
            {

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", Pet.Id);
                    command.Parameters.AddWithValue("@MakeId", Pet.MakeId);
                    command.Parameters.AddWithValue("Color", Pet.Color);
                    command.Parameters.AddWithValue("@PetName", Pet.PetName);
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
