#pragma checksum "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d929661f64f06009e1a347ac6e8ed07f9a186f8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dumble_Edit), @"mvc.1.0.view", @"/Views/Dumble/Edit.cshtml")]
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
#line 1 "D:\New folder\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d929661f64f06009e1a347ac6e8ed07f9a186f8f", @"/Views/Dumble/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Dumble_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Dumble>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
  
    Layout=null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(" <input type=\"hidden\"  id=\"id\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 177, "\"", 194, 1);
#nullable restore
#line 8 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 185, Model.id, 185, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"">
           
            </div>
            <div class=""col-sm-4"">
                <div class=""form-group"">
                    <label for=""name"">Product Name</label>
                    <input autocomplete=""off"" type=""text"" class=""form-control"" id=""name"" name=""pd_name""");
            BeginWriteAttribute("value", " value=\"", 566, "\"", 588, 1);
#nullable restore
#line 17 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 574, Model.pd_name, 574, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"price\">Product Price</label>\r\n                    <input autocomplete=\"off\" type=\"text\" class=\"form-control\" id=\"price\" name=\"pd_price\"");
            BeginWriteAttribute("value", " value=\"", 826, "\"", 849, 1);
#nullable restore
#line 21 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 834, Model.pd_price, 834, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"supplier\">Supplier</label>\r\n                    <input autocomplete=\"off\" type=\"text\" class=\"form-control\" id=\"supplier\" name=\"pd_supplier\"");
            BeginWriteAttribute("value", " value=\"", 1090, "\"", 1116, 1);
#nullable restore
#line 25 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 1098, Model.pd_supplier, 1098, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"date\">Date</label>\r\n                    <input autocomplete=\"off\" type=\"text\" class=\"form-control\" id=\"date\" name=\"pd_date\"");
            BeginWriteAttribute("value", " value=\"", 1341, "\"", 1363, 1);
#nullable restore
#line 29 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 1349, Model.pd_date, 1349, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"color\">Color</label>\r\n                    <input autocomplete=\"off\" type=\"text\" class=\"form-control\" id=\"color\" name=\"pd_color\"");
            BeginWriteAttribute("value", " value=\"", 1592, "\"", 1615, 1);
#nullable restore
#line 33 "D:\New folder\MvcMovie\Views\Dumble\Edit.cshtml"
WriteAttributeValue("", 1600, Model.pd_color, 1600, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Dumble> Html { get; private set; }
    }
}
#pragma warning restore 1591
