#pragma checksum "/Users/tetsu/Projects/samples_hatena/samples_hatena/Views/Shared/_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84ead3d9331829fe171f8bc8b6ba39a40621fbc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideBar), @"mvc.1.0.view", @"/Views/Shared/_SideBar.cshtml")]
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
#line 1 "/Users/tetsu/Projects/samples_hatena/samples_hatena/Views/_ViewImports.cshtml"
using samples_hatena;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tetsu/Projects/samples_hatena/samples_hatena/Views/_ViewImports.cshtml"
using samples_hatena.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ead3d9331829fe171f8bc8b6ba39a40621fbc2", @"/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8007c32f0f815ae1588b6cbf30730e2d37da484", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/tetsu/Projects/samples_hatena/samples_hatena/Views/Shared/_SideBar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>

.container {
  width: 1000px;
  display: -webkit-flex;
  display: flex;
}
.main {
  display: block;
  width: 660px;
  margin-right: 20px;
}
.sidebar {
  width: 320px;
}
.sidebar__item {
  margin-bottom: 20px;
}
.sidebar__item--fixed {
  position: sticky;
  margin-bottom: 0;
  top: 10px;
  z-index: 1;
}

</style>

<div class=""container"">
    <main class=""main"">
        <!-- メインコンテンツ -->
    </main>
    <div class=""sidebar"">
        <div class=""sidebar__item"">
            <!-- 中身 -->
        </div>
        <div class=""sidebar__item sidebar__item--fixed"">
            <!-- 固定・追従させたいエリア -->
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
