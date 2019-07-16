#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\ChooseTeam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff48aeaf984fb3caa8b060ac315448fb3297d5f1"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/ChooseTeam")]
    public class ChooseTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "lazy-container-contest-home");
            builder.AddContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "lazy-contest-home");
            builder.AddContent(5, "\r\n        ");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "contest-home-for-view js--contest-home contestHome_789e2");
            builder.AddContent(8, "\r\n            ");
            builder.OpenElement(9, "div");
            builder.AddContent(10, "\r\n                ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "my-teams");
            builder.AddContent(13, "\r\n                    ");
            builder.OpenElement(14, "div");
            builder.AddContent(15, "\r\n                        ");
            builder.AddMarkupContent(16, "<div class=\"match-header\">\r\n                            <div class=\"headerContainer_199c8 headerFixed_38df7 headerShadow_22469\">\r\n                                <div class=\"row-1 headerRow_c14ad\">\r\n                                    <div class=\"headerLeft_36c4e\">\r\n                                        <div class=\"js--match-header__close-btn\">\r\n                                            <button class=\"btn btn--icon\">\r\n                                                <div class=\"align-center\">\r\n                                                    <i class=\"material-icons\">close</i>\r\n                                                </div>\r\n                                            </button>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"headerCenter_4d6f0\">\r\n                                        <div class=\"headerTitle_fd62d\">CHOOSE TEAM</div>\r\n                                    </div>\r\n                                    <div class=\"headerRight_ba2d2\"></div>\r\n                                </div>\r\n                                <div class=\"info-bar js-match-header__info-bar infobar_0dc07\">\r\n                                    <div class=\"infobarContent_628aa\">\r\n                                        <div class=\"infobarContentRow_7ae93\">\r\n                                            <div class=\"js--match-header-title infobarContentLeft_04a34\">AT vs TK</div>\r\n                                            <div class=\"infobarContentCenter_5f791\">\r\n                                                <div class=\"timer_1aa54\">\r\n                                                    <div class=\"timeRemaining_96d65\"><div class=\"timer_44feb\">03h 52m 30s</div></div>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"js--guru-link infobarContentRight_ac9bd\"></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"account-dialog\"></div>\r\n                        </div>\r\n                        ");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", "scroll");
            builder.AddContent(19, "\r\n                            ");
            builder.OpenElement(20, "div");
            builder.AddAttribute(21, "class", "my-teams__body js--my-teams");
            builder.AddContent(22, "\r\n                                ");
            builder.AddMarkupContent(23, "<div class=\"my-teams__title\">Choose team to join the contest with</div>\r\n\r\n                                ");
            builder.AddMarkupContent(24, "<div class=\"my-teams\">\r\n                                    <div class=\"my-teams__team\">\r\n                                        <div class=\"topSection_083bc\">\r\n                                            <div> <input type=\"checkbox\"> Team 1</div>\r\n                                        </div>\r\n                                        <div>\r\n                                            <div class=\"my-teams__bottom-section bottomSection_d41f9\">\r\n                                                <div class=\"my-teams__role-entity\">\r\n                                                    <div>\r\n                                                        <div class=\"my-teams__role-entity__title my-teams__role-entity--even\">Captain</div>\r\n                                                        <div class=\"my-teams__role-entity__player-name\">Doraiswamy Subramanium</div>\r\n                                                    </div>\r\n                                                </div>\r\n                                                <div class=\"my-teams__role-entity\">\r\n                                                    <div>\r\n                                                        <div class=\"my-teams__role-entity__title my-teams__role-entity--odd\">Vice Captain</div>\r\n                                                        <div class=\"my-teams__role-entity__player-name\">Bhavin Thakkar</div>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"buttonBar_09c83\">\r\n                                            <a class=\"js--icon-edit resetButton_62ab8\" href=\"/cricket/create-team/1050/14574/1?returnUrl=%2Fcricket%2Fleagues%2Ft20-mumbai%2F1050%2F14574\">\r\n                                                <div class=\"primaryButtonAlign_02538\">\r\n                                                    <span class=\"iconContent_3cbfd\">EDIT</span>\r\n                                                </div>\r\n                                            </a>\r\n                                            <div class=\"js--my-teams-team-preview-btn\">\r\n                                                <button class=\"new-button resetButton_62ab8\">\r\n                                                    <div class=\"primaryButtonAlign_02538\">\r\n                                                        <span class=\"iconContent_3cbfd\">PREVIEW</span>\r\n                                                    </div>\r\n                                                </button>\r\n                                            </div>\r\n                                            <a class=\"js--icon-content_copy resetButton_62ab8\" href=\"/cricket/create-team/1050/14574/1?returnUrl=%2Fcricket%2Fleagues%2Ft20-mumbai%2F1050%2F14574&amp;clone=true\">\r\n                                                <div class=\"primaryButtonAlign_02538\">\r\n                                                    <span class=\"iconContent_3cbfd\">CLONE</span>\r\n                                                </div>\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                ");
            builder.OpenElement(25, "div");
            builder.AddAttribute(26, "class", "my-teams__footer footer_d9dd6");
            builder.AddContent(27, "\r\n                                    ");
            builder.OpenElement(28, "a");
            builder.AddAttribute(29, "class", "btn btn--raised btn--white btn--disable");
            builder.AddAttribute(30, "disabled", "");
            builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, JoinContestTeam));
            builder.AddContent(32, "\r\n                                        ");
            builder.AddMarkupContent(33, "<span class=\"js--my-teams__create-team-btn\">Join</span>\r\n                                    ");
            builder.CloseElement();
            builder.AddContent(34, "\r\n                                ");
            builder.CloseElement();
            builder.AddContent(35, "\r\n                            ");
            builder.CloseElement();
            builder.AddContent(36, "\r\n                        ");
            builder.CloseElement();
            builder.AddContent(37, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(38, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(39, "\r\n                <div></div>\r\n            ");
            builder.CloseElement();
            builder.AddContent(40, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(41, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(42, "\r\n");
            builder.CloseElement();
            builder.AddContent(43, "\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.AdImage>(44);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 111 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\ChooseTeam.cshtml"
           
    private void JoinContestTeam()
    {
        uriHelper.NavigateTo("/PracticeContest");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
