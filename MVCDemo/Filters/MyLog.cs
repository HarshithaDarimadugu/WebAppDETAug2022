using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Filters
{
    public class MyLog : ActionFilterAttribute
    {


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(
                $"- {nameof(MyLog)}.{nameof(OnActionExecuting)}");

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(
                $"- {nameof(MyLog)}.{nameof(OnActionExecuted)}");

            base.OnActionExecuted(context);
        }
        //public IActionResult Index()
        //{
        //    Console.WriteLine(
        //        $"- {nameof(MyLog)}.{nameof(Index)}");

        //    return MyLog("Check the Console.");
        //}



    }
}

