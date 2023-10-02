using Microsoft.Extensions.Logging;

namespace DesignPatterns
{
    public class Factory
    {
        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();

        //public static object Return(string type)
        //{
        //    switch(type)
        //    {
        //        case "success":
        //            return new SuccessResponseHandler().Handle();

        //        case "error":
        //            return new ErrorResponseHandler().Handle();

        //        default:
        //            return new SuccessResponseHandler().Handle();
        //    }
        //}

        public static IWebhookHandler PaymentHandler(string type)
        {
            switch(type)
            {
                case "RazorPay":
                    return new RazonrPayResponseHandler(_loggerFactory.CreateLogger<RazonrPayResponseHandler>());
                case "PayU":
                    return new PayUResponseHandler(_loggerFactory.CreateLogger<PayUResponseHandler>());
                default :
                    return new RazonrPayResponseHandler(_loggerFactory.CreateLogger<RazonrPayResponseHandler>());
            }
        }
    }

    //internal class SuccessResponseHandler : HttpResponseMessage
    //{
    //    public object Handle()
    //    {
    //        return new
    //        {
    //            status = 200,
    //            message = "Operation executed successfully"
    //        };
    //    }
    //}

    //internal class ErrorResponseHandler
    //{
    //    public object Handle()
    //    {
    //        return new
    //        {
    //            status = 500,
    //            message = "Something went wrong"
    //        };
    //    }
    //}



    public interface IWebhookHandler
    {
        string FormatString(string a, string b);
    }

    public class PayUResponseHandler : IWebhookHandler
    {
        private readonly ILogger<PayUResponseHandler> _logger;

        public PayUResponseHandler(ILogger<PayUResponseHandler> logger)
        {
            _logger = logger;
        }

        public string FormatString(string a, string b)
        {
            return "PayU";
        }
    }

    public class RazonrPayResponseHandler : IWebhookHandler
    {
        private readonly ILogger<RazonrPayResponseHandler> _logger;

        public RazonrPayResponseHandler(ILogger<RazonrPayResponseHandler> logger)
        {
            _logger = logger;
        }

        public string FormatString(string a, string b)
        {
            return "Razor";
        }
    }
}
