using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;


//C:\Users\name\AppData\Roaming\Microsoft\UserSecrets

namespace secretManagerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Index()
        {
           var kullanici = _configuration["MailBilgileri:KullaniciAdi"];
           var sifre = _configuration["MailBilgileri:Sifre"];



            var connection = _configuration.GetConnectionString("SQL");
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connection);
            sqlConnectionStringBuilder.UserID = _configuration["SQL:KullaniciAdi"];
            sqlConnectionStringBuilder.Password = _configuration["SQL:Sifre"];

            var x = sqlConnectionStringBuilder.ConnectionString;

        }
    }
}
