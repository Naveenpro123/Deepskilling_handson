using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;
namespace FirstWebApi.CustomAuthFilt
{
    

    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            File.WriteAllText("exception_log.txt", $"[{DateTime.Now}] {ex.Message}\n{ex.StackTrace}");

            context.Result = new ObjectResult("An unexpected error occurred. Check logs.")
            {
                StatusCode = 500
            };
        }
    }
}
