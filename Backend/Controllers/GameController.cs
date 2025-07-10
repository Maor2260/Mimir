using ApiFacade.GameFacade;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("API/[controller]")]
public class GameController : ControllerBase, IGameFacade
{
    
}