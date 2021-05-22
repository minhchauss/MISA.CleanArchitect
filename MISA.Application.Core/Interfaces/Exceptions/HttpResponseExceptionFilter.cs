using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Exceptions
{
    public class HttpResponseExceptionFilter : Microsoft.AspNetCore.Mvc.Filters.IActionFilter, IOrderedFilter
    {
        public int Order { get; } = int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is ValidateException exception)
            {
                var responseCustomer = new
                {
                    userMsg = exception.Message,
                    devMsg = Properties.Resources.Erro_Exception,
                    Data = exception.Data,
                    traceInfor = exception.StackTrace
                };
                context.Result = new ObjectResult(responseCustomer)
                {
                    StatusCode = 400,
                };
                context.ExceptionHandled = true;
            }
            else
            {
                var responseCustomer = new
                {
                    devMsg = context.Exception.Message,
                    // Dùng câu thông báo lỗi trong resource
                    userMsg = Properties.Resources.Erro_Exception,
                    Data = context.Exception.Data,
                    traceInfor = context.Exception.StackTrace
                };
                context.Result = new ObjectResult(responseCustomer)
                {
                    StatusCode = 500,
                };
                context.ExceptionHandled = true;
            }
        }
    }

}
