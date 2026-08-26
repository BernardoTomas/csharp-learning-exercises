using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace configuringConsoleLogger.Filters;
public class MyActionFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Antes");
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("Depois");
    }
}