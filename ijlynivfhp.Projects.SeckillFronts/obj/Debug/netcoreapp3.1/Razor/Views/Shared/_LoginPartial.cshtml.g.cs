#pragma checksum "E:\Project\WEBService\ijlynivfhp.Projects.SeckillFronts\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2b3c9c05a8557243e507a2a6e1f66c4675f731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Project\WEBService\ijlynivfhp.Projects.SeckillFronts\Views\_ViewImports.cshtml"
using ijlynivfhp.Projects.SeckillFronts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\WEBService\ijlynivfhp.Projects.SeckillFronts\Views\_ViewImports.cshtml"
using ijlynivfhp.Projects.SeckillFronts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2b3c9c05a8557243e507a2a6e1f66c4675f731", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b3d6eb0b4071044daa9ed8829984f7a88a555f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- 已登录 -->
<ul class=""navbar-nav"" style=""display:none"" id=""useLogin"">
    <li class=""nav-item"">
        <a id=""manage"" class=""nav-link text-dark"" title=""Manage""></a>
    </li>
    <li class=""nav-item"">
        <button id=""logout"" type=""button"" class=""nav-link btn btn-link text-dark"" onclick=""logout()"">注销</button>
    </li>
</ul>

<!-- 未登录 -->
<ul class=""navbar-nav"" id=""noneLogin"">
    <li class=""nav-item"" id=""userbox"">
        <button class=""nav-link btn btn-link text-dark"" type=""button"" id=""register"" onclick=""loginBox()"">登录</button>
    </li>
    <li class=""nav-item"" id=""userbox"">
        <button class=""nav-link btn btn-link text-dark"" type=""button"" id=""login"" onclick=""registryBox()"">注册</button>
    </li>
</ul>

<!-- 登录弹框 -->
<div id=""loginbox"">
    <div class=""loginitem""><input type=""text"" placeholder=""请输入用户名"" id=""username""></div>
    <div class=""loginitem""><input type=""password"" placeholder=""请输入密码"" id=""pwd""></div>
    <div class=""loginitem""><a href=""javascript:;"" onclick=""userLo");
            WriteLiteral(@"gin()"">登陆</a></div>
</div>

<!-- 注册弹框 -->
<div id=""regbox"">
    <div class=""loginitem""><input type=""text"" placeholder=""请输入用户名"" id=""r_username""></div>
    <div class=""loginitem""><input type=""password"" placeholder=""请输入密码"" id=""r_pwd""></div>
    <div class=""loginitem""><input type=""text"" placeholder=""请输入QQ"" id=""r_qq""></div>
    <div class=""loginitem""><input type=""text"" placeholder=""请输入手机号"" id=""r_tel""></div>
    <div class=""loginitem""><a href=""javascript:;"" onclick=""regLogin()"">注册</a></div>
</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
