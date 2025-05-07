using Google.Cloud.Firestore;

public class FlashcardBase
{
    private FirestoreDb StudySproutDB;

    public FlashcardBase(FirestoreDb firestoreDb)
    {
        firestoreDb = firestoreDb ?? throw new ArgumentNullException(nameof(firestoreDb));
    }

    public class Flashcardset
    {
        public string? term { get; set; }
        public string? definition { get; set; }
        public string? ownerID { get; set; }
        public string? studySetID { get; set; }
    }
}


