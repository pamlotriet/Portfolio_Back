using Microsoft.AspNetCore.Mvc;

namespace portfolio_back.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class WakeUpController: ControllerBase
    {

        [HttpGet]
        [Route("/wakeUp")]
        public string wakeup()
        {
            return "Service has been woken up";
        }
    }
}
