using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Signalr.Controllers
{
    /// <summary>
    ///  [Route("api/count")]:路由
    /// </summary>
    [Route("api/count")]
    public class CountController:Controller
    {
        private readonly IHubContext<CountHub> _countHub;

        public CountController(IHubContext<CountHub> countHub) {
            _countHub = countHub;
        }

        public async Task<IActionResult> Post() {
            await _countHub.Clients.All.SendAsync("someFunc",new {random="abcd" });
            return Accepted(1);
        }
    }
}
