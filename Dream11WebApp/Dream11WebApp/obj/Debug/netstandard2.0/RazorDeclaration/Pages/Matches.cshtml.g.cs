#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Matches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43596435ccbb41888e9503fadc054c52b831efd0"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/Matches")]
    public class Matches : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 67 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Matches.cshtml"
           

    Match[] matches { get; set; }
    protected override async Task OnInitAsync()
    {
        await LoadMatches();
    }
    async Task LoadMatches()
    {
        matches = await matchData.GetMatches();
    }

    void NavigatePage(int matchid)
    {
        // UriHelper.NavigateTo("/Players/" + matchid + "/"+0);

        UriHelper.NavigateTo("/Contest/" + matchid);
    }
    public int GetMatchID()
    {
        return 1;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatchData matchData { get; set; }
    }
}
#pragma warning restore 1591
