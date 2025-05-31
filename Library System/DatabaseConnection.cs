using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private const string ConnectionString = "Server=localhost;Database=sarasavilibrary;Uid=root;Pwd=;";

    public static string ConnectionString1 => ConnectionString;

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString1);
    }
}
