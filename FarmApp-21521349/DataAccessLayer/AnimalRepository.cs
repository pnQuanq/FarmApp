using System.Collections.Generic;
using System.Data.SqlClient;
using FarmApp_21521349.Models;

namespace FarmApp.DataAccessLayer
{
    public class AnimalRepository
    {
        private DbContext _context;

        public AnimalRepository()
        {
            _context = new DbContext();
        }

        // Thêm gia súc vào CSDL
        public void AddAnimal(Animal animal)
        {
            string query = "INSERT INTO Animals (Type, Quantity, TotalMilk, TotalBirths) VALUES (@Type, @Quantity, @TotalMilk, @TotalBirths)";

            using (SqlConnection connection = _context.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Type", animal.Type);
                command.Parameters.AddWithValue("@Quantity", animal.Quantity);
                command.Parameters.AddWithValue("@TotalMilk", animal.TotalMilk);
                command.Parameters.AddWithValue("@TotalBirths", animal.TotalBirths);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Lấy danh sách gia súc từ CSDL
        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            string query = "SELECT * FROM Animals";

            using (SqlConnection connection = _context.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animal animal = new Animal
                    {
                        Id = (int)reader["Id"],
                        Type = reader["Type"].ToString(),
                        Quantity = (int)reader["Quantity"],
                        TotalMilk = (int)reader["TotalMilk"],
                        TotalBirths = (int)reader["TotalBirths"]
                    };

                    animals.Add(animal);
                }
            }

            return animals;
        }

        // Cập nhật thông tin sữa và số lần sinh
        public void UpdateAnimalStats(string type, int totalMilk, int totalBirths)
        {
            string query = "UPDATE Animals SET TotalMilk = TotalMilk + @TotalMilk, TotalBirths = TotalBirths + @TotalBirths WHERE Type = @Type";

            using (SqlConnection connection = _context.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TotalMilk", totalMilk);
                command.Parameters.AddWithValue("@TotalBirths", totalBirths);
                command.Parameters.AddWithValue("@Type", type);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
