#pragma checksum "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb2497fc2e40312f812e390360e515a6ebfa8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TodoItems_Index), @"mvc.1.0.view", @"/Views/TodoItems/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb2497fc2e40312f812e390360e515a6ebfa8e6", @"/Views/TodoItems/Index.cshtml")]
    public class Views_TodoItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<XuanHoang.Models.TodoItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
       Layout = "_Layout"; ViewBag.Title = "All TodoItem";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <nav class=""breadcrumb"">
                <a class=""breadcrumb-item"" href=""#"">Manager</a>
                <span class=""breadcrumb-item active"">TotoItem</span>
            </nav>
            <h2>All TodoItem</h2>
    <a href=""/todoitems/addtodoitem"" class=""btn btn-sm btn-primary"">Add TodoItem</a>
    <a href=""/todoitems/gettodoitem"" class=""btn btn-sm btn-secondary"">Get TodoItem</a>
     
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>IsComplete</th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
                   Write(r.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
                   Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
                   Write(r.IsComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a type=\"submit\"");
            BeginWriteAttribute("href", " href=\"", 1154, "\"", 1192, 2);
            WriteAttributeValue("", 1161, "/todoitems/updatetodoitem/", 1161, 26, true);
#nullable restore
#line 31 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
WriteAttributeValue("", 1187, r.Id, 1187, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1193, "\"", 1213, 1);
#nullable restore
#line 31 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
WriteAttributeValue("", 1208, r.Id, 1208, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: green; color: white; border: 2px;\">Update</a>\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <form action=\"/todoitems/deletetodoitem\" method=\"get\">\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1728, "\"", 1741, 1);
#nullable restore
#line 39 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
WriteAttributeValue("", 1736, r.Id, 1736, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"TodoItemId\" />\r\n                            <input type=\"submit\" value=\"Delete\" style=\"background-color: red; color: white; border: 2px;c\"/>\r\n                        </form>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "D:\DoAnChuyenNganh\API\XuanHoang\Views\TodoItems\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n        </div>\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<XuanHoang.Models.TodoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591