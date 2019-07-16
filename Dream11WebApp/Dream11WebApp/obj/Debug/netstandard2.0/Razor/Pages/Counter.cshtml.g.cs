#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5200b1696f1cc63f35e751b26949831df601245d"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h2>Add Expense</h2>\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "row");
            builder.AddContent(3, "\r\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "col-md-4");
            builder.AddContent(6, "\r\n        ");
            builder.OpenElement(7, "input");
            builder.AddAttribute(8, "class", "form-control");
            builder.AddAttribute(9, "placeholder", "Enter Description...");
            builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(expense.Description));
            builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => expense.Description = __value, expense.Description));
            builder.CloseElement();
            builder.AddContent(12, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(13, "\r\n    ");
            builder.OpenElement(14, "div");
            builder.AddAttribute(15, "class", "col-md-2");
            builder.AddContent(16, "\r\n        ");
            builder.OpenElement(17, "input");
            builder.AddAttribute(18, "class", "form-control");
            builder.AddAttribute(19, "placeholder", "Enter Amount...");
            builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(expense.Amount));
            builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => expense.Amount = __value, expense.Amount));
            builder.CloseElement();
            builder.AddContent(22, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(23, "\r\n    ");
            builder.OpenElement(24, "div");
            builder.AddAttribute(25, "class", "col-md-6");
            builder.AddContent(26, "\r\n        ");
            builder.OpenElement(27, "button");
            builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, AddExpense));
            builder.AddAttribute(29, "class", "btn btn-primary");
            builder.AddContent(30, "\r\n            Add\r\n        ");
            builder.CloseElement();
            builder.AddContent(31, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(32, "\r\n    ");
            builder.OpenElement(33, "div");
            builder.AddAttribute(34, "class", "col-md-6");
            builder.AddContent(35, "\r\n        ");
            builder.OpenElement(36, "button");
            builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Naviagte));
            builder.AddAttribute(38, "class", "btn btn-primary");
            builder.AddContent(39, "\r\n            Next Page\r\n        ");
            builder.CloseElement();
            builder.AddContent(40, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(41, "\r\n");
            builder.CloseElement();
            builder.AddContent(42, "\r\n\r\n");
            builder.OpenElement(43, "div");
            builder.AddContent(44, "\r\n");
#line 25 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Counter.cshtml"
     if (matches == null)
    {

    }
    else
    {

#line default
#line hidden
            builder.AddContent(45, "         ");
            builder.OpenElement(46, "ul");
            builder.AddContent(47, "\r\n             ");
            builder.OpenElement(48, "li");
            builder.AddContent(49, matches.name);
            builder.CloseElement();
            builder.AddContent(50, "\r\n             ");
            builder.OpenElement(51, "li");
            builder.AddContent(52, matches.tImeSlot);
            builder.CloseElement();
            builder.AddContent(53, "\r\n             ");
            builder.OpenElement(54, "li");
            builder.AddContent(55, matches.matchId);
            builder.CloseElement();
            builder.AddContent(56, "\r\n             ");
            builder.OpenElement(57, "li");
            builder.AddContent(58, matches.sport);
            builder.CloseElement();
            builder.AddContent(59, "\r\n         ");
            builder.CloseElement();
            builder.AddContent(60, "\r\n");
#line 37 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Counter.cshtml"
    }

#line default
#line hidden
            builder.AddContent(61, "   \r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 41 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Counter.cshtml"
            
    private Expense expense = new Expense();
    Match matches { get; set; }
    string obj { get; set; }
    protected override async Task OnInitAsync()
    {
        var exampleJsInterop = new ExampleJsInterop(JSRuntime);
        //await exampleJsInterop.CallHelloHelperSayHello("Blazor");
        matches = await exampleJsInterop.GetItem<Match>("UserTeam2");
       

        appState._expenses.Clear();
    }


    private void AddExpense()
    {
        appState.AddExpense(expense);
        expense = new Expense();
    }
    private void Naviagte()
    {
        urilHelper.NavigateTo("/FetchData");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper urilHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
    }
}
#pragma warning restore 1591
