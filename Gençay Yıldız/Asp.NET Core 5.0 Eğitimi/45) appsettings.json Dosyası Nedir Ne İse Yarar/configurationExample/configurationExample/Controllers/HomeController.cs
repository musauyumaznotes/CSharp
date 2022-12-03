using configurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace configurationExample.Controllers
{
    public class HomeController : Controller
    {
        MailInfo _mailInfo;
        IConfiguration _configuration;
        //public HomeController(IConfiguration configuration mailInfo)
        public HomeController(IOptions<MailInfo> mailInfo)
        {
            _mailInfo = mailInfo.Value;
            //_configuration = configuration;
        }

        public IActionResult Index()
        {
            //string host = _configuration["MailInfo.Host"];
            //string port = _configuration["MailInfo.Port"];

            //MailInfo mailInfo = _configuration.GetSection("MailInfo").Get<MailInfo>();
            
            return View();
        }

        public IActionResult Privacy()
        {
            //var v1 = _configuration["OrnekMetin"];
            //var v2 = _configuration["Person"];
            //var v3 = _configuration["Person:Name"];
            //var v4 = _configuration["Person:Surname"];
            //var v5 = _configuration["Logging:LogLevel:Microsoft.Hosting.Lifetime"];



            //var v6 = _configuration.GetSection("Person");
            //var v7 = _configuration.GetSection("Person:Name");

            //var v8 = _configuration.GetSection("Person").Get(typeof(Person));

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
