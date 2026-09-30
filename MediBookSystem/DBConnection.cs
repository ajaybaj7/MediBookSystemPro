using MySql.Data.MySqlClient;

namespace MediBookSystem
{
	internal class DBConnection
	{
		public static MySqlConnection GetConnection()
		{
			string connectionString =
				"server=localhost;database=medibookdb;uid=root;pwd=;";

			MySqlConnection conn =
				new MySqlConnection(connectionString);

			return conn;
		}
	}
}