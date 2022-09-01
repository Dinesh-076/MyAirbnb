#pragma checksum "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0204b2c8657a9330cc57a5bd7dfb28affc3d807b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RatingPartial), @"mvc.1.0.view", @"/Views/Shared/_RatingPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0204b2c8657a9330cc57a5bd7dfb28affc3d807b", @"/Views/Shared/_RatingPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0dc1517ed9feeb494332928fb8dc79647bff1cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__RatingPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<float?>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml"
   
    if (ViewData["StarSvg"] == null)
    {
        ViewData["StarSvg"] = true;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <svg style=\"display: none\" xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\"");
            BeginWriteAttribute("fill", " fill=\"", 191, "\"", 198, 0);
            EndWriteAttribute();
            WriteLiteral(@" viewBox=""0 0 16 16"">
            <defs>
                <symbol id=""svg-star"" viewBox=""0 0 16 16"">
                    <path d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z"" />
                </symbol>
            </defs>
        </svg>
");
#nullable restore
#line 15 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 19 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml"
  
    float value = 0;

    if (Model.HasValue) value = Model.Value;

    var roundRating = Math.Round(value);
    for (int i = 0; i < 5; i++)
    {
        var color = "#CBC050";
        if (i >= roundRating)
            color = "black";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <svg xmlns=\"http://www.w3.org/2000/svg\" class=\"icon-sm\"");
            BeginWriteAttribute("fill", " fill=\"", 1198, "\"", 1211, 1);
#nullable restore
#line 30 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml"
WriteAttributeValue("", 1205, color, 1205, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <use href=\"#svg-star\" />\n        </svg>\n");
#nullable restore
#line 33 "C:\Users\kar1290\Downloads\MyAirbnb\MyAirbnb-main\MyAirbnb\Views\Shared\_RatingPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<float?> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
