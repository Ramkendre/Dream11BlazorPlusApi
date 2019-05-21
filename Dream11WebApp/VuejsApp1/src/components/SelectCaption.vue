<template>
    <div class="relative">
        <div class="tabwidth">
            <!---Top header window code goes here-->
            <div>
                <div class="headerContainer_85dde headerFixed_38df7">
                    <div class="defaultHeaderContent_00a63">
                        <div class="headerLeft_97209">
                            <button class="new-button whiteIconButton_6998a">
                                <i class="materialIcon_10a4f" style="height: 24px; width: 24px; font-size: 24px;"></i>
                            </button>
                        </div>
                        <div class="headerCenter_aa154">
                            <span class="timer_3d48d">
                                5h left
                            </span>
                        </div>
                        <div class="headerRight_b78f0">
                            <div class="ctAppHeaderRight_029e0">
                                <a class="floatingAnchorButton_fac02" href="/cricket/howtoplay" target="_blank">
                                    <div class="helpLink_4c95c">?</div>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div>
                            <div class="onboardingHeader_40bc5">
                                <div class="mainContainer_3ec17">
                                    <div class="stepsContainer_b7305">
                                        <div class="stepWrapper_3b103">
                                            <div class="stepperLine_3cb5f stepperLineLeft_a18a6 stepperLineFirst_1e88e stepperLineActive_83254"></div>
                                            <div class="stepperLine_3cb5f stepperLineRight_77c82 stepperLineActive_83254"></div>
                                            <div class="stepNumberLabelWrapper_779ef stepNumberLabelWrapperFirst_c475a">
                                                <div class="stepNumber_70f3d stepNumberActive_e02df">
                                                    <i class="materialIcon_10a4f" style="height: 10px; width: 10px; font-size: 10px;"></i>
                                                </div>
                                                <div class="stepLabel_9786e">Select Match</div>
                                            </div>
                                        </div>
                                        <div class="stepWrapper_3b103">
                                            <div class="stepperLine_3cb5f stepperLineLeft_a18a6 stepperLineActive_83254"></div>
                                            <div class="stepperLine_3cb5f stepperLineRight_77c82"></div>
                                            <div class="stepNumberLabelWrapper_779ef">
                                                <div class="stepNumber_70f3d stepNumberActive_e02df">2</div>
                                                <div class="stepLabel_9786e stepLabelWhiteActive_3d48d">Create Team</div>
                                            </div>
                                        </div>
                                        <div class="stepWrapper_3b103">
                                            <div class="stepperLine_3cb5f stepperLineLeft_a18a6"></div>
                                            <div class="stepperLine_3cb5f stepperLineRight_77c82 stepperLineLast_f07b4"></div>
                                            <div class="stepNumberLabelWrapper_779ef stepNumberLabelWrapperLast_ee77c">
                                                <div class="stepNumber_70f3d">3</div>
                                                <div class="stepLabel_9786e">Join Contests</div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="titleBox_583d4 titleBoxMarginOnboarding_b0835">
                                        <div>
                                            <div class="bold"><span>Choose</span><span class="rolesTitle_48372"> your Captain &amp; Vice Captain</span></div>
                                            <div class="create-team-role-selector__subtitle">
                                                <div class="subtitleContainer_b9ae4">
                                                    <div class="roleSubtitle_62c2d">
                                                        <div class="roleIcon_f75d0">C</div>
                                                        <div class="roleMultiplierText_07275"> gets 2X Points</div>

                                                    </div>
                                                    <div class="roleSubtitle_62c2d">
                                                        <div class="roleIcon_f75d0">VC</div>
                                                        <div class="roleMultiplierText_07275"> gets 1.5X Points</div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="sortingHeader_00815 sortingHeaderWebkit_3d076 sortingHeaderTopOnboarding_b9618">
                                            <div class="sortingHeaderText_b2267">Sort By:</div>
                                            <div class="sortingHeaderButtons_029e0">
                                                <div class="sortingButton_8525f">
                                                    <button class="new-button whiteBgGreyTextFlatButton_7df6c whiteBgGreyTextFlatButtonActive_b0a61">Player Types</button>
                                                </div>
                                                <div class="sortingButton_8525f">
                                                    <button class="new-button whiteBgGreyTextFlatButton_7df6c">Points</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!--display selected player list-->
                                    <v-card v-for="player in selectedplayer" :key="player.playerId">
                                        <div class="create-team__team-selector__player-list">
                                            <div class="js--create-team__team-selector__player-card onboarding--player-card-0 playerCard_42b9d">
                                                <div class="playerCardCell_bf9d8 playerCardAvatarCell_2b8d1">
                                                    <div class="imageContainer_029e0">
                                                        <div class="playerImageProfile_43b1b">
                                                            <div class="playerImageContainer_6e52e">
                                                                <div class="playerImage_f320d">
                                                                    <b-img v-bind:src="player.image" rounded="circle" style="height: 54px; width: 54px;"></b-img>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="playerCardInfoCell_ba412 playerCardInfoContainer_d41f9">
                                                    <div class="playerCardCell_bf9d8 playerCardNameCell_50086">
                                                        <div>
                                                            <div class="playerName_73cad">{{player.firstName}} {{player.lastName}}</div>
                                                            <div class="playerTeamTitle_a2024"><span>CSK</span><span class="light">- WK</span></div>
                                                        </div>
                                                    </div>
                                                    <div class="playerCardCell_bf9d8 playerPointsCell_aa0e3">{{player.points}}</div>

                                                    <div class="bold playerCardIconContainer_65be8">
                                                  <input type="radio" v-model="player.isCaptain" name="profileImg"  id="materialInline1" :value="player.playerid" v-on:click="SelectCaption(player)">C
                                                  <input type="radio" v-model="player.isViceCaptain" name="profileImg1"  id="materialInline2" :value="player.playerid" v-on:click="SelectViceCaption(player)">Vc
                                                        <!--<v-radio-group v-model="player.playerId">
                                                        <v-radio v-if="player.isSelected != false" value="radio-1"></v-radio>
                                                        <v-radio v-if="player.isCaptain == false" value="player.playerid" v-on:click="SelectCaption(player)">c</v-radio>
                                                        <v-radio v-if="player.isViceCaptain == false" value="player.playerid" v-on:click="SelectViceCaption(player)">vc</v-radio>
                                                    </v-radio-group>-->
                                                    </div>                
                                                </div>
                                            </div>
                                        </div>
                                    </v-card>

                                    <div class="text-xs-center">
                                        <v-btn round color="blue" v-on:click="saveTo()">Save Team</v-btn>  <!--:enabled="check"-->
                                        
                                    </div>

                                </div>
                            </div>
                        </div>                       
                    </div>
                </div>
            </div>
        </div>

        <!--Right side div for selected player list display-->
      <app-teampreview></app-teampreview>
    </div>



