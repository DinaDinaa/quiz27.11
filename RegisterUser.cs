using QuizPlatform.Models;
using QuizPlatform.Exceptions;
namespace QuizPlatform.Commands
{
    public class RegisterUser
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public void Validate()
        {

            Name.ValidateName();
            Email.ValidateEmail();
            Password.ValidatePassword();
        }
    }
}
