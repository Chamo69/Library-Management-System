using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Repository class for managing loans and related operations.
/// </summary>
public class LoanRepository
{
    private readonly DatabaseConnection _db = new DatabaseConnection();

    /// <summary>
    /// Checks if the borrower has any overdue books.
    /// </summary>
    /// <param name="userId">User ID of the borrower</param>
    /// <returns>True if there are overdue books, otherwise false</returns>
    public bool HasOverdueBooks(int userId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT COUNT(*) 
                FROM Loans 
                WHERE UserID = @UserID 
                  AND ReturnDate IS NULL 
                  AND DueDate < NOW()";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);

                int overdueCount = Convert.ToInt32(cmd.ExecuteScalar());
                return overdueCount > 0;
            }
        }
    }

    /// <summary>
    /// Checks if the borrower can borrow more books (maximum limit is 5 books).
    /// </summary>
    /// <param name="userId">User ID of the borrower</param>
    /// <returns>True if the borrower can borrow more books, otherwise false</returns>
    public bool CanBorrowMoreBooks(int userId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT COUNT(*) 
                FROM Loans 
                WHERE UserID = @UserID 
                  AND ReturnDate IS NULL";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);

                int borrowedCount = Convert.ToInt32(cmd.ExecuteScalar());
                return borrowedCount < 5;  // Borrowing allowed if less than 5 books
            }
        }
    }

    /// <summary>
    /// Loans a book to the borrower, updating the Loans table.
    /// </summary>
    /// <param name="userId">User ID of the borrower</param>
    /// <param name="copyId">Copy ID of the book</param>
    /// <returns>True if the book was successfully loaned, otherwise false</returns>
    public bool LoanBook(int userId, int copyId)
    {
        if (!IsUserMember(userId))
        {
            return false; // User is not a member, cannot borrow books
        }

        if (!CanBorrowMoreBooks(userId))
        {
            return false;
        }

        if (!IsBookBorrowable(copyId))
        {
            return false;
        }

        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                INSERT INTO Loans (UserID, CopyID, LoanDate, DueDate) 
                VALUES (@UserID, @CopyID, NOW(), DATE_ADD(NOW(), INTERVAL 2 WEEK))";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@CopyID", copyId);

                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }

    /// <summary>
    /// Returns a book, updating the return date in the Loans table.
    /// </summary>
    /// <param name="userId">User ID of the borrower</param>
    /// <param name="copyId">Copy ID of the book</param>
    public void ReturnBook(int userId, int copyId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                UPDATE Loans 
                SET ReturnDate = NOW() 
                WHERE UserID = @UserID 
                  AND CopyID = @CopyID 
                  AND ReturnDate IS NULL";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@CopyID", copyId);

                cmd.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Checks if a specific book copy is borrowable.
    /// </summary>
    /// <param name="copyId">Copy ID of the book</param>
    /// <returns>True if the book copy is borrowable, otherwise false</returns>
    public bool IsBookBorrowable(int copyId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT Status 
                FROM Copies 
                WHERE CopyID = @CopyID";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);

                string status = cmd.ExecuteScalar()?.ToString();
                return status == "Borrowable";
            }
        }
    }

    /// <summary>
    /// Retrieves reservation details for a specific book copy.
    /// </summary>
    /// <param name="copyId">Copy ID of the book</param>
    /// <returns>ReservationDetails object if reserved, otherwise null</returns>
    public ReservationDetails GetReservationDetails(int copyId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
                SELECT UserID, ReservedDate 
                FROM Reservations 
                WHERE CopyID = @CopyID 
                  AND IsFulfilled = 0 
                LIMIT 1";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CopyID", copyId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ReservationDetails
                        {
                            UserID = reader.GetInt32("UserID"),
                            ReservedDate = reader.GetDateTime("ReservedDate")
                        };
                    }
                }
            }
        }

        return null;
    }

    public DataTable GetAllLoans()
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();
            string query = "SELECT LoanID, UserID, CopyID, LoanDate, DueDate, IFNULL(ReturnDate, '0001-01-01') AS ReturnDate FROM Loans";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable loansTable = new DataTable();
                    adapter.Fill(loansTable);
                    return loansTable;
                }
            }
        }
    }

    public List<Book> GetBorrowedBooks(int userId)
    {
        var books = new List<Book>();

        using (var connection = _db.GetConnection())
        {
            connection.Open();

            var query = @"
            SELECT c.CopyID, b.Title 
            FROM Books b 
            JOIN Copies c ON b.BookID = c.BookID 
            JOIN Loans l ON c.CopyID = l.CopyID 
            WHERE l.UserID = @UserID AND l.ReturnDate IS NULL";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            CopyID = reader.GetInt32("CopyID"),
                            Title = reader.GetString("Title")
                        };

                        books.Add(book);
                    }
                }
            }
        }

        return books;
    }

    public bool IsUserMember(int userId)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = @"
            SELECT UserType 
            FROM Users 
            WHERE UserID = @UserID";

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);

                string userType = cmd.ExecuteScalar()?.ToString();
                return userType == "Member";
            }
        }
    }


}

/// <summary>
/// Represents the details of a reservation.
/// </summary>
public class ReservationDetails
{
    public int UserID { get; set; }
    public DateTime ReservedDate { get; set; }
    public int ReservationID { get; internal set; }
}
