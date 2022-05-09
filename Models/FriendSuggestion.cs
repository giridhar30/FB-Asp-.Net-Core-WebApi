namespace FbBackend.Models
{
    public class FriendSuggestion
    {
        public FriendSuggestion()
        {

        }
        public int Id { get; set; }
        public string Accept { get; set; }
        public string Education { get; set; }

        public string Friends_name { get; set; }
        public string Friends_url { get; set; }

        public string Image_url { get; set; }
        public string Mutual_friends { get; set; }
        public string Name { get; set; }
        public string Work { get; set; }
    }
}
