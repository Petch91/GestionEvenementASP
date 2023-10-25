using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   public interface IUserService
   {
      string Login(string email, string pwd);
      bool Register(string email, string pwd, string lastname, string firstname);
      User GetById(int id);
      IEnumerable<User> GetUsers(string token);

      bool SetRole(int idUser, int idRole, string token);
      void Update(User user, string token);
   }
}
