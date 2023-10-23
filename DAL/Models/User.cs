using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class User
   {
      public int Id { get; set; }
      public string Email { get; set; }
      public Role Role { get; set; }
      public string LastName { get; set; }
      public string FirstName { get; set; }
      [RegularExpression("/^(((\\+|00)32[ ]?(?:\\(0\\)[ ]?)?)|0){1}(4(60|[789]\\d)\\/?(\\s?\\d{2}\\.?){2}(\\s?\\d{2})|(\\d\\/?\\s?\\d{3}|\\d{2}\\/?\\s?\\d{2})(\\.?\\s?\\d{2}){2})$/")]
      public string GSM { get; set; }
      public string NickName { get; set; }
      public string Allergie { get; set; }
      public string InfoSupp { get; set; }
   }
}
