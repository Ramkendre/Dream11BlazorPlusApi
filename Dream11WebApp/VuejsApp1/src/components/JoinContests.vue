<template>
    <div>
        <div class="headerContainer_199c8 headerFixed_38df7 headerShadow_22469"><div class="row-1 headerRow_c14ad"><div class="headerLeft_36c4e"><div class="js--match-header__back-btn"><button class="btn btn--icon"><div class="align-center"><i class="material-icons">arrow_back</i></div></button></div></div><div class="headerCenter_4d6f0"><div class="headerTitle_fd62d">CONTESTS</div></div><div class="headerRight_ba2d2"></div></div><div class="info-bar js-match-header__info-bar infobar_0dc07"><div class="infobarContent_628aa"><div class="infobarContentRow_7ae93"><div class="js--match-header-title infobarContentLeft_04a34">AT vs TK</div><div class="infobarContentCenter_5f791"><div class="timer_1aa54"><i class="materialIcon_10a4f" style="height: 16px; width: 16px; font-size: 16px;">access_time</i><span class="timeRemaining_96d65"><div class="timer_44feb">00h 15m 35s</div></span></div></div><div class="js--guru-link infobarContentRight_ac9bd"></div></div></div></div><div class="row-3"><div><div class="sorting-header sortingHeader_28c64"><div class="sorting-header__item">Prize Pool<div class="sorting-header__icon"><i class="material-icons"></i></div></div><div class="sorting-header__item">Spots<div class="sorting-header__icon"><i class="material-icons"></i></div></div><div class="sorting-header__item">Winners<div class="sorting-header__icon"><i class="material-icons"></i></div></div><div class="sorting-header__item sorting-header__item--active">Entry<div class="sorting-header__icon"><i class="material-icons">keyboard_arrow_down</i></div></div></div></div></div></div>
        <v-card  v-for="player in 11">
            <a class="js--contest-card contestCardWrapper_fbec5 containerShadow_c2514">
                <div class="contestSpecMoneyInfo_20124">
                    <div class="contestSpecRow_01429">
                        <div class="contestCardLabel_7ca40">Prize Pool</div><div class="contestCardLabel_7ca40">Entry</div>
                    </div>
                    <div class="contestSpecRow_01429">
                        <div class="js--contest-card__prize-pool prizePool_565d2">₹10 Lakhs</div>
                        <div>
                            <div style="display: flex;align-items: center;">
                                <div class="js--contest-card-join-btn">
                                    <v-button class="new-button smallGreenButton_4bae7">
                                        <span><span class="d11-icon">₹</span><span class="currency-amount">99</span></span>
                                    </v-button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="contestProgressBarContainer_0efc1">
                    <div class="contestProgressBar_eba45">
                        <div class="contestProgressInner_ead13" style="width: 49%;"></div>
                    </div>
                </div>
                <div class="spotsContainer_9c427">
                    <div class="contestSpecRow_01429">
                        <div class="spotLefts_8d583 contestFilling_14509">6,413 spots left</div>
                        <div class="totalSpots_b62ba">13,000 spots</div>
                    </div>
                </div>
                <div class="contestSpec_a3ebb">
                    <div class="iconLabelGroup_f55e1">
                        <div class="iconLabelWrapper_43690"><img src="/public/imgs/winners_icon.svg" style="height: 16px; width: 16px; margin-right: 4px;"><span>33%</span></div>
                    </div><div class="iconLabelGroup_f55e1" style="justify-content: flex-end;"><div class="squareWithTwoRoundCorner_1291a">C</div><div style="padding-left: 12px;"><div class="squareWithTwoRoundCorner_1291a">M</div></div></div>
                </div>
            </a>
        </v-card>



        <div class="appBgImage_ceacf">
            <div class="absolute">
                <div class="content_eaf85 containerWithoutHeader_0f1f0" style="background-image: url(&quot;https://assets.dream11.com/public/imgs/cricket-artwork.svg&quot;);">
                </div>
            </div>
        </div>
    </div>

