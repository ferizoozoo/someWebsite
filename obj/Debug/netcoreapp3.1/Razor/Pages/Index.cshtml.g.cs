#pragma checksum "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1452721d82c602d12f5b3ac3472fba095ca37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiniBlog.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MiniBlog.Pages
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
#line 1 "/home/len/dev/projects/web-projects/MiniBlog/Pages/_ViewImports.cshtml"
using MiniBlog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1452721d82c602d12f5b3ac3472fba095ca37e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed8ebd82c326353d2bb3470c79dcd84c85f20f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
 foreach (var post in @Model.Posts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"jumbotron jumbotron-fluid\">\r\n        <div class=\"container\">\r\n            <h1 class=\"text-center\">");
#nullable restore
#line 11 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
                               Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"row justify-content-center\">\r\n                <div class=\"col-sm-3 align-end\">\r\n                    <h5>Post by : ");
#nullable restore
#line 14 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
                             Write(post.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>    \r\n                <div class=\"col-sm-3\">\r\n                    <h5>Post by : ");
#nullable restore
#line 17 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
                             Write(post.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div> \r\n            </div>\r\n            <br>\r\n            <p class=\"mt-6 text-center\">");
#nullable restore
#line 21 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
                                   Write(post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            
            <div class=""jumbotron-footer"">
                <hr>
                <div class=""row"">
                    <div class=""col-md-2 offset-1"">
                        <a href=""#""><i class=""material-icons"">thumb_up</i></a>
                        <a href=""#""><i class=""material-icons"">thumb_down</i></a>
                    </div>
                    <div class=""col-md-2 offset-6"">
                        <a href=""#"">Go to the post</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 37 "/home/len/dev/projects/web-projects/MiniBlog/Pages/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
