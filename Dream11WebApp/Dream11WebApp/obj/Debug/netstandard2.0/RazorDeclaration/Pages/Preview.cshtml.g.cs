#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Preview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920e2c1c5682bfb95f221a66211304711e480a64"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

    [Microsoft.AspNetCore.Components.RouteAttribute("/Preview")]
    public class Preview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 191 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Preview.cshtml"
           
    [Parameter]
    UserTeams[] userPlayer { get; set; }
    [Parameter]
    private EventCallback<UserTeams[]> userPlayerChanged { get; set; }

    private void Edit(int matchid, int userteamId)
    {
        uriHelper.NavigateTo("/Players/" + matchid + "/" + userteamId);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591