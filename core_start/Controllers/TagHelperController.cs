using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.Controllers
{
    /// <summary>
    /// 自定义 TageHelper 相关功能
    /// </summary>
    public class TagHelperController: Controller
    {
        public IActionResult  Index() {

            return View();
        }
    }
}