</template>

<script>
    export default
        {
            data() {
                return {
                    selectedplayer: this.$store.getters.selectedplayer
                }
            },
             

        };
</script>

<style >
    
    /*.contestCardWrapper_fbec5 {
        border-radius: 4px;
        display: block;
        background-color: #fff;
        text-decoration: none;
        padding-right: 17px;
    }*/

    /*.containerShadow_c2514 {
        margin: 0 12px 12px 12px;
        box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.1), 0 4px 6px 0 rgba(0, 0, 0, 0.05);
    }*/
    .contestFilling_14509 {
        color: #ffa01e;
    }

    .spotLefts_8d583 {
        font-size: 12px;
        font-weight: 500;
    }
    .timer_1aa54 {
        font-family: monospace;
        display: flex;
        justify-content: center;
        align-items: center;
        color: #c51d23;
    }
    .squareWithTwoRoundCorner_1291a {
        width: 20px;
        height: 20px;
        padding: 2px;
        font-size: 12px;
        color: #969696;
        border: 1px solid #969696;
        border-radius: 2px 0 2px 0;
        display: flex;
        justify-content: center;
    }
    .iconLabelGroup_f55e1 {
        display: inline-flex;
        width: 50%;
    }
    .iconLabelWrapper_43690 {
        display: flex;
        justify-content: space-between;
        color: #969696;
    }

    .contestSpec_a3ebb {
        background-color: #f8f8f8;
        border-top: 1px solid #f4f4f4;
        padding: 12px;
        font-size: 12px;
        height: 32px;
        display: flex;
        border-radius: 0 0 4px 4px;
        align-items: center;
    }
    .contestProgressBar_eba45 {
        height: 8px;
        display: flex;
        justify-content: flex-end;
        transform: skew(-20deg);
        background-image: linear-gradient(to right, #ffc81e, #e10000);
    }


    .contestSpecMoneyInfo_20124 {
        width: 100%;
        display: flex;
        flex-direction: column;
        padding: 12px;
    }
    .contestSpecRow_01429 {
        display: flex;
        justify-content: space-between;
        align-items: center;
        padding-bottom: 8px;
    }
    .contestSpecRow_01429 {
        display: flex;
        justify-content: space-between;
        align-items: center;
        padding-bottom: 8px;
    }
    .contestCardLabel_7ca40 {
        font-size: 12px;
        color: #969696;
    }
    .prizePool_565d2 {
        font-size: 20px;
        font-weight: 500;
        color: #282828;
    }
    .smallGreenButton_4bae7 {
        background: none;
        border: 0;
        cursor: pointer;
        margin: 0;
        text-decoration: none;
        text-align: center;
        font-family: inherit;
        display: flex;
        justify-content: center;
        align-items: center;
        color: #fff;
        font-weight: 500;
        font-size: 12px;
        height: 28px;
        padding: 0 8px;
        border-radius: 4px;
        background-color: #00b137;
        width: 76px;
    }
    /*.headerFixed_38df7 {
        position: fixed;
        top: 0;
        max-width: 550px;
        width: 100%;
    }*/
   
    .infobar_0dc07 {
        background-color: #c51d23;
        height: 50px;
        padding: 8px;
    }
    .infobarContent_628aa {
        background-color: #FFF;
        height: 100%;
        color: #323232;
        border-radius: 2px;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 8px;
    }
    .infobarContentRow_7ae93 {
        display: flex;
        width: 100%;
        font-size: 12px;
    }
   
    .infobarContentLeft_04a34 {
        flex: 1 0 0;
    }
    
 

 
    .contestCardWrapper_fbec5 {
        border-radius: 4px;
        display: block;
        background-color: #fff;
        text-decoration: none;
    }

    .contestscrollRight {
        position: fixed;
        left: 0px;
        width: 592px;
        right: 0;
        background-size: cover;
        top: 94px;
        bottom: 0;
        overflow-y: scroll;
    }
</style>