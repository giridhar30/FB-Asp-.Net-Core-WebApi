namespace FbBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImg { get; set; }
        public bool Active { get; set; }
        public int Mutual { get; set; }
    }
}
