#pragma checksum "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452e19978b721011ab434a712be11316dd06ad56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452e19978b721011ab434a712be11316dd06ad56", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<XuanHoang.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
       Layout = "_Layout"; ViewBag.Title = "All Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <nav class=""breadcrumb"">
                <a class=""breadcrumb-item"" href=""#"">Manager</a>
                <span class=""breadcrumb-item active"">Product</span>
            </nav>
            <h2>All Product</h2>
    <a href=""/product/addproduct"" class=""btn btn-sm btn-primary"">Add Product</a>
    <a href=""/product/getproduct"" class=""btn btn-sm btn-secondary"">Get Product</a>
     
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Description</th>
                <th>CategoryId</th>
                <th>Image</th>
                <th>Price</th>
                <th>Status</th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
                   Write(r.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a type=\"submit\"");
            BeginWriteAttribute("href", " href=\"", 1440, "\"", 1475, 2);
            WriteAttributeValue("", 1447, "/product/updateproduct/", 1447, 23, true);
#nullable restore
#line 39 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
WriteAttributeValue("", 1470, r.Id, 1470, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1476, "\"", 1496, 1);
#nullable restore
#line 39 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
WriteAttributeValue("", 1491, r.Id, 1491, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: green; color: white; border: 2px;\">Update</a>\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <form action=\"/product/deleteproduct\" method=\"get\">\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2008, "\"", 2021, 1);
#nullable restore
#line 47 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
WriteAttributeValue("", 2016, r.Id, 2016, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Id\" />\r\n                            <input type=\"submit\" value=\"Delete\" style=\"background-color: red; color: white; border: 2px;c\"/>\r\n                        </form>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Product\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<XuanHoang.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591