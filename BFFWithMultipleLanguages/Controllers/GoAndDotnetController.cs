using Microsoft.AspNetCore.Mvc;

namespace BFFWithMultipleLanguages.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoAndDotnetController : ControllerBase
    {
        private readonly RpcClient _rpcClient;

        public GoAndDotnetController(RpcClient rpcClient)
        {
            _rpcClient = rpcClient;
        }

        [HttpGet]
        public async Task<IActionResult> ProcessTask()
        {
            var rpcClient = new RpcClient();
            await rpcClient.StartAsync();

            var response = await rpcClient.CallAsync();

            return Ok(response);
        }
    }
}

