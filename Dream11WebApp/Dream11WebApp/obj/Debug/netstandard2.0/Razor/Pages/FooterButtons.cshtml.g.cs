#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d227760f312f8251a807a80a8e9b0b7acfc2434e"
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
#line 5 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                 if (teamCount == 0)
                {

#line default
#line hidden
            builder.OpenElement(13, "div");
            builder.AddAttribute(14, "class", "text-color--white");
            builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, CreateTeam));
            builder.AddContent(16, "Create Team");
            builder.CloseElement();
#line 6 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                                                       }
                else
                {

#line default
#line hidden
            builder.AddContent(17, " ");
            builder.OpenElement(18, "div");
            builder.AddAttribute(19, "class", "text-color--white");
            builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, MyTeam));
            builder.AddContent(21, "My Team (");
            builder.AddContent(22, teamCount);
            builder.AddContent(23, ")");
            builder.CloseElement();
#line 8 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                                                             }

#line default
#line hidden
            builder.AddContent(24, "            ");
            builder.CloseElement();
            builder.AddContent(25, "\r\n            ");
            builder.OpenElement(26, "a");
            builder.AddAttribute(27, "class", "btn btn--flat btn--background--white");
            builder.AddContent(28, "\r\n                ");
            builder.OpenElement(29, "div");
            builder.AddAttribute(30, "class", "js--contest-footer__joined-contests-btn");
            builder.AddContent(31, "\r\n                    ");
            builder.OpenElement(32, "div");
            builder.AddAttribute(33, "class", "buttonItemContainer_029e0");
            builder.AddContent(34, "\r\n");
#line 13 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                         if (joincontestcount == 0)
                        {

#line default
#line hidden
            builder.AddMarkupContent(35, "<div>Joined Contests</div> ");
#line 14 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                    }
                        else
                        {

#line default
#line hidden
            builder.AddContent(36, " ");
            builder.AddMarkupContent(37, "<div>Joined Contests (1)</div>");
#line 16 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
                                                        }

#line default
#line hidden
            builder.AddContent(38, "                    ");
            builder.CloseElement();
            builder.AddContent(39, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(40, "\r\n            ");
            builder.CloseElement();
            builder.AddContent(41, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(42, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(43, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\FooterButtons.cshtml"
           
    [Parameter]
    int matchid { get; set; }
    private int teamCount { get; set; }
    private int joincontestcount { get; set; } = 0;
    Object autoken { get; set; }
    protected override async Task OnInitAsync()
    {
        await GetUserTeamCount();
    }
    async Task GetUserTeamCount()
    {
        autoken = await new ExampleJsInterop(JSRuntime).GetStringItem<Object>
     ("utoken");
        teamCount = await UserTeam.UserTeams(matchid, autoken);
    }
    private void CreateTeam()
    {
        uriHelper.NavigateTo("/Players/" + matchid + "/0");
    }

    private void MyTeam()
    {
        uriHelper.NavigateTo("/MyTeams/" + matchid);
    }
    [Parameter]
    private EventCallback<int> matchidChanged { get; set; }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserCustomTeam UserTeam { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
