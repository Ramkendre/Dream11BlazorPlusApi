#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Contest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f92a7423d5b240388a1c65a48d3210be1b5b29"
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

    [Microsoft.AspNetCore.Components.RouteAttribute("/Contest")]
    public class Contest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddContent(1, "\r\n    ");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "lazy-contest-home");
            builder.AddContent(4, "\r\n        ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "contest-home-for-view js--contest-home contestHome_789e2");
            builder.AddContent(7, "\r\n            ");
            builder.AddMarkupContent(8, "<div class=\"match-header\">\r\n                <div class=\"headerContainer_199c8 headerFixed_38df7\">\r\n                    <div class=\"row-1 headerRow_c14ad\">\r\n                        <div class=\"headerLeft_36c4e\">\r\n                            <div class=\"js--match-header__back-btn\">\r\n                                <button class=\"btn btn--icon\">\r\n                                    <div class=\"align-center\"><i class=\"material-icons\">arrow_back</i></div>\r\n                                </button>\r\n                            </div>\r\n                            <div class=\"js--match-header__home-btn\"><a class=\"btn btn--icon\" href=\"/leagues?sid=0\"><i class=\"material-icons\">home</i></a></div>\r\n                        </div>\r\n                        <div class=\"headerCenter_4d6f0\"><div class=\"headerTitle_fd62d\">Contests</div></div>\r\n                        <div class=\"headerRight_ba2d2\">\r\n                            <div class=\"js--match-header__wallet\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"info-bar js-match-header__info-bar infobar_0dc07\">\r\n                        <div class=\"infobarContent_628aa\">\r\n                            <div class=\"infobarContentRow_7ae93\">\r\n                                <div class=\"js--match-header-title infobarContentLeft_04a34\">MI vs CSK</div>\r\n                                <div class=\"infobarContentCenter_5f791\">\r\n                                    <div class=\"timer_1aa54\">\r\n                                        <div class=\"timeRemaining_96d65\">\r\n                                            <div class=\"timer_44feb\">21h 49m 00s</div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"js--guru-link infobarContentRight_ac9bd\"></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"account-dialog\"></div>\r\n            </div>\r\n\r\n            <div></div>\r\n\r\n            ");
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "contestscrollRight");
            builder.AddContent(11, "\r\n\r\n                ");
            builder.AddMarkupContent(12, "<div>\r\n                    <div class=\"contestsHeader_16599\">\r\n                        <div class=\"playWithFriendsWrapper_3442c\">\r\n                            <div class=\"js--contest-code-btn\">\r\n                                <button class=\"new-button raisedWhiteButtonNew_08689\">\r\n                                    <div class=\"iconLabel_f964d iconLabelSmall_a2024\">\r\n                                        <span class=\"iconContent_3cbfd\">Enter Contest Code</span><i class=\"materialIcon_10a4f\" style=\"height: 14px; width: 14px; font-size: 14px;\">input</i>\r\n                                    </div>\r\n                                </button>\r\n                            </div>\r\n                            <div class=\"js--private-contest-btn\">\r\n                                <a class=\"raisedWhiteButtonNew_08689\" href=\"/cricket/create-private-league/english-one-day-cup/1033/14341\">\r\n                                    <div class=\"iconLabel_f964d iconLabelSmall_a2024\">\r\n                                        <span class=\"iconContent_3cbfd\">Create a Contest</span>\r\n                                        <i class=\"materialIcon_10a4f\" style=\"height: 14px; width: 14px; font-size: 14px;\">add_circle_outline</i>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n                        </div><div class=\"sortingContainer_5b732\">\r\n                            <div class=\"sortingHeader_7b795\"><div class=\"sortLabel_c5373\">Sort By:</div></div>\r\n                            <div class=\"sortingBody_ecb4a\">\r\n                                <div class=\"sortButton_6d4e0\"><a class=\"whiteBgButton_f180e\" href=\"/cricket/contests/english-one-day-cup/1033/14341?sortBy=0\">Entry Fee</a></div>\r\n                                <div class=\"sortButton_6d4e0\">\r\n                                    <a class=\"whiteBgButton_f180e\" href=\"/cricket/contests/english-one-day-cup/1033/14341?sortBy=1\">Contest Size</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            builder.AddMarkupContent(13, "<div>\r\n                    <div class=\"segmentHeaderContainer_ea185 webkitSticky_3d076 segmentHeaderContainerTop_9bdb2\">\r\n                        <a class=\"row_404ce\">\r\n                            <div>\r\n                                <div>\r\n                                    <div class=\"headerTitle_ba6eb\">Mega Contest</div>\r\n                                    <div class=\"headerText_d7966\">Get ready for mega winnings!</div>\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <a class=\"js--contest-card contestCardWrapper_fbec5 containerShadow_c2514\" href=\"/cricket/leaderboard/english-one-day-cup/1033/14341/1220033359\">\r\n                        <div class=\"contestSpecMoneyInfo_20124\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"contestCardLabel_7ca40\">Prize Pool</div>\r\n                                <div class=\"contestCardLabel_7ca40\">Entry</div>\r\n                            </div>\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"js--contest-card__prize-pool prizePool_565d2\">₹10 Lakhs</div>\r\n                                <div>\r\n                                    <div style=\"display: flex; align-items: center;\">\r\n                                        <div class=\"js--contest-card-join-btn\">\r\n                                            <button class=\"new-button smallGreenButton_4bae7\"><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">33</span></span></button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestProgressBarContainer_0efc1\">\r\n                            <div class=\"contestProgressBar_eba45\">\r\n                                <div class=\"contestProgressInner_ead13\" style=\"width: 99%;\"></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"spotsContainer_9c427\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"spotLefts_8d583 contestFilling_14509\">39,535 spots left</div>\r\n                                <div class=\"totalSpots_b62ba\">40,000 spots</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestSpec_a3ebb\">\r\n                            <div class=\"iconLabelGroup_f55e1\">\r\n                                <div class=\"iconLabelWrapper_43690\"><img src=\"https://assets.dream11.com/public/imgs/winners_icon.svg\" style=\"height: 16px; width: 16px; margin-right: 4px;\"><span>63%</span></div>\r\n                            </div>\r\n                            <div class=\"iconLabelGroup_f55e1\" style=\"justify-content: flex-end;\">\r\n                                <div class=\"squareWithTwoRoundCorner_1291a\">C</div>\r\n                                <div style=\"padding-left: 12px;\"><div class=\"squareWithTwoRoundCorner_1291a\">M</div></div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <div class=\"segmentFooterContainer_467dc\"><div class=\"segmentFooterRightContainer_65267\"></div></div>\r\n                </div>\r\n\r\n                ");
            builder.AddMarkupContent(14, "<div>\r\n                    <div class=\"segmentHeaderContainer_ea185 webkitSticky_3d076 segmentHeaderContainerTop_9bdb2\">\r\n                        <a class=\"row_404ce\">\r\n                            <div>\r\n                                <div>\r\n                                    <div class=\"headerTitle_ba6eb\">Only For Beginners</div>\r\n                                    <div class=\"headerText_d7966\">Play Your First Contest Now</div>\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <a class=\"js--contest-card contestCardWrapper_fbec5 containerShadow_c2514\">\r\n                        <div class=\"contestSpecMoneyInfo_20124\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"contestCardLabel_7ca40\">Prize Pool</div>\r\n                                <div class=\"contestCardLabel_7ca40\">Entry</div>\r\n                            </div>\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"js--contest-card__prize-pool prizePool_565d2\">₹750</div>\r\n                                <div>\r\n                                    <div style=\"display: flex; align-items: center;\">\r\n                                        <div class=\"js--contest-card-join-btn\">\r\n                                            <button class=\"new-button smallGreenButton_4bae7\"><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">13</span></span></button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestProgressBarContainer_0efc1\">\r\n                            <div class=\"contestProgressBar_eba45\">\r\n                                <div class=\"contestProgressInner_ead13\" style=\"width: 85%;\"></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"spotsContainer_9c427\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"spotLefts_8d583 contestFilling_14509\">56 spots left</div>\r\n                                <div class=\"totalSpots_b62ba\">66 spots</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestSpec_a3ebb\">\r\n                            <div class=\"iconLabelGroup_f55e1\">\r\n                                <div class=\"iconLabelWrapper_43690\"><img src=\"https://assets.dream11.com/public/imgs/winners_icon.svg\" style=\"height: 16px; width: 16px; margin-right: 4px;\"><span>61%</span></div>\r\n                            </div>\r\n                            <div class=\"iconLabelGroup_f55e1\" style=\"justify-content: flex-end;\">\r\n                                <div style=\"padding-left: 12px;\">\r\n                                    <div class=\"squareWithTwoRoundCorner_1291a\">M</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <a class=\"js--contest-card contestCardWrapper_fbec5 containerShadow_c2514\">\r\n                        <div class=\"contestSpecMoneyInfo_20124\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"contestCardLabel_7ca40\">Prize Pool</div>\r\n                                <div class=\"contestCardLabel_7ca40\">Entry</div>\r\n                            </div>\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"js--contest-card__prize-pool prizePool_565d2\">₹250</div>\r\n                                <div>\r\n                                    <div style=\"display: flex; align-items: center;\">\r\n                                        <div class=\"js--contest-card-join-btn\">\r\n                                            <button class=\"new-button smallGreenButton_4bae7\"><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">26</span></span></button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestProgressBarContainer_0efc1\">\r\n                            <div class=\"contestProgressBar_eba45\">\r\n                                <div class=\"contestProgressInner_ead13\" style=\"width: 91%;\"></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"spotsContainer_9c427\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"spotLefts_8d583 contestFilling_14509\">10 spots left</div>\r\n                                <div class=\"totalSpots_b62ba\">11 spots</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestSpec_a3ebb\">\r\n                            <div class=\"iconLabelGroup_f55e1\">\r\n                                <div class=\"iconLabelWrapper_43690\"><img src=\"https://assets.dream11.com/public/imgs/winners_icon.svg\" style=\"height: 16px; width: 16px; margin-right: 4px;\"><span>64%</span></div>\r\n                            </div>\r\n                            <div class=\"iconLabelGroup_f55e1\" style=\"justify-content: flex-end;\">\r\n                                <div style=\"padding-left: 12px;\">\r\n                                    <div class=\"squareWithTwoRoundCorner_1291a\">M</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <a class=\"js--contest-card contestCardWrapper_fbec5 containerShadow_c2514\">\r\n                        <div class=\"contestSpecMoneyInfo_20124\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"contestCardLabel_7ca40\">Prize Pool</div>\r\n                                <div class=\"contestCardLabel_7ca40\">Entry</div>\r\n                            </div>\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"js--contest-card__prize-pool prizePool_565d2\">₹90</div><div>\r\n                                    <div style=\"display: flex; align-items: center;\">\r\n                                        <div class=\"js--contest-card-join-btn\">\r\n                                            <button class=\"new-button smallGreenButton_4bae7\"><span><span class=\"d11-icon\">₹</span><span class=\"currency-amount\">51</span></span></button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestProgressBarContainer_0efc1\">\r\n                            <div class=\"contestProgressBar_eba45\"><div class=\"contestProgressInner_ead13\" style=\"width: 100%;\"></div></div>\r\n                        </div>\r\n                        <div class=\"spotsContainer_9c427\">\r\n                            <div class=\"contestSpecRow_01429\">\r\n                                <div class=\"spotLefts_8d583 contestFilling_14509\">2 spots left</div><div class=\"totalSpots_b62ba\">2 spots</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"contestSpec_a3ebb\">\r\n                            <div class=\"iconLabelGroup_f55e1\">\r\n                                <div class=\"iconLabelWrapper_43690\">\r\n                                    <img src=\"https://assets.dream11.com/public/imgs/winners_icon.svg\" style=\"height: 16px; width: 16px; margin-right: 4px;\"><span>50%</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"iconLabelGroup_f55e1\" style=\"justify-content: flex-end;\">\r\n                                <div style=\"padding-left: 12px;\"><div class=\"squareWithTwoRoundCorner_1291a\">S</div></div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <div class=\"segmentFooterContainer_467dc\">\r\n                        <div class=\"segmentFooterRightContainer_65267\"></div>\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            builder.OpenElement(15, "div");
            builder.AddContent(16, "\r\n                    ");
            builder.AddMarkupContent(17, @"<div class=""segmentHeaderContainer_ea185 webkitSticky_3d076 segmentHeaderContainerTop_9bdb2"">
                        <a class=""row_404ce"">
                            <div>
                                <div>
                                    <div class=""headerTitle_ba6eb"">Practice Contests</div>
                                    <div class=""headerText_d7966"">Hone Your Skills</div>
                                </div>
                            </div>
                        </a>
                    </div>
                    ");
            builder.OpenElement(18, "a");
            builder.AddAttribute(19, "class", "js--contest-card contestCardWrapper_fbec5 containerShadow_c2514");
            builder.AddContent(20, "\r\n                        ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "contestSpecMoneyInfo_20124");
            builder.AddContent(23, "\r\n                            ");
            builder.OpenElement(24, "div");
            builder.AddAttribute(25, "class", "contestSpecRow_01429");
            builder.AddContent(26, "\r\n                                ");
            builder.AddMarkupContent(27, "<div class=\"js--contest-card__prize-pool prizePool_565d2\">Practice Contest</div>");
            builder.OpenElement(28, "div");
            builder.AddContent(29, "\r\n                                    ");
            builder.OpenElement(30, "div");
            builder.AddAttribute(31, "style", "display: flex; align-items: center;");
            builder.AddContent(32, "\r\n                                        ");
            builder.OpenElement(33, "div");
            builder.AddAttribute(34, "class", "js--contest-card-join-btn");
            builder.AddContent(35, "\r\n                                            ");
            builder.OpenElement(36, "button");
            builder.AddAttribute(37, "class", "new-button smallGreenButton_4bae7");
            builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, JoinPracticeContest));
            builder.AddContent(39, "JOIN");
            builder.CloseElement();
            builder.AddContent(40, "\r\n                                        ");
            builder.CloseElement();
            builder.AddContent(41, "\r\n                                    ");
            builder.CloseElement();
            builder.AddContent(42, "\r\n                                ");
            builder.CloseElement();
            builder.AddContent(43, "\r\n                            ");
            builder.CloseElement();
            builder.AddContent(44, "\r\n                        ");
            builder.CloseElement();
            builder.AddContent(45, "\r\n                        ");
            builder.AddMarkupContent(46, @"<div class=""contestProgressBarContainer_0efc1"">
                            <div class=""contestProgressBar_eba45"">
                                <div class=""contestProgressInner_ead13"" style=""width: 70%;""></div>
                            </div>
                        </div>
                        ");
            builder.AddMarkupContent(47, @"<div class=""spotsContainer_9c427"">
                            <div class=""contestSpecRow_01429"">
                                <div class=""spotLefts_8d583 contestFilling_14509"">698 spots left</div>
                                <div class=""totalSpots_b62ba"">1,000 spots</div>
                            </div>
                        </div>
                        ");
            builder.AddMarkupContent(48, @"<div class=""contestSpec_a3ebb"">
                            <div class=""iconLabelGroup_f55e1""></div>
                            <div class=""iconLabelGroup_f55e1"" style=""justify-content: flex-end;"">
                                <div class=""squareWithTwoRoundCorner_1291a"">C</div>
                                <div style=""padding-left: 12px;""><div class=""squareWithTwoRoundCorner_1291a"">S</div></div>
                            </div>
                        </div>
                    ");
            builder.CloseElement();
            builder.AddMarkupContent(49, "\r\n                    ");
            builder.AddMarkupContent(50, @"<div class=""segmentFooterContainer_467dc"">
                        <div class=""segmentFooterRightContainer_65267"">
                            <span class=""js--more-link"">
                                <a class=""basicAnchorTextWithIcon_63f36"" href=""/cricket/contests/england-vs-pakistan-odi/1043/14645?sectionIds[]=3"">
                                    <div class=""iconLabel_f964d iconLabelMedium_48a55"">
                                        <span class=""iconContent_3cbfd"">View 3 more</span>
                                        <i class=""materialIcon_10a4f"" style=""height: 16px; width: 16px; font-size: 16px;"">chevron_right</i>
                                    </div>
                                </a>
                            </span>
                        </div>
                    </div>
                ");
            builder.CloseElement();
            builder.AddContent(51, "\r\n\r\n            ");
            builder.CloseElement();
            builder.AddContent(52, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(53, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(54, "\r\n");
            builder.CloseElement();
            builder.AddContent(55, "\r\n\r\n");
            builder.OpenElement(56, "div");
            builder.AddContent(57, "\r\n    ");
            builder.OpenComponent<Dream11WebApp.Pages.FooterButtons>(58);
            builder.CloseComponent();
            builder.AddContent(59, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(60, "\r\n\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.AdImage>(61);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 363 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Contest.cshtml"
           

    UserContest usercontest { get; set; }

    private void JoinPracticeContest()
    {
        appState._usercontest.Clear();
        appState.AddContest(new UserContest()
        {
            contestId = 1,
            userTeamId = 1
        });

        uriHelper.NavigateTo("/PracticeContest");
    }

    private void JoinedContest()
    {
        Console.WriteLine("Join Contest Clicked");

        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
