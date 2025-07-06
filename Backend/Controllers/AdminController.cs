using System.Globalization;
using ApiFacade.AdminFacade;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("API/[controller]")]
public class AdminController : ControllerBase, IAdminFacade
{

    [HttpGet]
    [Route("ServerTime")]
    public ActionResult<string> GetServerTime()
    {
        return DateTime.Now.ToString(CultureInfo.CurrentCulture);
    }
}