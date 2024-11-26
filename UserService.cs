using QuizPlatform.Commands;
using QuizPlatform.Models;
using QuizPlatform.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPlatform.Services.Implementations
{
    public class UserService : IUserService
    {

        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(RegisterUser command)
        {
            command.Validate();

            var user = new User
            {
                Name = command.Name,
                Password = command.Password,
                UserName = command.Email
            };

            _userRepository.AddUser(user);

        }
    }
}
