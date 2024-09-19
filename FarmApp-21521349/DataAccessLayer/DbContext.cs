using System.Data.SqlClient;

namespace FarmApp.DataAccessLayer
{
    public class DbContext
    {
        private string connectionString = "Server=DESKTOP-OOEM27J;Database=FarmApp;Trusted_Connection=true";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
