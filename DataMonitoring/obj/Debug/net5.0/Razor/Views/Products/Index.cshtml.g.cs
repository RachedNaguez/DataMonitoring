#pragma checksum "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f8fa423dc6b493c47b0db6d2e51f23354297219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\_ViewImports.cshtml"
using PermissionBasedAuthorizationIntDotNet5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\_ViewImports.cshtml"
using PermissionBasedAuthorizationIntDotNet5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\_ViewImports.cshtml"
using PermissionBasedAuthorizationIntDotNet5.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
using PermissionBasedAuthorizationIntDotNet5.Contants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f8fa423dc6b493c47b0db6d2e51f23354297219", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c43bf4940c3de0badc634a83a309249815d9d86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Manage Products</h1>\n<hr />\n\n");
#nullable restore
#line 12 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
 if (AuthorizationService.AuthorizeAsync(User, Permissions.Products.View).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"btn btn-primary\">View</a>\n");
#nullable restore
#line 15 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 17 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
 if (AuthorizationService.AuthorizeAsync(User, Permissions.Products.Create).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"btn btn-secondary\">Create</a>\n");
#nullable restore
#line 20 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 22 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
 if (AuthorizationService.AuthorizeAsync(User, Permissions.Products.Edit).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8fa423dc6b493c47b0db6d2e51f233542972197054", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 25 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
 if (AuthorizationService.AuthorizeAsync(User, Permissions.Products.Delete).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 30 "C:\Users\rache\Desktop\PermissionBasedAuthorizationIntDotNet5-master\PermissionBasedAuthorizationIntDotNet5\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
