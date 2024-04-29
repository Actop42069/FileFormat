using JSON_data.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JSON_data.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TaskController : Controller
	{
		private IWebHostEnvironment _env;
		private FileSaver _fileSaver;	

		public TaskController(IWebHostEnvironment env, FileSaver fileSaver)
		{
			_env = env;
			_fileSaver = new FileSaver(_env);	
		}


		[HttpPost("Upload")]
		public async Task<IActionResult> uploadFile([FromForm] IFormFile file)
		{
			try
			{
				//calling file saver function
				_fileSaver.FileSaveAsync(file, "assets/image");
				return Ok("You have uploaded your file successfully");
			}
			catch(Exception ex)
			{
				return Problem(ex.Message);
			}
		}
	}
}
