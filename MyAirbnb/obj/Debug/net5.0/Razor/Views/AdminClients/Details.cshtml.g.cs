#pragma checksum "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd0a3cc3148a8efdd23c491909f729bff55ba87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminClients_Details), @"mvc.1.0.view", @"/Views/AdminClients/Details.cshtml")]
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
#line 1 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\_ViewImports.cshtml"
using MyAirbnb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\_ViewImports.cshtml"
using MyAirbnb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0a3cc3148a8efdd23c491909f729bff55ba87a", @"/Views/AdminClients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0dc1517ed9feeb494332928fb8dc79647bff1cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminClients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyAirbnb.Models.ClientsAdminView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClienteReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Clients Admin View</h4>\n    <hr />\n    <div>\n");
#nullable restore
#line 13 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
           await Html.RenderPartialAsync("_UserInfo", Model.Client); 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<hr />\n<table>\n    <thead>\n        \n            <tr class=\"col-sm-2\">\n                <th>\n                    ");
#nullable restore
#line 22 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Reservations));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </th>
            </tr>
        
    </thead>
    <tbody>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Post
                    </th>
                    <th>
                        ");
#nullable restore
#line 35 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reservations.FirstOrDefault().Post.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 38 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reservations.FirstOrDefault().StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 41 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reservations.FirstOrDefault().EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 44 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reservations.FirstOrDefault().TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 47 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Reservations.FirstOrDefault().State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th></th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 54 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                 foreach (var item in Model.Reservations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0a3cc3148a8efdd23c491909f729bff55ba87a8088", async() => {
                WriteLiteral("Link");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                                                                            WriteLiteral(item.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 61 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Post.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 64 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 67 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 70 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 73 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0a3cc3148a8efdd23c491909f729bff55ba87a12445", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n");
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 98 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\AdminClients\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
            WriteLiteral("    </tbody>\n</table>\n<div class=\"row\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0a3cc3148a8efdd23c491909f729bff55ba87a15065", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyAirbnb.Models.ClientsAdminView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
