#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\PracticeContest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd7dca8b109c93876d973d67e6c2e89c20d0f7b"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/PracticeContest")]
    public class PracticeContest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "button");
            builder.AddAttribute(1, "class", "backButton");
            builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, OnJoinClick));
            builder.AddContent(3, "submit");
            builder.CloseElement();
            builder.AddContent(4, "\r\n");
            builder.AddMarkupContent(5, "<div class=\"dialog dialog--active dialog_fe4fb\">\r\n    <div class=\"bg-overlay bg-overlay--fade-in\"></div>\r\n    <div class=\"dialog-content dialog-content--enter\">\r\n        <div class=\"low-balance-dialog js--low-balance-dialog\">\r\n            <div class=\"js--low-balance-dialog\">\r\n                <div class=\"dialog-header\">Confirmation</div>\r\n                <div class=\"dialog-body\">\r\n                    <div class=\"balanceCurrent_98c83\">\r\n                        <div class=\"add-cash-dialog__balance\"><span>Current Balance:</span><span><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">0</span></span></span></div>\r\n                    </div>\r\n                    <div class=\"cashBonusText_5b6be\">\r\n                        <div><span>Usable Cash Bonus:  </span><span><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">25</span></span></span><span>  OR 10%  of the Total Entry* per match(whichever is higher)</span></div>\r\n                        <div class=\"lowBalanceDialogNote_cdbae\">*Not valid for Private contests /and Public contests less than 10 members</div>\r\n                    </div>\r\n                    <div class=\"balanceContainer_09c83 balanceJoining_cd210\"><span>Joining Amount:</span><span class=\"joiningAmountText_db306\"><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">0</span></span></span></div>\r\n                    <div class=\"tncText_d84a6\">By joining this contest, you accept Dream11\'s T&amp;C and conﬁrm that you are not a resident of Assam, Odisha, Telangana, Nagaland or Sikkim.</div>\r\n                    <a href=\"https://fantasycricket.dream11.com/in/termsandconditions\" target=\"_blank\" class=\"tncLinkText_8dc01\">Go to T&amp;C</a>\r\n                </div>\r\n                <div class=\"dialog-footer-actions\">\r\n                    <div class=\"button-group-contest\">\r\n                        <button class=\"btn btn--raised\">\r\n                            <div class=\"align-center-joinContestbtn\"><div class=\"js--contest-join-confirm\">Join Contest</div></div>\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.AdImage>(6);
            builder.CloseComponent();
            builder.AddMarkupContent(7, "\r\n\r\n\r\n\r\n");
            builder.AddMarkupContent(8, @"<style>
    .backButton {
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
        width: 70%;
        margin-left: 74px;
        margin-top: 620px;
        color: white;
    }
</style>");
        }
        #pragma warning restore 1998
#line 40 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\PracticeContest.cshtml"
           

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
