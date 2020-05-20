using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.Pages
{
    /// <summary>
    /// HtmlTargetElement:特性，它本质是一个类
    /// pager 指定 tag 的名字，Attributes指定 tag 里面可以包含的属性
    /// </summary>
    [HtmlTargetElement("pager",Attributes = "pageIndex,path")]
    //必须继承自 TagHelper
    public class PagerTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";//html 原生标签名

            //设置a标签里的属性 eg:href
            object pageIndex = context.AllAttributes["pageIndex"].Value;//去特性里面（HtmlTargetElement）定义的属性
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href",$"/{path}/{pageIndex}");
        }
    }
}
