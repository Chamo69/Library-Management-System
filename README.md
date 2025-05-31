REPORT 



• **Project Overview **

Sarasavi Library is a well-stocked library with 500\+ books, offering both borrowing and reference services for registered members. The aim of this project is to develop a Library Management System \(LMS\) using C\# .NET \(Windows Forms\) and MySQL, streamlining essential operations like Book Registration, Loan, Return, Reservation, Inquiry, and User Registration. 

This system helps librarians efficiently manage books and users, reducing manual errors while improving the overall experience. 



• **Technologies Used **

▪ **Programming Language:** C\# 7.3 

▪ **Framework:** .NET Framework 4.8 

▪ **Database:** MySQL 

▪ **IDE:** Visual Studio 2022 

▪ **Libraries:** ReaLTaiizor for UI components, MySQL.Data for database connectivity 



• **Features Implemented **

**User Registration: **

▪ Users can register with details such as name, gender, NIC, address, and user type \(Member or Visitor\). 

▪ Only members can borrow books. 

**Book Management: **

▪ Add book records. 

▪ View available copies of books. 

**Loan Management: **

▪ Loan books to users. 

▪ Check if users have overdue books or have reached the maximum limit of borrowed books. 

▪ Ensure only members can borrow books. 

**Return Management: **

▪ Return borrowed books. 

▪ Update the status of returned books and notify users of any reservations. 



**Reservation Management: **

▪ Reserve books for users. 

▪ Manage reservation details and notify users when reserved books are available. 



• **Database Design** 

The database consists of the following tables: 

▪ **Users:** Stores user details including UserID, Name, Sex, NIC, Address, and UserType. 

▪ **Books:** Stores book details including BookID, Title, Author, and ISBN. 

▪ **Copies:** Stores details of book copies including CopyID, BookID, and Status \(Borrowable, Reserved, etc.\). 

▪ **Loans:** Stores loan details including LoanID, UserID, CopyID, LoanDate, DueDate, and ReturnDate. 

▪ **Reservations:** Stores reservation details including ReservationID, UserID, CopyID, ReservedDate, and IsFulfilled. 



• **Challenges and Solutions** 

**Implementing Robust Error Handling and Logging **

▪ **Challenge:** Handling errors gracefully and providing meaningful feedback to users is essential for a good user experience. Additionally, logging errors for debugging and monitoring purposes is crucial for maintaining the system. 

▪ **Solution:** Implement try-catch blocks to handle exceptions and provide user-friendly error messages. Use a logging framework like NLog or log4net to log errors and other important events. Ensure that sensitive information is not exposed in error messages. 

**Database Connectivity **

▪ **Challenge:** Managing database connections and ensuring data integrity. 

▪ **Solution:** Utilized the MySql.Data library for database operations and implemented proper exception handling to manage database connectivity issues. 





• **Screenshots and User Interface** 



**Login Form **

****

▪ **Purpose:** Authenticates users before granting access to the system. 

▪ **Processes:** Validates user credentials against the database, displays error messages for invalid login attempts, and redirects authenticated users to the main dashboard. 

****





**Dashboard **

▪ **Navigation:** Provides buttons to navigate to different forms such as User Registration, Book Registration, Loan Management, Return Management, Reservation Management, and Inquiries. 

▪ **Form Management:** Opens and closes child forms within the main panel, ensuring only one form is active at a time. 

▪ **UI Enhancements:** Includes features like sidebar expansion, drag functionality, and color changes for active panels and buttons. 

▪ **User Actions:** Allows users to log out and exit the application. 





**User Registration Form **

▪ **Purpose:** Allows users to register by providing their details such as name, gender, NIC, address, and user type \(Member or Visitor\). 

▪ **Processes:** Validates user input, saves user details to the database, and ensures that the user type is correctly assigned. 



****

****

****

****

****

****





**Book Registration Form **

▪ **Purpose:** Allows administrators to add new books to the library's collection. 

▪ **Processes:** Collects book details such as title, author, and ISBN, and saves them to the database. Also manages the status of book copies. 





****

****

****

****

****

****

****

**Loan Management Form **

▪ **Purpose:** Manages the process of loaning books to users. 

▪ **Processes:** Checks if the user is a member, verifies if the user has overdue books, ensures the user has not exceeded the maximum limit of borrowed books, and processes the book loan. 



****

****

****

****

****

****

****

****

****

****





**Return Process Form **

▪ **Purpose:** Handles the return of borrowed books. 

▪ **Processes:** Updates the return date in the database, checks for any reservations on the returned book, and notifies users if the book is reserved 





****

****

****

****

****

****

****

**Reservation Process Form **

▪ **Purpose:** Manages the reservation of books by users. 

▪ **Processes:** Allows users to reserve books, updates reservation details in the database, and notifies users when reserved books become available. 





****

****

****

****

****

****

****

****

****

****



**Inquiries Form **

▪ **Purpose:** Provides a way for users to inquire about available books and their details. 

▪ **Processes:** Searches the database for books based on user input and displays the results, including availability status. 





• **Conclusion** 

The Library Management System provides a comprehensive solution for managing library operations, including user registration, book loans, returns, and reservations. By leveraging C\# and .NET Framework, the system ensures a robust and efficient way to handle library resources. 

Key functionalities like user type validation, overdue book checks, and automatic reservation notifications enhance the system’s reliability and user experience. The implementation of a structured database with efficient queries ensures faster processing and accurate record-keeping. 



**Benefits of the System: **

▪ Automates manual processes, reducing workload on librarians 

▪ Improves book tracking & reduces errors 

▪ Faster inquiry system to check book availability



