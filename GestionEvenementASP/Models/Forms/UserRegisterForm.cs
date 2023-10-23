using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionEvenementASP.Models.Forms
{
   public class UserRegisterForm
   {
      [Required]
      [EmailAddress]
      public string Email { get; set; }
      [Required]
      [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")]
      [DataType(DataType.Password)]
      public string Password { get; set; }
      [Compare(nameof(Password), ErrorMessage = "Les Mots de passe ne sont pas identiques")]
      [DataType(DataType.Password)]
      public string PasswordConfirmation { get; set; }
      [Required]
      public string LastName { get; set; }
      [Required]
      public string FirstName { get; set; }
   }
}
