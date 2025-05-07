using Google.Cloud.Firestore;

[FirestoreData]
public class set1
{
    public set1() { }
    
    [FirestoreProperty("setTitle")]
    public string setTitle { get; set; }

    [FirestoreProperty("description")]
    public string description { get; set; }

    [FirestoreProperty("learnBy")]
    public DateTime learnBy { get; set; }

    public void SetSet(string t, string d, DateTime l)
    {
        setTitle = t;
        description = d;
        learnBy = l;
    }

    public void Clear()
    {
        setTitle = string.Empty;
        description = string.Empty;
    }
}