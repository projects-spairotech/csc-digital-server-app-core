using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using csc_digital_server_app.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace csc_digital_server_app.Controllers.User
{
	[ApiController]
	[Authorize]
	[Route("api/[controller]")]
	[Consumes("application/json")]
	[Produces("application/json")]
	public class AuthController : ControllerBase
	{
		/*public IActionResult Index()
		{
			return View();
		}*/

		private readonly IAuthenticationService _authenticationService;
		private readonly AppSettings _appSettings;
		private readonly ILogger _logger;

		public AuthController(IAuthenticationService authenticationService,IOptions<AppSettings> appSettings,ILoggerFactory factory)
		{
			_authenticationService=authenticationService;
			_appSettings=appSettings.Value;
			_logger=factory.CreateLogger("AuthController");
		}
	}
}
