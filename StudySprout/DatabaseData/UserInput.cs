public class UserInput
{
    public int Id { get; set; } // Primary Key
    public string InputData { get; set; } // The user input data
    public string FirebaseId { get; set; } // Optional: Firebase record ID
}

/*
Key Points:
Id: This is the primary key for the table. It will be auto-incremented by MySQL.

InputData: This property stores the actual user input.

FirebaseId: (Optional) If you're syncing Firebase and MySQL, this field can store Firebase's record ID to create a link between the two systems.
*/