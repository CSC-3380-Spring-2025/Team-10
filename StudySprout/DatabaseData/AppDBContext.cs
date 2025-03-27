using Microsoft.EntityFrameworkCore;

public class AppDBContext : DBContext
{
    // Define a DbSet for the UserInput table
    public DBSet<UserInput> UserInputs { get; set; }

    protected override void OnConfiguring(DBContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection (adjust server, database, username, and password)
        optionsBuilder.UseMySql(
            "Server=your-server;Database=your-database;User=your-username;Password=your-password;",
            new MySqlServerVersion(new Version(8, 0, 27)) // Example MySQL version
        );
    }
}

/*

Replace "your-server", "your-database", "your-username", and "your-password" with your actual MySQL server details.

The DbSet<UserInput> is used to map your UserInput model to a database table.

*/