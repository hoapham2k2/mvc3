#pragma checksum "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930036b88dd67bbb11aa59c9158ffc66b739c3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NVBT_ViewNVBT), @"mvc.1.0.view", @"/Views/NVBT/ViewNVBT.cshtml")]
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
#line 1 "D:\Workspace\dotnet\mvc3\Views\_ViewImports.cshtml"
using mvc3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\dotnet\mvc3\Views\_ViewImports.cshtml"
using mvc3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930036b88dd67bbb11aa59c9158ffc66b739c3fb", @"/Views/NVBT/ViewNVBT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5a679b2af042243dfc4f2dfb47640321db6d7a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_NVBT_ViewNVBT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc3.Models.NVBT>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>this is my view</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "930036b88dd67bbb11aa59c9158ffc66b739c3fb3509", async() => {
                WriteLiteral("\r\n    Ma Thiet Bi : <input type=\"text\" name=\"MaThietBi\"");
                BeginWriteAttribute("value", " value=\"", 179, "\"", 203, 1);
#nullable restore
#line 6 "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml"
WriteAttributeValue("", 187, Model.MaThietBi, 187, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    Ma Can Ho : <input type=\"text\" name=\"MaCanHo\"");
                BeginWriteAttribute("id", " id=\"", 258, "\"", 263, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 264, "\"", 286, 1);
#nullable restore
#line 7 "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml"
WriteAttributeValue("", 272, Model.MaCanHo, 272, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    Lan Thu : <input type=\"text\" name=\"LanThu\"");
                BeginWriteAttribute("value", " value=\"", 337, "\"", 358, 1);
#nullable restore
#line 8 "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml"
WriteAttributeValue("", 345, Model.LanThu, 345, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    Ngay Sua: <input type=\"datetime\" name=\"NgayBaoTri\"");
                BeginWriteAttribute("value", " value=\"", 417, "\"", 442, 1);
#nullable restore
#line 9 "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml"
WriteAttributeValue("", 425, Model.NgayBaoTri, 425, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n    <input type=\"submit\" value=\"submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 69, "UpdateNVBT?manhanvien=", 69, 22, true);
#nullable restore
#line 5 "D:\Workspace\dotnet\mvc3\Views\NVBT\ViewNVBT.cshtml"
AddHtmlAttributeValue("", 91, Model.MaNhanVien, 91, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc3.Models.NVBT> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