</template>

<script>
    import teampreview from './teampreview.vue'
    import EventBus from '../caption.js'
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'

    export default {
        name: 'SelectCaption',
        components: {
            'app-teampreview': teampreview
        },
       
        data() {
            return {
                selectedplayer: this.$store.getters.selectedplayer,
                btnicon: true,
                row: null,
               
                isSelected: false,
                temp:[]
            }
        }, created() {

            //axios
            //    .get('http://idtp376.synerzipune.local:9015/api/players/' + this.matchid)
            //    .then(response => {
            //        this.players = response.data
            //    })
            //this.$http.get(`players/` + this.matchid)
            //    .then(response => {
            //        this.players = response.data
            //    })
            //    .catch(e => {
            //        this.errors.push(e)
            //    })
        },
        mounted() {
            EventBus.$on('DATA_PUBLISHED', (payload) => {
                this.updateData(payload);
                //this.players = payload;
            })

            //EventBus.$on('DATA_PUBLISHED', (payload) => {
            //    this.list = payload.selectedplayer;
            //})
            //axios
            //    .get('http://idtp376.synerzipune.local:8778/api/players/' + this.matchid)
            //    .then(response => {
            //        this.players = response.data
            //    })

        },
        methods: {         
            updateData(payload) {
                this.selectedplayer = payload
            },
            saveTo: function ()
            {
                
                this.$router.replace({ name: "JoinContests" });
                this.$store.commit('saveTo', this.selectedplayer);
               
            },
            SelectCaption: function (player) {
                var i;
                for (i = 0; i<this.selectedplayer.length; i++) {
                    if (player.playerId == this.selectedplayer[i].playerId)
                    {     
                        //this.$store.selectedplayer[i].isCaptain = true;
                        this.selectedplayer[i].isCaptain = true;
                        this.selectedplayer[i].isViceCaptain = false;
                       // this.$store.dispatch("SelectCaption", this.selectedplayer);
                       // this.$store.commit('saveTo', this.selectedplayer);
                       
                    }                    
                }
            },
            SelectViceCaption: function (player) {               
                var i;
                for (i = 0; i < this.selectedplayer.length; i++) {                  
                    if (player.playerId == this.selectedplayer[i].playerId) {                     
                        this.selectedplayer[i].isViceCaptain = true;
                        this.selectedplayer[i].isCaptain = false;
                       // this.$store.dispatch("SelectViceCaption", this.selectedplayer);
                        //this.$store.commit('saveTo', this.selectedplayer);
                       
                       
                    }
                }
            }
        }
    };

