#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\PracticeContest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd7dca8b109c93876d973d67e6c2e89c20d0f7b"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/PracticeContest")]
    public class PracticeContest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 40 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\PracticeContest.cshtml"
           

     List<UserContest> urcontest => appState.UserContest.ToList();

     protected override void OnInit()
        {
            appState.OnContestAdded += StateHasChanged;
        }

    private void OnJoinClick()
    {
        Console.WriteLine("Practice Contest Clicked");
        uriHelper.NavigateTo("/Contest");
        Console.WriteLine(urcontest[0].contestId);
        Console.WriteLine(urcontest[0].userTeamId);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591