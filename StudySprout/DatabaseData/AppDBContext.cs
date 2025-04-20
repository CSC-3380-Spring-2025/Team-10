using Microsoft.EntityFrameworkCore;

public class AppDBContext : DbContext
{
    // Define a DbSet for the UserInput table
    public DbSet<UserInput> UserInputs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection (adjust server, database, username, and password)
        optionsBuilder.UseMySql(
            "Server=your-server;Database=your-database;User=your-username;Password=your-password;",
            new MySqlServerVersion(new Version(8, 0, 27)) // Example MySQL version
        );
    }
}

/*
Replace "your-server" "your-database" "your-username" "your-password"
DbSet<UserInput> -> maps UserInput model to DB table
*/