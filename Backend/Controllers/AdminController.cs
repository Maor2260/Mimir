using System.Globalization;
using ApiFacade.AdminFacade;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("API/[controller]")]
public class AdminController : ControllerBase, IAdminFacade
{

    [HttpGet]
    [Route("GetServerTime")]
    public ActionResult<string> GetServerTime()
    {
        return Ok(DateTime.Now.ToString(CultureInfo.CurrentCulture));
    }
}