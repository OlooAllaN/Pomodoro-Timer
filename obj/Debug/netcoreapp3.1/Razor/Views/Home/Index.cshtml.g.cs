#pragma checksum "C:\Pomodoro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2c54ace719f02b3a574a6e0db0e25604005090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Pomodoro\Views\_ViewImports.cshtml"
using Pomodoro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Pomodoro\Views\_ViewImports.cshtml"
using Pomodoro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2c54ace719f02b3a574a6e0db0e25604005090", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d8ad76de20facbf8934d12388742bc270f74b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pomodoro.Models.PomodoroViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Pomodoro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- As a link -->
<nav class=""navbar fixed-topnavbar navbar-expand-lg navbar-dark bg-dark"">
    <a class=""fa fa-shield navbar-brand"" href=""#""> Secure Innovation</a>

    <button class=""col-xs-offset-2 col-sm-offset-0 navbar-toggler navbar-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo03"" aria-controls=""navbarTogglerDemo03"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo03"">
        <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Account</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link disabled"" href=""#"">About</a>
            </li>
        </ul>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f2c54ace719f02b3a574a6e0db0e256040050904690", async() => {
                WriteLiteral("\r\n            <input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Search\" aria-label=\"Search\">\r\n            <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</nav>
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <div class=""animate"">
            <ul class=""bg-bubbles"">
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
        <div class=""custom-class flex-center"">
            <div class=""row"">
                <button type=""button"" class=""fa fa-sign-in btn btn-info  btn-block btn-responsive text-center"">  Login</button>
                <button type=""button"" class=""fa fa-user btn btn-warning  btn-block btn-responsive register-center""> Sign-Up</button>
            </div>
        ");
            WriteLiteral(@"    <div>
            </div>
        </div>
    </div>
</div>

<!--Modal: Login with Avatar Form-->
<div class=""modal fade"" id=""modalLoginAvatar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog cascading-modal modal-avatar modal-sm"" role=""document"">
        <!--Content-->
        <div class=""modal-content"">
            <!--Header-->
            <div class=""modal-header"">
                <img src=""https://cdn-images-1.medium.com/max/1200/0*F0ChLkPWUcALWH1h."" jpg alt=""avatar"" class=""rounded-circle img-responsive"">
            </div>
            <!--Body-->
            <div class=""modal-body text-center mb-1"">
                <h5 class=""mt-1 mb-2"">Allan Oloo</h5>
                <div class=""md-form ml-0 mr-0"">
                    <input type=""password"" type=""text"" id=""form29"" class=""form-control validate ml-0"">
                    <label data-error=""wrong"" data-success=""right"" for=""form29"" class=""ml-0"">Enter password</label>
       ");
            WriteLiteral(@"         </div>
                <div class=""text-center"">
                    <button class=""btn btn-cyan mt-1"">Login <i class=""fa fa-sign-in ml-1""></i></button>
                </div>
            </div>
        </div>
        <!--/.Content-->
    </div>
</div>
<div class=""modal fade"" id=""modalRegisterForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h4 class=""modal-title w-100 font-bold"">Sign up</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body mx-3"">
                <div class=""md-form"">
                    <i class=""fa fa-user prefix grey-text""></i>
                    <input type=""text"" id=""orangeForm-name"" class=""sig");
            WriteLiteral(@"n-up-control  validate"">
                    <label data-error=""wrong"" data-success=""right"" for=""orangeForm-name"">Your name</label>
                </div>
                <div class=""md-form"">
                    <i class=""fa fa-envelope prefix grey-text""></i>
                    <input type=""email"" id=""orangeForm-email"" class=""sign-up-control  validate"">
                    <label data-error=""wrong"" data-success=""right"" for=""orangeForm-email"">Your email</label>
                </div>

                <div class=""md-form"">
                    <i class=""fa fa-lock prefix grey-text""></i>
                    <input type=""password"" id=""orangeForm-pass"" class=""sign-up-control  validate"">
                    <label data-error=""wrong"" data-success=""right"" for=""orangeForm-pass"">Your password</label>
                </div>

            </div>
            <div class=""modal-footer d-flex justify-content-center"">
                <button class=""btn btn-deep-orange"">Sign up</button>
            </div>
  ");
            WriteLiteral("      </div>\r\n    </div>\r\n<div class=\"text-center\">\r\n     ");
#nullable restore
#line 124 "C:\Pomodoro\Views\Home\Index.cshtml"
Write(Html.Partial("_Pomodoro", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pomodoro.Models.PomodoroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
