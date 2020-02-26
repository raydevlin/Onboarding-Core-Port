#pragma checksum "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db91fb07529de5553f32e6da874939fd85c592b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeedbackForm_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeedbackForm/Default.cshtml")]
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
#line 1 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\_ViewImports.cshtml"
using OnboardingCorePort;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\_ViewImports.cshtml"
using OnboardingCorePort.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6db91fb07529de5553f32e6da874939fd85c592b", @"/Views/Shared/Components/FeedbackForm/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdad84224af8db4f8e23f96a6e1bc159bf0cedf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FeedbackForm_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Onboarding_CorePort.ViewModels.FeedbackViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 91px; height: 22px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/image/logo-black.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""feedbackDiv flex-column"">
    <a class=""btn btn-primary feedback-accordion"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
        <i class=""far fa-comment-dots"" style=""color:white; background-color:none;"">&nbsp;&nbsp;Feedback</i>
    </a>

    <div class=""collapse thumbs-up-down pt-5"" id=""collapseExample"">
        <input type=""hidden"" class=""setDataPageID"" value=""OnboardIndex"" id=""setDataPageID"" name=""PageName"" />

        <a name=""like"" class=""far fa-thumbs-up fa-2x mr-2"" onclick=""postFeedback(1); openForm();"" data-toggle=""collapse"" href=""#collapseExample"" aria-controls=""collapseExample""></a>
        <a name=""dislike"" class=""far fa-thumbs-down fa-2x"" onclick=""postFeedback(0); openForm();"" data-toggle=""collapse"" href=""#collapseExample"" aria-controls=""collapseExample""></a>
    </div>
</div>

<div class=""form-popup "" id=""myForm"">

");
#nullable restore
#line 18 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
     using (Html.BeginForm("FeedbackSubmit", "Home", FormMethod.Post, new { @viewModel = this.Model, @class = "form-container" }))
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"button\" class=\"close float-left\" onclick=\"closeForm()\"><span style=\"color: #1999CA;\" class=\"fas fa-times\"></span></button>\r\n        <div class=\"body-form-content\">\r\n            <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6db91fb07529de5553f32e6da874939fd85c592b5659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n            <div>\r\n");
            WriteLiteral("                <label class=\"commentTextCss\">What category would you like to give website feedback on?</label>\r\n                <br />\r\n                ");
#nullable restore
#line 29 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
           Write(Html.DropDownListFor(model => model.UserFeedback.CategoryID, new SelectList(Model.Categories, "CategoryID", "CategoryName"), "Choose a category", htmlAttributes: new { @class = "dropdown feedback-dropdown" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n");
            WriteLiteral("                <label class=\"commentTextCss\">Rate your level of satisfaction with this web page today:</label>\r\n                <br />\r\n                <div class=\"custom-control-inline radioLabelCss\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
               Write(Html.RadioButtonFor(model => model.UserFeedback.LevelSatisfiedID, 1, htmlAttributes: new { @class = "form-inline" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    &nbsp; Satisfied\r\n                </div>\r\n                <br />\r\n                <div class=\"custom-control-inline radioLabelCss\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
               Write(Html.RadioButtonFor(model => model.UserFeedback.LevelSatisfiedID, 2, htmlAttributes: new { @class = "form-inline" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    &nbsp; Moderately Satisfied\r\n                </div>\r\n                <br />\r\n                <div class=\"custom-control-inline radioLabelCss\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
               Write(Html.RadioButtonFor(model => model.UserFeedback.LevelSatisfiedID, 3, htmlAttributes: new { @class = "form-inline" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    &nbsp; Moderately Dissatisfied\r\n                </div>\r\n                <br />\r\n                <div class=\"custom-control-inline radioLabelCss\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
               Write(Html.RadioButtonFor(model => model.UserFeedback.LevelSatisfiedID, 4, htmlAttributes: new { @class = "form-inline" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    &nbsp; Dissatisfied\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <div>\r\n");
            WriteLiteral("                <label class=\"commentTextCss\">Comments:</label>\r\n                ");
#nullable restore
#line 60 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
           Write(Html.TextAreaFor(model => model.UserFeedback.Comments, htmlAttributes: new { @class = "textBoxFormatting", @placeholder = "To protect your privacy, do not post any personal information such as your email address, phone number, product key, password or credit card number.", rows = "3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div><label class=""pl-3 maxCharactersCss"">Max 400 characters</label>
            <br />

            <button type=""submit"" id=""submitUserFeedbackForm"" class=""btn form-submit-button""><strong>SUBMIT</strong>&nbsp;<span class=""far fa-paper-plane submit-span""></span></button>
        </div>
");
#nullable restore
#line 67 "C:\Users\RayDevlin\source\repos\OnboardingCorePort\OnboardingCorePort\Views\Shared\Components\FeedbackForm\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Onboarding_CorePort.ViewModels.FeedbackViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
