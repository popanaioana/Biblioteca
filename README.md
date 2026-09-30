# \# Biblioteca

# 

# A desktop library management application developed in C# using Windows Forms and Microsoft SQL Server.

# 

# The application provides separate interfaces for administrators and library users, allowing books, users, and borrowing operations to be managed through a graphical interface.

# 

# \## Features

# 

# \### Administrator

# \- View the library's book collection

# \- Add new books

# \- Register new users

# \- Assign books to users

# \- Process book returns

# \- Track book availability and borrowing information

# 

# \### User

# \- Log in using registered credentials

# \- View currently borrowed book information

# \- Check book availability by title and author

# \- View the remaining time until a borrowed book must be returned

# 

# \## Technologies

# 

# \- C#

# \- .NET Framework 4.7.2

# \- Windows Forms

# \- Microsoft SQL Server

# \- ADO.NET

# \- SQL stored procedures

# \- Visual Studio

# 

# \## Database

# 

# The application uses a SQL Server database named `BibliotecaDB`.

# 

# The repository includes a `database.sql` script that creates the database structure, stored procedures, and sample data required to run the application.

# 

# The database stores information about:

# 

# \- Books

# \- Library users

# \- Book availability

# \- Borrowing and return dates

# 

# \## Database Setup

# 

# 1\. Open `database.sql` in SQL Server Management Studio.

# 2\. Execute the script to create and populate `BibliotecaDB`.

# 3\. Update the connection string in `App.config` if your SQL Server instance is different.

# 

# Example:

# 

# ```xml

# <connectionStrings>

# &#x20;   <add name="BibliotecaDB"

# &#x20;        connectionString="Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Integrated Security=True;"

# &#x20;        providerName="System.Data.SqlClient" />

# </connectionStrings>

# ```

# 

# \## Running the Application

# 

# 1\. Clone the repository.

# 2\. Set up the database using `database.sql`.

# 3\. Open the solution in Visual Studio.

# 4\. Verify the database connection string in `App.config`.

# 5\. Build and run the application.

# 

# \## Project Structure

# 

# \- `AdminForm` – manages books, users, borrowing, and returns

# \- `PersoanaForm` – displays user and borrowed-book information

# \- `LoginForm` – provides access to the user and administrator login interfaces

# \- `AdminFormLogin` – handles administrator authentication

# \- `PersoanaFormLogin` – handles user authentication

# \- `database.sql` – creates and populates the SQL Server database

# 

# \## Author

# 

# Ana Pop

