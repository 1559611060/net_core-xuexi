using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Signalr.Services
{
    /// <summary>
    /// 注入方法
    /// Startup 添加服务时使用
    /// </summary>
    public class CoutService
    {
        private int _count;
        public int GetLatestCount()
        {
            return _count++;
        }
    }
}
