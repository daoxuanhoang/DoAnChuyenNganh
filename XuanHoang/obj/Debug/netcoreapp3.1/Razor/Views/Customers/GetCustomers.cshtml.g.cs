#pragma checksum "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e146b9a37601767ed7056f0d62dcf8e89df94f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_GetCustomers), @"mvc.1.0.view", @"/Views/Customers/GetCustomers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e146b9a37601767ed7056f0d62dcf8e89df94f03", @"/Views/Customers/GetCustomers.cshtml")]
    public class Views_Customers_GetCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<XuanHoang.Models.Customers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
   Layout = "_Layout"; ViewBag.Title = "Get Customer by Id";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<h2>Get Customers by Id <a href=""/customers/index"" class=""btn btn-sm btn-primary"">Back</a></h2>
<form method=""post"">
    <div class=""form-group"">
        <label for=""id"">Id:</label>
        <input class=""form-control"" name=""id"" />
    </div>
    <div class=""text-center panel-body"">
        <button type=""submit"" class=""btn btn-sm btn-primary"">Get Customer</button>
    </div>
</form>
 
");
#nullable restore
#line 15 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Customer</h2>
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Address</th>
                <th>Phone</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 30 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 38 "D:\DoAnChuyenNganh\API\XuanHoang\Views\Customers\GetCustomers.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<XuanHoang.Models.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591