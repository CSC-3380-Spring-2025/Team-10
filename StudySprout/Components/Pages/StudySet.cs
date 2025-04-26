using Google.Cloud.Firestore;

namespace StudySprout.Models
{
    [FirestoreData]
    public class StudySet
    {
        [FirestoreProperty("Title")]
        public string Title { get; set; }

        [FirestoreProperty("Description")]
        public string Description { get; set; }

        public StudySet() { }
    }
}