#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47023aa6b495b823bd208554048d0b99509e0cf4"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h2");
            builder.AddContent(1, "Current Total: £");
            builder.AddContent(2, totalExpenses);
            builder.CloseElement();
            builder.AddContent(3, "\r\n");
            builder.OpenElement(4, "ul");
            builder.AddContent(5, "\r\n");
#line 32 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FetchData.cshtml"
     foreach (var obj in exps)
    {

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.OpenElement(7, "li");
            builder.AddContent(8, "\r\n        ");
            builder.AddContent(9, obj.Amount);
            builder.AddContent(10, "\r\n        ");
            builder.AddContent(11, obj.Description);
            builder.AddContent(12, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(13, "\r\n");
#line 38 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FetchData.cshtml"
    }

#line default
#line hidden
            builder.AddContent(14, "    ");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 41 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\FetchData.cshtml"
                
        private decimal totalExpenses => appState.Expenses.Sum(x => x.Amount);
        List<Expense> exps => appState.Expenses.ToList();

        protected override void OnInit()
        {
            appState.OnExpenseAdded += StateHasChanged;
        }
    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
    }
}
#pragma warning restore 1591
