using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Signalr.Services;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace Signalr
{
    /// <summary>
    ///  [Authorize]:需要身份验证才能访问这个方法
    /// </summary>
    //[Authorize]
    public class CountHub : Hub
    {
        private readonly CoutService _coutService;

        public CountHub(CoutService coutService)
        {
            _coutService = coutService;
        }
        /// <summary>
        /// 客户端请求服务端方法体
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public async Task GetLatestCount(string random)
        {
            //获取去客户端用户信息
            //var user = Context.User.Identity.Name; 

            int count=0;
            do
            {
                count++; //_coutService.GetLatestCount();
                Thread.Sleep(1000);

                await Clients.All.SendAsync("ReceiveUpdate", count);

            } while (count < 10);
            await Clients.All.SendAsync("Finished", count);
        }
        /// <summary>
        /// 服务端请求客服端方法体
        /// </summary>
        /// <returns></returns>
        public override async Task OnConnectedAsync()
        {
            //获取请求服务端的客户端ID
            var connectionId = Context.ConnectionId;
            var client = Clients.Client(connectionId);


            //请求客户端名为Test_1的方法，并传递参数
            await client.SendAsync("Test_1", new { data="后台自动调用"});
            //AllExcept(connectionId):除了id为connectionId的客户端，调用其他的客户端的方法
            await Clients.AllExcept(connectionId).SendAsync("Test_1", new { });


            //把客户端添加到一个分组里
            await Groups.AddToGroupAsync(connectionId, "MyGroup");
            //把客户端从一个分组里移出
            await Groups.RemoveFromGroupAsync(connectionId, "MyGroup");

            //请求某个组客户端的someFunc方法
            await Clients.Groups("MyGroup").SendAsync("Test_1");

        }

    }
}
