using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Data;

public class UserRepository
{
    private readonly DatabaseConnection _db = new DatabaseConnection();

    public void AddUser(string name, string sex, string nic, string address, string userType)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"INSERT INTO Users (Name, Sex, NIC, Address, UserType) 
                             VALUES (@Name, @Sex, @NIC, @Address, @UserType)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@NIC", nic);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@UserType", userType);

                cmd.ExecuteNonQuery();
            }
        }
    }

    internal void User(string name, string sex, string nic, string address, string userType)
    {
        throw new NotImplementedException();
    }

    public DataTable GetAllUsers()
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM Users";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable usersTable = new DataTable();
                    adapter.Fill(usersTable);
                    return usersTable;
                }
            }
        }
    }

}
