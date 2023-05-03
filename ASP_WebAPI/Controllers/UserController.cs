using ASP_WebAPI.Design_Patterns;
using ASP_WebAPI.Entity_Framework;
using ASP_WebAPI.Language_Features;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ASP_WebAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class UserController : ControllerBase
    {
        private readonly DatabaseConnection _context;

        public delegate void CallbackDelegate(int x);


        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, DatabaseConnection context)
        {
            _logger = logger;
            _context = context;
        }

        //[HttpGet()]
        //[Route("/")]
        //public IEnumerable<User> EntityFramework()
        //{
        //    _logger.LogInformation("CODE EXUECTION STARTS");
        //    var users = _context.User.ToList();

        //    return users;
        //}

        //[HttpGet()]
        //[Route("/")]
        //public async Task<List<string>> AsyncAwait()
        //{
        //    return await new AsyncAwait(_context).GetWebsites();
        //}

        //[HttpGet()]
        //[Route("/")]
        //public object BoxUnbox()
        //{
        //    var boxUnboxObject = new BoxAndUnbox();
        //    return new
        //    {
        //        boxed = boxUnboxObject.BoxValue(),
        //        unboxed = boxUnboxObject.UnboxValue()
        //    };
        //}

        //[HttpGet()]
        //[Route("/")]
        //public IEnumerable Chaining()
        //{
        //    var chainObject = new Chaining().AddName().AddAge();

        //    return chainObject.list;
        //}

        //[HttpGet()]
        //[Route("/")]
        //public object FactoryPattern()
        //{
        //    return new JsonResult(Factory.Return("success"));
        //}

        //[HttpGet()]
        //[Filter]
        //[Route("/")]
        //public object SingletonPattern()
        //{
        //    Sample((x) =>
        //    {
        //        Console.WriteLine("VALUE::" + x);
        //    });
        //    var instance = Singleton.Instance;
        //    return instance.Cache();
        //}

        //private void Sample(CallbackDelegate del)
        //{
        //    del(2);
        //}

        [HttpGet()]
        [Route("/")]
        public object FactoryPatternWithLogger()
        {
            "sin".ExtensionMethods(1,2);
            return Factory.PaymentHandler("RazorPay").FormatString("s", "g") ;
        }

    }


    public static class Extensions
    {
        public static string ExtensionMethods(this string input, int min, int max)
        {
            return input.Substring(1, 2);
        }
    }

}