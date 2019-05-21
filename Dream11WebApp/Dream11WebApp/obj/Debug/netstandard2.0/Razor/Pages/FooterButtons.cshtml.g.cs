#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca2b47e5f413bd64db20d10b7b86cea913afb06"
// <auto-generated/>
#pragma warning disable 1591
namespace Dream11WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using Dream11WebApp;
    using Dream11WebApp.Shared;
    using Microsoft.AspNetCore.Components.Services;
    using Dream11WebApp.Model;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    public class FooterButtons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "contest-footer container_607ce");
            builder.AddContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "js--contest-footer innerContainer_b8f9b");
            builder.AddContent(5, "\r\n        ");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "button-group");
            builder.AddContent(8, "\r\n            ");
            builder.OpenElement(9, "a");
            builder.AddAttribute(10, "class", "btn btn--flat btn--bordered createbtn--bordered--white");
            builder.AddAttribute(11, "style", "border-color:white");
            builder.AddContent(12, "\r\n");
#line 5 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                 if (contestcount == 0)
                {

#line default
#line hidden
            builder.OpenElement(13, "div");
            builder.AddAttribute(14, "class", "text-color--white");
            builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, CreateTeam));
            builder.AddContent(16, "Create Team");
            builder.CloseElement();
#line 6 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                                                       }
                else
                {

#line default
#line hidden
            builder.AddContent(17, " ");
            builder.OpenElement(18, "div");
            builder.AddAttribute(19, "class", "text-color--white");
            builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, MyTeam));
            builder.AddContent(21, "My Team (1)");
            builder.CloseElement();
#line 8 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                                                    }

#line default
#line hidden
            builder.AddContent(22, "            ");
            builder.CloseElement();
            builder.AddContent(23, "\r\n            ");
            builder.OpenElement(24, "a");
            builder.AddAttribute(25, "class", "btn btn--flat btn--background--white");
            builder.AddContent(26, "\r\n                ");
            builder.OpenElement(27, "div");
            builder.AddAttribute(28, "class", "js--contest-footer__joined-contests-btn");
            builder.AddContent(29, "\r\n                    ");
            builder.OpenElement(30, "div");
            builder.AddAttribute(31, "class", "buttonItemContainer_029e0");
            builder.AddContent(32, "\r\n");
#line 13 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                         if (joincontestcount == 0)
                        {

#line default
#line hidden
            builder.AddMarkupContent(33, "<div>Joined Contests</div> ");
#line 14 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                    }
                        else
                        {

#line default
#line hidden
            builder.AddContent(34, " ");
            builder.AddMarkupContent(35, "<div>Joined Contests (1)</div>");
#line 16 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                        }

#line default
#line hidden
            builder.AddContent(36, "                    ");
            builder.CloseElement();
            builder.AddContent(37, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(38, "\r\n            ");
            builder.CloseElement();
            builder.AddContent(39, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(40, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(41, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 25 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
           

    private int contestcount { get; set; } = 0;
    private int joincontestcount { get; set; } = 0;

    private void CreateTeam()
    {
        uriHelper.NavigateTo("/Players/1");
    }

    private void MyTeam()
    {
        uriHelper.NavigateTo("/MyTeams");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
