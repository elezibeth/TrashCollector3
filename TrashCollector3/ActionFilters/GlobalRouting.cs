using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollector3;

namespace TrashCollector3.ActionFilters
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimsPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {

        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
            {
                if (_claimsPrincipal.IsInRole("Customer"))
                {
                    context.Result = new RedirectToActionResult("Index", "Customers", null);
                }
                else if (_claimsPrincipal.IsInRole("Employee"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);
                }
            }
        }
    }

}
