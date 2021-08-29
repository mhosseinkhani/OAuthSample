using AuthorizationCodeFlow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationCodeFlow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AuthorizationServerHttpClient _authorizationServerHttpClient;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _authorizationServerHttpClient = new AuthorizationServerHttpClient(new HttpClient());
        }

        public IActionResult Index()
        {
            string redirectUri = Url.ActionLink(nameof(Privacy), "Home", null, Request.Scheme);
            string responseType = "code";
            string clientId = ConstData.AuthorizationCodeFlowClientId;
            string scope = "read-homework";

            var url = new StringBuilder()
    .Append("https://localhost:5001/connect/authorize?")
    .Append("response_type=" + responseType)
    .Append("&client_id=" + clientId)
    .Append("&redirect_uri=" + redirectUri)
    .Append("&scope=" + scope)
    .ToString();

            return Redirect(url);

        }

        public async Task<IActionResult> Privacy(string code, string state)
        {
            string redirectUri = Url.ActionLink(nameof(GetToken), "Home", null, Request.Scheme);
            TokenResponse tokenResponseDto = await _authorizationServerHttpClient.GetToken(code, redirectUri);
            return Json(tokenResponseDto);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> GetToken(string code, string state)
        {
            string redirectUri = Url.ActionLink(nameof(GetToken), "Home", null, Request.Scheme);
            TokenResponse tokenResponseDto = await _authorizationServerHttpClient.GetToken(code, redirectUri);
            return Json(tokenResponseDto);
        }
    }

}
