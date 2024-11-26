using DocumentFormat.OpenXml.Spreadsheet;
using QuizPlatform.Models;
using QuizPlatform.Services.Abstractions;
using QuizPlatform.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizPlatform.Commands;

namespace QuizPlatform.Services.Implementations
{
    public class UserRepository : IUserRepository
    {  
        public UserRepository(int count)
        {
            _users = Enumerable.Range(1, count).Select(ind =>
                                   new User
                                   {
                                       UserId = ind,
                                       Name = "User" + ind,
                                       UserName = $"email{ind}@gmail.com",
                                       Password = (ind + 1000).ToString() ,
                                   }).ToList();
        }

        private readonly List<User> _users;

        public void AddUser(User user)
        {
            UserValidation._existingEmails = _users.Select(user => user.UserName).ToList();
            RegisterUser.Validate(user);
           _users.Add(user);
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.UserId == id);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
