using Google.Cloud.Firestore;
using Microsoft.VisualBasic;

namespace StudySprout.Models
{
    [FirestoreData]
    public class StudySet
    {
        [FirestoreProperty("TITLE")]
        public string TITLE { get; set; }

        [FirestoreProperty("DESCRIPTION")]
        public string DESCRIPTION { get; set; }

        [FirestoreProperty("LEARN BY")]
        public DateTime LEARNBY { get; set; }

        public void SetData(string t, string d, DateTime l)
        {
            TITLE = t;
            DESCRIPTION = d;
            LEARNBY = l;
        }
        public void Clear()
        {
            TITLE = string.Empty;
            DESCRIPTION = string.Empty;
            LEARNBY = DateTime.Now.AddDays(7);
        }
        }
}