namespace QuizPlatform.Models
{
    public class User
    {
        public User() { }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User (string name, string email, string password, int id)
        {
            Name = name;
            UserName = email;
            Password = password;
            UserId = id;
        }
    }
}
