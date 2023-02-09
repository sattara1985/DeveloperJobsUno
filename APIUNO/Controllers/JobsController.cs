using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIUNO.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class JobsController: ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            return  Ok("Hola mundo steven");
        }
    }
}
