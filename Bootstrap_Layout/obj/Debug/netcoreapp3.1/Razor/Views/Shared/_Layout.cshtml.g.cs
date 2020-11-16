#pragma checksum "C:\Users\Ba.boost\source\repos\Bootstrap_Layout\Bootstrap_Layout\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc77026879fc6e6bbe1b84674b986474805b55a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc77026879fc6e6bbe1b84674b986474805b55a", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc77026879fc6e6bbe1b84674b986474805b55a2746", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 188, "\"", 198, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 224, "\"", 234, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>Modern Business - Start Bootstrap Template</title>

    <!-- Bootstrap core CSS -->
    <link href=""/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""/css/modern-business.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc77026879fc6e6bbe1b84674b986474805b55a4497", async() => {
                WriteLiteral(@"

    <!-- Navigation -->
    <nav class=""navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""/Home/Index"">Start Bootstrap</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/About"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""services.html"">Services</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""contact.h");
                WriteLiteral(@"tml"">Contact</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPortfolio"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Portfolio
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPortfolio"">
                            <a class=""dropdown-item"" href=""portfolio-1-col.html"">1 Column Portfolio</a>
                            <a class=""dropdown-item"" href=""portfolio-2-col.html"">2 Column Portfolio</a>
                            <a class=""dropdown-item"" href=""portfolio-3-col.html"">3 Column Portfolio</a>
                            <a class=""dropdown-item"" href=""portfolio-4-col.html"">4 Column Portfolio</a>
                            <a class=""dropdown-item"" href=""portfolio-item.html"">Single Portfolio Item</a>
                        </div>
                    </li>
     ");
                WriteLiteral(@"               <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownBlog"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Blog
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownBlog"">
                            <a class=""dropdown-item"" href=""blog-home-1.html"">Blog Home 1</a>
                            <a class=""dropdown-item"" href=""blog-home-2.html"">Blog Home 2</a>
                            <a class=""dropdown-item"" href=""blog-post.html"">Blog Post</a>
                        </div>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownPages"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Other Pages
                        </a>
                        <div class");
                WriteLiteral(@"=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownPages"">
                            <a class=""dropdown-item"" href=""full-width.html"">Full Width Page</a>
                            <a class=""dropdown-item"" href=""sidebar.html"">Sidebar Page</a>
                            <a class=""dropdown-item"" href=""faq.html"">FAQ</a>
                            <a class=""dropdown-item"" href=""404.html"">404</a>
                            <a class=""dropdown-item"" href=""pricing.html"">Pricing Table</a>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <header>
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators""");
                WriteLiteral(@" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"" role=""listbox"">
                <!-- Slide One - Set the background image for this slide in the line below -->
                <div class=""carousel-item active"" style=""background-image: url('http://placehold.it/1900x1080')"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h3>First Slide</h3>
                        <p>This is a description for the first slide.</p>
                    </div>
                </div>
                <!-- Slide Two - Set the background image for this slide in the line below -->
                <div class=""carousel-item"" style=""background-image: url('http://placehold.it/1900x1080')"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h3>Second Slide</h3>
                        <p>This is a description for the second slide.</p>
                    </div>
                </div>
                <!-- Slide Three - S");
                WriteLiteral(@"et the background image for this slide in the line below -->
                <div class=""carousel-item"" style=""background-image: url('http://placehold.it/1900x1080')"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h3>Third Slide</h3>
                        <p>This is a description for the third slide.</p>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </header>

    <!-- Page Content -->
   ");
#nullable restore
#line 122 "C:\Users\Ba.boost\source\repos\Bootstrap_Layout\Bootstrap_Layout\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- /.container -->
    <!-- Footer -->
    <footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2020</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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