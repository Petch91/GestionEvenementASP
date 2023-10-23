using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionEvenementASP.Models.Forms
{
   public class UserLoginForm
   {
      [Required]
      [EmailAddress]
      public string Email { get; set; }
      [Required]
      [DataType(DataType.Password)]
      public string Password { get; set; }
   }
}
