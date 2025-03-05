using Microsoft.AspNetCore.Mvc;

namespace bybrickpipeline2.Controllers;

[Route("[controller]")]
public class HackController : ControllerBase
{
	[HttpGet(Name = "Hack")]
	public ActionResult GetHack()
	{
		var hackText = Environment.GetEnvironmentVariable("hacktheplanet");
		return Ok(hackText);
	}
}