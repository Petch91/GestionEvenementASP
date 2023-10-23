using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GestionEvenementASP.Tools
{
   public class AdminRequiredAttribute : TypeFilterAttribute
   {
      public AdminRequiredAttribute() : base(typeof(AdminRequiredFilter))
      {
      }
   }

   public class AdminRequiredFilter : IAuthorizationFilter
   {
      private readonly SessionManager _session;
      public AdminRequiredFilter(SessionManager session)
      {
         _session = session;
      }
      public void OnAuthorization(AuthorizationFilterContext context)
      {
         if (_session.ConnectedUser is null || _session.ConnectedUser.Role.Name != "Admin")
         {
            context.Result = new RedirectToRouteResult(new { action = "NotFound", Controller = "Home" });
         }
      }
   }
}
