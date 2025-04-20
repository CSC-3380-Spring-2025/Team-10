using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;

public class FirebaseService
{
    private readonly FirebaseClient _client;

    public FirebaseService()
    {
        _client = new FirebaseClient("https://studysprout-67ec9-default-rtdb.firebaseio.com/");
    }

    public async Task AddStudySet(string title, string description, DateTime dueDate)
    {
        await _client.Child("studySets").PostAsync(new
        {
            Title = title,
            Description = description,
            DueDate = dueDate
        });
    }
}
