#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2407e2e3ec52c3900fb1ed36aa2030a4a367181"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/Home")]
    public class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<div class=\"header\">\r\n\r\n    <div class=\"page-header text-center bg-red\">\r\n        <h3>Dream11</h3>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "row");
            builder.AddContent(3, "\r\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class",  SType == Common.SportType.CRICKET.ToString() ? "col-sm-3 tabItemSelected_ad8b3 tabItem_8556a" : "col-sm-3 tabItemInactive_06be2 tabItem_8556a");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () =>  SelectedCricketTab("CRICKET")));
            builder.AddContent(7, "\r\n        ");
            builder.AddContent(8, Common.SportType.CRICKET);
            builder.AddContent(9, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(10, "\r\n    ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class",  SType == Common.SportType.FOOTBALL.ToString() ? "col-sm-3 tabItemSelected_ad8b3 tabItem_8556a" : "col-sm-3 tabItemInactive_06be2 tabItem_8556a");
            builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () =>  SelectedCricketTab("FOOTBALL")));
            builder.AddContent(14, "\r\n        ");
            builder.AddContent(15, Common.SportType.FOOTBALL);
            builder.AddContent(16, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(17, "\r\n    ");
            builder.OpenElement(18, "div");
            builder.AddAttribute(19, "class",  SType == Common.SportType.NBA.ToString() ? "col-sm-3 tabItemSelected_ad8b3 tabItem_8556a" : "col-sm-3 tabItemInactive_06be2 tabItem_8556a");
            builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () =>  SelectedCricketTab("NBA")));
            builder.AddContent(21, "\r\n        ");
            builder.AddContent(22, Common.SportType.NBA);
            builder.AddContent(23, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(24, "\r\n    ");
            builder.OpenElement(25, "div");
            builder.AddAttribute(26, "class",  SType == Common.SportType.HOCKEY.ToString() ? "col-sm-3 tabItemSelected_ad8b3 tabItem_8556a" : "col-sm-3 tabItemInactive_06be2 tabItem_8556a");
            builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () =>  SelectedCricketTab("HOCKEY")));
            builder.AddContent(28, "\r\n        ");
            builder.AddContent(29, Common.SportType.HOCKEY);
            builder.AddContent(30, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(31, "\r\n");
            builder.CloseElement();
            builder.AddContent(32, "\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.Matches>(33);
            builder.CloseComponent();
            builder.AddContent(34, "\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.AdImage>(35);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 31 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Home.cshtml"
           
    private string SType { get; set; } = Common.SportType.CRICKET.ToString();
    // private enum SportType { CRICKET, FOOTBALL, NBA, HOCKEY }

    //protected override void OnInit()
    //{
    //  //  toastService.ShowToast("I'm a WARNING message", Common.ToastLevel.Warning);
    //}

    private string SelectedCricketTab(string cricket)
    {
        return SType = cricket;
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591