</script>

<style>

    .sortingButton_8525f {
        margin-left: 12px;
    }
    sortingHeaderTopOnboarding_b9618 {
        top: 104px;
    }
    .sortingHeader_00815 {
        display: flex;
        align-items: center;
        color: #acacac;
        padding-left: 16px;
        height: 56px;
        font-size: 12px;
        background-color: #efeff4;
        border-bottom: 1px solid #e8e8e8;
        position: sticky;
    }
    .sortingHeaderText_b2267 {
        display: flex;
        font-size: 12px;
        color: #282828;
    }
    .sortingHeaderButtons_029e0 {
        display: flex;
    }
    
    .whiteBgGreyTextFlatButton_7df6c {
        background-color: #fff;
        color: #282828;
        height: 36px;
        border-radius: 4px;
        padding: 10px;
        font-size: 12px;
        border-color:green;
    }
    .roleIcon_b2caf {
        height: 40px;
        width: 40px;
        border-radius: 50%;
        border: 1px solid #9b9b9b;
        display: flex;
        color: #9b9b9b;
        justify-content: center;
        align-items: center;
    }
    .roleSelected_961ad {
        background-color: #000;

        color: #fff;
    }
    .v-card {
        box-shadow: 0px 3px 1px -2px rgba(0,0,0,0.2), 0px 2px 2px 0px rgba(0,0,0,0.14), 0px 1px 5px 0px rgba(0,0,0,0.12);
        text-decoration: none;
    }

    .playerCard {
        background-color: #fff;
        display: flex;
        height: 72px;
        padding-left: 16px;
    }

    .titleBoxMarginOnboarding_b0835 {
        margin-top: 104px;
    }

    .titleBox_583d4 {
        max-width: 5150px;
        padding: 16px;
        text-align: center;
        margin: 9px;
        margin-left: -15px;
        margin-right: -20px;
        border-bottom: 1px solid #dcdcdc;
        background-color: #efeff4;
    
       
    }
    whiteBgGreyTextFlatButtonActive_b0a61 {
        border-color: #25ba38;
        color: #282828;
    }

    .activeStepper_2007e {
        background-color: #00a037;
    }

    .activeNumber_89478 {
        font-size: 12px;
        color: #fff;
        transform: skew(20deg);
    }



    .row {
        display: flex;
        flex-wrap: wrap;
        margin-right: -15px;
        margin-left: -30px;
    }
    /*.headerFixed_38df7 {
        position: fixed;
        top: 0;
        max-width: 550px;
        width: 100%;
    }*/
    div {
        display: block;
    }

    .flexContainer_029e0 {
        display: flex;
    }

    .selectedCount_e68c1 {
        font-size: 24px;
        color: #fff;
        transition: transform 0.2s;
        transform-origin: left top;
    }

    .infoContent_9a018 {
        display: flex;
        justify-content: space-around;
        margin: 0px 16px;
    }

    .totalCount_5e151 {
        font-size: 12px;
        padding-top: 10px;
        transition: transform 0.2s;
        transform-origin: left top;
    }

    .flexContainer_029e0 {
        display: flex;
    }

    .squadContainer_7ce16 {
        display: flex;
        align-items: center;
    }

    .playerSelectionContainer_bdd92 {
        display: flex;
        flex-direction: column;
        color: #acacac;
        font-size: 12px;
    }


    .infoContent_9a018 {
        display: flex;
        justify-content: space-around;
        margin: 0px 16px;
    }

    .leftInfoContent_8b4f7 {
        display: flex;
        flex: 1;
        justify-content: space-between;
        margin-right: 8px;
    }


    .maxInfoText_19e12 {
        font-size: 12px;
        color: #fff;
        display: flex;
        align-self: center;
        transform-origin: top;
        height: 36px;
        align-items: center;
        transition: transform 0.2s;
    }



    .headerContainer_85dde {
        background: linear-gradient(104deg, #3c3c3c 50%, #323232 50%);
        display: flex;
        flex-direction: column;
        z-index: 2;
        margin-top:-24px;
    }

    .defaultHeaderContent_00a63 {
        display: flex;
        justify-content: space-between;
        color: #FFF;
        height: 48px;
    }

    element.style {
    }

    .onboardingHeader_40bc5 {
        height: 56px;
        display: flex;
        padding: 8px 16px;
    }



    .container_b87ae {
        display: flex;
        flex-direction: column;
    }

    .containerExtended_cdca5 {
        height: 136px;
    }

    body {
        background-color: #fafafa;
        color: var(--color);
        font-family: 'Montserrat', sans-serif, -apple-system, BlinkMacSystemFont, “Segoe UI”, Roboto, “Helvetica Neue”, Ubuntu, Arial, sans-serif;
        font-size: var(--font-medium);
        /* font-weight: 500; */
        user-select: none;
    }

    .squadFlagContainer_47acd {
        display: flex;
        align-items: center;
        justify-content: space-around;
        margin: 0 4px;
    }

    .flag_008b5 {
        width: 44px;
        height: 44px;
        border-radius: 50%;
    }

    .squadOneText_3ad2c {
        display: flex;
        flex-direction: column;
        color: #acacac;
        margin-left: 4px;
    }

    .teamName_a2024 {
        font-size: 12px;
    }

    .teamCountExtended_8b6e8 {
        margin-top: 4px;
    }

    .rightInfoContent_579f7 {
        display: flex;
        flex: 1;
        justify-content: space-between;
        margin-left: 8px;
    }

    .squadContainer_7ce16 {
        display: flex;
        align-items: center;
    }

    .creditsContainer_9c26e {
        display: flex;
        flex-direction: column;
        color: #acacac;
        font-size: 12px;
        text-align: right;
    }


    .creditsContainer_9c26e {
        display: flex;
        flex-direction: column;
        color: #acacac;
        font-size: 12px;
        text-align: right;
    }

    .creditsText_4bef4 {
        color: #fff;
        display: flex;
        justify-content: flex-end;
        font-size: 24px;
        transition: transform 0.2s;
        transform-origin: right top;
    }

    .rightInfoContent_579f7 {
        display: flex;
        flex: 1;
        justify-content: space-between;
        margin-left: 8px;
    }

    .progressContainer_00657 {
        margin: 24px 16px 16px;
    }

    .stepperContainer_b9ae4 {
        display: flex;
        justify-content: center;
    }

    .activeStepper_2007e {
        background-color: #00a037;
    }

    .stepperBlock_8b62f {
        width: 36px;
        height: 16px;
        font-size: 12px;
        transform: skew(-20deg);
        border: 1px solid #323232;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .activeNumber_89478 {
        font-size: 12px;
        color: #fff;
        transform: skew(20deg);
    }

    .inactiveStepper_4d390 {
        background-color: #fff;
    }

    .stepNumberLabelWrapperLast_ee77c {
        align-self: flex-end;
    }

    .container_b87ae {
        display: flex;
        flex-direction: column;
    }

    .containerExtended_cdca5 {
        height: 136px;
    }

    .headerLeft_97209 {
        display: flex;
        flex: 1 0 0;
        justify-content: flex-start;
        align-items: center;
        margin-left: 16px;
    }

    .whiteIconButton_6998a {
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
        font-size: 14px;
        height: 32px;
        padding: 0px;
    }

    .stepLabel_9786e {
        display: flex;
        color: #969696;
        font-size: 10px;
    }

    * {
        box-sizing: border-box;
        -webkit-tap-highlight-color: transparent;
    }


    element.style {
        height: 24px;
        width: 24px;
        font-size: 24px;
    }

    .ctAppHeaderRight_029e0 {
        display: flex;
    }

    .headerRight_b78f0 {
        display: flex;
        flex: 1 0 0;
        justify-content: flex-end;
        align-items: center;
        margin-right: 16px;
    }

    .floatingAnchorButton_fac02 {
        font-weight: 600;
        text-decoration: none;
        color: #3759a5;
    }

    .helpLink_4c95c {
        display: flex;
        justify-content: center;
        align-items: center;
        height: 24px;
        width: 24px;
        border: solid 1px #acacac;
        border-radius: 50%;
        color: #acacac;
    }

    .onboardingHeader_40bc5 {
        height: 56px;
        display: flex;
        padding: 8px 16px;
    }

    .mainContainer_3ec17 {
        width: 100%;
    }

    .stepsContainer_b7305 {
        display: flex;
        justify-content: space-between;
        height: 100%;
    }

    .stepWrapper_3b103 {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        position: relative;
        flex: 1;
        height: 100%;
    }

    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineFirst_1e88e {
        margin-left: 30px;
    }

    .stepperLineLeft_a18a6 {
        left: 0%;
    }

    .stepperLine_3cb5f {
        height: 2px;
        width: 50%;
        top: 9px;
        position: absolute;
        background: #dcdcdc;
        z-index: 1;
    }

    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineRight_77c82 {
        left: 50%;
    }

    .stepperLine_3cb5f {
        height: 2px;
        width: 50%;
        top: 9px;
        position: absolute;
        background: #dcdcdc;
        z-index: 1;
    }

    .stepNumberLabelWrapperFirst_c475a {
        align-self: flex-start;
    }

    .stepNumberLabelWrapper_779ef {
        align-items: center;
        display: flex;
        align-self: center;
        flex-direction: column;
        min-width: 60px;
        justify-content: space-between;
        height: 100%;
        z-index: 2;
    }

    .stepNumberActive_e02df {
        color: #fff;
        background: #00b137;
    }

    .stepNumber_70f3d {
        background: #dcdcdc;
        color: #969696;
        width: 20px;
        height: 20px;
        border-radius: 20px;
        display: flex;
        justify-content: center;
        align-items: center;
        font-size: 10px;
    }


    .stepNumberActive_e02df {
        color: #fff;
        background: #00b137;
    }

    .stepLabel_9786e {
        display: flex;
        color: #969696;
        font-size: 10px;
    }

    .stepWrapper_3b103 {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        position: relative;
        flex: 1;
        height: 100%;
    }

    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineLeft_a18a6 {
        left: 0%;
    }

    .stepperLine_3cb5f {
        height: 2px;
        width: 50%;
        top: 9px;
        position: absolute;
        background: #dcdcdc;
        z-index: 1;
    }

    .stepperLineRight_77c82 {
        left: 50%;
    }

    .stepperLine_3cb5f {
        height: 2px;
        width: 50%;
        top: 9px;
        position: absolute;
        background: #dcdcdc;
        z-index: 1;
    }

    .stepNumberLabelWrapperFirst_c475a {
        align-self: flex-start;
    }

    .stepNumberActive_e02df {
        color: #fff;
        background: #00b137;
    }

    .stepLabelWhiteActive_3d48d {
        color: #fff;
    }

    .stepLabel_9786e {
        display: flex;
        color: #969696;
        font-size: 10px;
    }

    .stepWrapper_3b103 {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        position: relative;
        flex: 1;
        height: 100%;
    }


    .whiteIconButton_6998a {
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
        font-size: 14px;
        height: 32px;
        padding: 0px;
    }

    element.style {
        height: 24px;
        width: 24px;
        font-size: 24px;
    }

    .teamCount_bfa59 {
        font-size: 16px;
        color: #fff;
    }

    .squadTwoText_b9766 {
        display: flex;
        flex-direction: column;
        color: #acacac;
        margin-left: 4px;
        align-items: flex-end;
        margin-right: 4px;
    }

    .stepperLineLast_f07b4 {
        margin-left: -90px;
    }

    .stepperLineRight_77c82 {
        left: 50%;
    }

    .stepperLine_3cb5f {
        height: 2px;
        width: 50%;
        top: 9px;
        position: absolute;
        background: #dcdcdc;
        z-index: 1;
    }

    .create-team-role-selector__subtitle {
        color: #7b7a7a;
        font-size: var(--font-small);
        margin: 4px 0 0 0;
    }

    .relative {
        position: relative;
    }

    .subtitleContainer_b9ae4 {
        display: flex;
        justify-content: center;
    }

    .roleSubtitle_62c2d {
        display: flex;
        padding: 0 8px;
    }

    .roleIcon_f75d0 {
        width: 24px;
        height: 24px;
        border-radius: 50%;
        display: flex;
        align-items: center;
        justify-content: center;
        border: 1px solid #9b9b9b;
        color: #9b9b9b;
        font-size: 10px;
        margin-right: 8px;
    }

    .roleMultiplierText_07275 {
        color: #000;
        margin-top: 4px;
    }

    .roleSubtitle_62c2d {
        display: flex;
        padding: 0 8px;
    }

    .create-team-role-selector__subtitle {
        color: #7b7a7a;
        font-size: var(--font-small);
        margin: 4px 0 0 0;
    }


    .absolute {
        position: absolute;
    }

    .tabwidth {
        width: 575px;
    }

    .create-team__team-selector__player-list {
        flex: 1 0 0;
    }

    .playerCard_42b9d {
        background-color: #fff;
        display: flex;
        height: 72px;
        padding-left: 16px;
        transition: background-color 300ms cubic-bezier(0, 2, 1, 1);
    }

    .playerCardAvatarCell_2b8d1 {
        flex: 0 0 60px;
    }

    .playerCardCell_bf9d8 {
        display: flex;
        align-items: center;
        white-space: nowrap;
        text-overflow: ellipsis;
        overflow: hidden;
    }

    .imageContainer_029e0 {
        display: flex;
    }

    .playerImageProfile_43b1b {
        height: 48px;
        width: 48px;
    }

    .playerImageContainer_6e52e {
        display: flex;
        flex-direction: column;
        overflow: hidden;
        height: 100%;
        width: 100%;
    }

    .playerImage_f320d {
        width: 100%;
        flex: 1;
        background-size: cover;
        background-repeat: no-repeat;
        border-radius: 50%;
        background-color: #969696;
    }

    .playerCardInfoContainer_d41f9 {
        border-bottom: 1px solid #e8e8e8;
    }

    .playerCardInfoCell_ba412 {
        display: flex;
        flex-grow: 1;
    }

    .playerCardNameCell_50086 {
        flex-grow: 3;
        flex-basis: 80px;
    }

    .playerCardCell_bf9d8 {
        display: flex;
        align-items: center;
        white-space: nowrap;
        text-overflow: ellipsis;
        overflow: hidden;
    }

    .playerName_73cad {
        flex-basis: 44px;
        justify-content: center;
        color: #00a0ff;
    }

    .playerTeamTitle_a2024 {
        font-size: 12px;
    }

    .playerPointsCell_aa0e3 {
        flex-grow: 1;
        flex-basis: 60px;
        justify-content: center;
    }

    .playerCardCell_bf9d8 {
        display: flex;
        align-items: center;
        white-space: nowrap;
        text-overflow: ellipsis;
        overflow: hidden;
    }

    .playerPointsCell_aa0e3 {
        flex-grow: 1;
        flex-basis: 60px;
        justify-content: center;
    }

    .playerCardCell_bf9d8 {
        display: flex;
        align-items: center;
        white-space: nowrap;
        text-overflow: ellipsis;
        overflow: hidden;
    }

    .bold {
        font-weight: bold;
    }

    .playerCardIconContainer_65be8 {
        display: flex;
        flex-basis: 70px;
        justify-content: center;
        margin: 10px 0;
        border-left: 1px solid #e8e8e8;
    }

    .playerCardIconDisabled_a0371 {
        color: #888;
    }

    .playerCardDisable_84b1d {
        opacity: 0.5;
    }

    .playerCardSelected_ae508 {
        background-color: #fff7ec;
    }

    .playerCardIconSelected_4b666 {
        color: #ffa500;
    }

    .playerCardIcon_b8a19 {
        border-radius: 50%;
        color: #24ba38;
        align-self: center;
        border: 1px solid;
    }

    .materialIcon_10a4f {
        font-family: Material Icons;
        font-weight: normal;
        font-style: normal;
        display: inline-block;
        line-height: 1.3;
        text-transform: none;
        letter-spacing: normal;
        word-wrap: normal;
        white-space: nowrap;
        direction: ltr;
    }

    /*<!-- right side css for selected player display-- >*/

    .desktopTeamPreviewContainer_25c6c {
        left: 575px;
        width: 550px;
        overflow-y: hidden;
    }

    .teamPreviewContainer_cdfeb {
        position: fixed;
        top: 0;
        height: 100%;
    }

    .containerWithoutHeader_0f1f0 {
        height: 100%;
        min-height: 100%;
    }

    .content_eaf85 {
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
        display: flex;
        flex-direction: column;
    }

    .playerArea_eac11 {
        position: relative;
        height: 100%;
        overflow: scroll;
    }

    .tall_a7bdc {
        position: absolute;
        top: 0;
        left: 0;
        min-height: 100%;
        width: 100%;
        display: flex;
        flex-direction: column;
        justify-content: space-evenly;
        padding: 20px 0;
    }

    .teamPreviewRowWrapper_0c54c {
        width: 100%;
        padding-top: 8px;
    }

    .rowTitle_b91f3 {
        margin-bottom: 4px;
        text-align: center;
        color: #fff;
        text-transform: uppercase;
        font-size: var(--font-small);
        opacity: 0.52;
    }

    .rowContent_8aa5f {
        display: flex;
        justify-content: space-evenly;
        align-items: center;
        padding: 8px 0;
        height: 85px;
    }

    .spaceAround_64779 {
        justify-content: space-around;
    }

    .fieldPlayerMain_32975 {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .playerImageProfile_0cc1f {
        height: 38px;
        width: 38px;
        border-radius: 10px 0;
        position: relative;
    }

    .imageProfileContainer_6e52e {
        display: flex;
        flex-direction: column;
        overflow: hidden;
        height: 100%;
        width: 100%;
    }

    .player-image-profile__image {
        width: 100%;
        flex: 1;
        background-size: cover;
        background-repeat: no-repeat;
        border-radius: 10px 10px 0 0;
    }

    .playerTitleContainer_cbc2d {
        position: relative;
    }

    .homeTeamPlayerTitle_c0c14 {
        background-color: #282828;
        color: #fff;
    }

    .fieldPlayerTitle_75d21 {
        width: 65px;
        overflow: hidden;
        text-overflow: ellipsis;
        text-align: center;
        font-size: var(--font-small);
        white-space: nowrap;
        box-shadow: 0 2px 2px 0 rgba(0, 0, 0, 0.25);
        border-radius: 2px;
        padding: 0px 4px;
        height: 20px;
        line-height: 20px;
    }

    .playerPoints_d4e06 {
        white-space: nowrap;
        color: #fff;
        text-align: center;
        padding: 2px;
        font-size: var(--font-small);
    }

    .createTeamTabsHelpContainer_ce9c9 {
        height: 44px;
        display: flex;
        align-items: center;
        color: #000;
        justify-content: center;
        background-color: #efeff4;
    }
</style>