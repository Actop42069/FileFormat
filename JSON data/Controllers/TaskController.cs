using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JSON_data.Controllers
{
	public class TaskController : Controller
	{
		[HttpPost("Upload")]
		public async Task<IActionResult> uploadFile([FromForm] IFormFile file)
		{
			try
			{
				return Ok("You have uploaded your file successfully");
			}
			catch(Exception ex)
			{
				return Problem(ex.Message);
			}
		}
	}
}
