
using System.Web.Mvc;
using System.Web.Routing;

namespace Codie.Models
{
    public class UserState : ActionFilterAttribute
    {
        public static AccountModel CurrentUser;
        public static bool Authorized;
        private string _requiredRole;
        public UserState()
        {
            _requiredRole = null;
        }
        public UserState(string requiredRole = "User")
        {
            _requiredRole = requiredRole;
        }
        public static string GetFullName() => $"{CurrentUser.FirstName} {CurrentUser.LastName}";
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Authorized
                && filterContext.ActionDescriptor.ActionName != "Register"
                && filterContext.ActionDescriptor.ActionName != "Login"
                && filterContext.ActionDescriptor.ActionName != "Recovery")
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Register" }));
                return;
            }
            if (CurrentUser != null && CurrentUser.Role != null && _requiredRole != null && CurrentUser.Role != _requiredRole)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index" }));
                return;
            }
        }
    }
}