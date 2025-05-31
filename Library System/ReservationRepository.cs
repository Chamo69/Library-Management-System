using System;
using System.Data;
using MySql.Data.MySqlClient;
using SarasaviLibrary.Models;

public class ReservationRepository
{
    private readonly DatabaseConnection _db = new DatabaseConnection();

    public void ReserveBook(int userId, int bookId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT COUNT(*) FROM Copies 
                WHERE BookID = @BookID AND Status = 'Borrowable' AND CopyID NOT IN (SELECT CopyID FROM Loans WHERE ReturnDate IS NULL)";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);

                int availableCopies = Convert.ToInt32(cmd.ExecuteScalar());

                if (availableCopies == 0)
                {
                    throw new Exception("No available copies for reservation.");
                }

                string insertQuery = @"
                    INSERT INTO Reservations (CopyID, UserID, ReservedDate, IsFulfilled) 
                    SELECT CopyID, @UserID, NOW(), 0 
                    FROM Copies 
                    WHERE BookID = @BookID AND Status = 'Borrowable' 
                    LIMIT 1";

                using (var insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@BookID", bookId);
                    insertCmd.Parameters.AddWithValue("@UserID", userId);

                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }

    public ReservationDetails GetOldestReservation(int bookId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT r.ReservationID, r.UserID, r.ReservedDate 
                FROM Reservations r 
                JOIN Copies c ON r.CopyID = c.CopyID 
                WHERE c.BookID = @BookID AND r.IsFulfilled = 0 
                ORDER BY r.ReservedDate ASC 
                LIMIT 1";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@BookID", bookId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ReservationDetails
                        {
                            ReservationID = reader.GetInt32("ReservationID"),
                            UserID = reader.GetInt32("UserID"),
                            ReservedDate = reader.GetDateTime("ReservedDate")
                        };
                    }
                }
            }
        }

        return null;
    }

    public void DeleteReservation(int reservationId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetAllReservations()
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();
            string query = "SELECT ReservationID, CopyID, UserID, ReservedDate, IFNULL(IsFulfilled, 0) AS IsFulfilled FROM Reservations";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable reservationsTable = new DataTable();
                    adapter.Fill(reservationsTable);
                    return reservationsTable;
                }
            }
        }
    }

}
