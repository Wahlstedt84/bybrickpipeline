using Microsoft.AspNetCore.Mvc;

namespace bybrickpipeline2.Controllers;

[Route("[controller]")]
public class HackController : ControllerBase
{
	[HttpGet(Name = "Hack")]
	public ActionResult GetHack()
	{
		return Ok("Hack the planet!");
	}
}