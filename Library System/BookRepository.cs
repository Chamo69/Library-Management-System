using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public class BookRepository
{
    private readonly DatabaseConnection _db = new DatabaseConnection();

    public void AddBookWithCopies(string classification, string title, string author, string isbn, string publisher, int totalCopies, string copyType)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            var latestBookQuery = "SELECT MAX(BookID) FROM Books WHERE Classification = @Classification";
            using (var latestBookCmd = new MySqlCommand(latestBookQuery, connection))
            {
                latestBookCmd.Parameters.AddWithValue("@Classification", classification);
                var latestBookId = latestBookCmd.ExecuteScalar();

                int bookIdInt = latestBookId == DBNull.Value ? 0 : Convert.ToInt32(latestBookId);

                string bookNumber = $"{classification}{(bookIdInt + 1):D4}";

                var insertBookQuery = "INSERT INTO Books (Classification, Title, Author, ISBN, Publisher, ClassificationCode) " +
                                      "VALUES (@Classification,@Title, @Author, @ISBN, @Publisher,@BookNumber)";

                using (var insertBookCmd = new MySqlCommand(insertBookQuery, connection))
                {
                    insertBookCmd.Parameters.AddWithValue("@Classification", classification);
                    insertBookCmd.Parameters.AddWithValue("@Title", title);
                    insertBookCmd.Parameters.AddWithValue("@Author", author);
                    insertBookCmd.Parameters.AddWithValue("@ISBN", isbn);
                    insertBookCmd.Parameters.AddWithValue("@Publisher", publisher);
                    insertBookCmd.Parameters.AddWithValue("@BookNumber", bookNumber);

                    insertBookCmd.ExecuteNonQuery();
                }

                for (int i = 1; i <= totalCopies; i++)
                {
                    string copyNumber = $"{bookNumber}-{i}";
                    var insertCopyQuery = "INSERT INTO Copies (BookID, CopyNumber, Status) " +
                                          "VALUES ((SELECT BookID FROM Books WHERE ClassificationCode = @BookNumber), @CopyNumber, @Status)";

                    using (var insertCopyCmd = new MySqlCommand(insertCopyQuery, connection))
                    {
                        insertCopyCmd.Parameters.AddWithValue("@BookNumber", bookNumber);
                        insertCopyCmd.Parameters.AddWithValue("@CopyNumber", copyNumber);
                        insertCopyCmd.Parameters.AddWithValue("@Status", copyType);

                        insertCopyCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        MessageBox.Show($"Book '{title}' with {totalCopies} copies added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public List<Book> GetAvailableBooks()
    {
        var books = new List<Book>();

        using (var connection = _db.GetConnection())
        {
            connection.Open();

            var query = "SELECT c.CopyID, b.Title FROM Books b " +
                        "JOIN Copies c ON b.BookID = c.BookID " +
                        "WHERE c.Status = 'Borrowable' AND c.CopyID NOT IN (SELECT CopyID FROM Loans WHERE ReturnDate IS NULL)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            CopyID = reader.IsDBNull(reader.GetOrdinal("CopyID")) ? 0 : reader.GetInt32("CopyID"),  // Handle DBNull
                            Title = reader.IsDBNull(reader.GetOrdinal("Title")) ? "Unknown" : reader.GetString("Title")  // Handle DBNull
                        };

                        books.Add(book);
                    }
                }
            }
        }

        return books;
    }

    public List<Book> GetAvailableTitles()
    {
        var books = new List<Book>();

        using (var connection = _db.GetConnection())
        {
            connection.Open();

            var query = "SELECT DISTINCT b.BookID, b.Title FROM Books b " +
                        "JOIN Copies c ON b.BookID = c.BookID " +
                        "WHERE c.Status = 'Borrowable' AND c.CopyID NOT IN (SELECT CopyID FROM Loans WHERE ReturnDate IS NULL)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            CopyID = reader.IsDBNull(reader.GetOrdinal("BookID")) ? 0 : reader.GetInt32("BookID"),  // Handle DBNull
                            Title = reader.IsDBNull(reader.GetOrdinal("Title")) ? "Unknown" : reader.GetString("Title")  // Handle DBNull
                        };

                        books.Add(book);
                    }
                }
            }
        }

        return books;
    }

    public string GetBookStatus(string searchTerm, string searchType)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = "";

            if (searchType == "ISBN")
            {
                query = "SELECT c.Status FROM Books b JOIN Copies c ON b.BookID = c.BookID WHERE b.ISBN = @SearchTerm";
            }
            else if (searchType == "Title")
            {
                query = "SELECT c.Status FROM Books b JOIN Copies c ON b.BookID = c.BookID WHERE b.Title LIKE @SearchTerm";
            }
            else if (searchType == "Author")
            {
                query = "SELECT c.Status FROM Books b JOIN Copies c ON b.BookID = c.BookID WHERE b.Author LIKE @SearchTerm";
            }

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SearchTerm", searchType == "ISBN" ? searchTerm : $"%{searchTerm}%");

                var result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return "Not Available";
                }

                return result.ToString();
            }
        }
    }

    public DataTable GetAllBooks()
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM Books";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);
                    return booksTable;
                }
            }
        }
    }

    public DataTable GetBookDetails(string searchTerm, string searchType)
    {
        using (var connection = _db.GetConnection())
        {
            connection.Open();

            string query = "";

            if (searchType == "ISBN")
            {
                query = "SELECT * FROM Books WHERE ISBN = @SearchTerm";
            }
            else if (searchType == "Title")
            {
                query = "SELECT * FROM Books WHERE Title LIKE @SearchTerm";
            }
            else if (searchType == "Author")
            {
                query = "SELECT * FROM Books WHERE Author LIKE @SearchTerm";
            }

            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SearchTerm", searchType == "ISBN" ? searchTerm : $"%{searchTerm}%");

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable bookDetailsTable = new DataTable();
                    adapter.Fill(bookDetailsTable);
                    return bookDetailsTable;
                }
            }
        }
    }

}

public class Book
{
    public int CopyID { get; set; }
    public string Title { get; set; }
}
