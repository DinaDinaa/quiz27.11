using QuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPlatform.Services.Abstractions
{
   public interface IUserRepository
    {

        List<User> GetUsers();
        void AddUser(User user);
    }
}
