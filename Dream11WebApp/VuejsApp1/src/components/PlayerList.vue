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
                                                    <i class="materialIcon_10a4f" style="height: 10px; width: 10px; font-size: 10px;">check</i>
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
                                        </div><div class="stepWrapper_3b103">
                                            <div class="stepperLine_3cb5f stepperLineLeft_a18a6"></div>
                                            <div class="stepperLine_3cb5f stepperLineRight_77c82 stepperLineLast_f07b4"></div>
                                            <div class="stepNumberLabelWrapper_779ef stepNumberLabelWrapperLast_ee77c"><div class="stepNumber_70f3d">3</div><div class="stepLabel_9786e">Join Contests</div></div>
                                        </div>
                                    </div>
                                </div>
                            </div><div>
                                <div class="onboarding--info-header container_b87ae containerExtended_cdca5">
                                    <div class="maxInfoText_19e12">Max 7 players from a team</div><div class="infoContent_9a018">
                                        <div class="leftInfoContent_8b4f7">
                                            <div class="playerSelectionContainer_bdd92">
                                                <div>Players</div>
                                                <div class="flexContainer_029e0">
                                                    <div class="selectedCount_e68c1">{{selectedplayer.length}}</div>
                                                    <div class="totalCount_5e151">/11</div>
                                                </div>
                                            </div><div class="squadContainer_7ce16">
                                                <div class="squadFlagContainer_47acd">
                                                    <img src="https://d13ir53smqqeyp.cloudfront.net/flags/cr-flags/MI-CR3@2x.png" class="flag_008b5">
                                                </div><div class="squadOneText_3ad2c"><div class="teamName_a2024">MI</div><div class="teamCount_bfa59 teamCountExtended_8b6e8">0</div></div>
                                            </div>
                                        </div>
                                        <div class="rightInfoContent_579f7">
                                            <div class="squadContainer_7ce16">
                                                <div class="squadTwoText_b9766">
                                                    <div class="teamName_a2024">RCB</div>
                                                    <div class="teamCount_bfa59 teamCountExtended_8b6e8">1</div>
                                                </div>
                                                <div class="squadFlagContainer_47acd"><img src="https://d13ir53smqqeyp.cloudfront.net/flags/cr-flags/BRC-CR3@2x.png" class="flag_008b5"></div>
                                            </div><div class="creditsContainer_9c26e">
                                                <div>Credits Left</div>
                                                <div class="creditsText_4bef4">{{totalcredit}}</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="progressContainer_00657">
                                        <div class="stepperContainer_b9ae4">
                                            <div :class="[ (selectedplayer.length > 0) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 1" class="activeNumber_89478">1</span></div>
                                            <div :class="[ (selectedplayer.length > 1) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 2" class="activeNumber_89478">2</span></div>
                                            <div :class="[ (selectedplayer.length > 2) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 3" class="activeNumber_89478">3</span></div>
                                            <div :class="[ (selectedplayer.length > 3) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 4" class="activeNumber_89478">4</span></div>
                                            <div :class="[ (selectedplayer.length > 4) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 5" class="activeNumber_89478">5</span></div>
                                            <div :class="[ (selectedplayer.length > 5) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 6" class="activeNumber_89478">6</span></div>
                                            <div :class="[ (selectedplayer.length > 6) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 7" class="activeNumber_89478">7</span></div>
                                            <div :class="[ (selectedplayer.length > 7) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 8" class="activeNumber_89478">8</span></div>
                                            <div :class="[ (selectedplayer.length > 8) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 9" class="activeNumber_89478">9</span></div>
                                            <div :class="[ (selectedplayer.length > 9) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]"><span v-show="selectedplayer.length === 10" class="activeNumber_89478">10</span></div>
                                            <div :class="[ (selectedplayer.length > 10) ? 'stepperBlock_8b62f activeStepper_2007e' : 'stepperBlock_8b62f inactiveStepper_4d390' ]">
                                                <span class="lastStepper_2bce1">11</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>         
            </div>
            <template>
                <v-tabs v-model="tab"
                        color="white">
                    <v-tabs-slider color="red"></v-tabs-slider>

                    <v-tab v-for="item in items"
                           :key="item.typeid" v-on:click="playertype(item.typeName)">
                        {{ item.typeName }}
                        <div v-if="item.typeid==1" class="createTeamTabsCount_19658" v-on:click="ChoicePlayer()">({{wcount}})</div>
                        <div v-if="item.typeid==2" class="createTeamTabsCount_19658" v-on:click="ChoicePlayer()">({{batc}})</div>
                        <div v-if="item.typeid==3" class="createTeamTabsCount_19658" v-on:click="ChoicePlayer()">({{allrounderc}})</div>
                        <div v-if="item.typeid==4" class="createTeamTabsCount_19658" v-on:click="ChoicePlayer()">({{bowlerc}})</div>

                    </v-tab>
                </v-tabs>
            </template>


            <v-tabs-items v-model="tab">
                <v-tab-item v-for="item in items"
                            :key="item.typeid">

                    <div v-if="item.typeid==1" class="createTeamTabsHelpContainer_ce9c9">Pick 1 Wicket-Keeper</div>
                    <div v-if="item.typeid==2" class="createTeamTabsHelpContainer_ce9c9">Pick 3-5 Batsmen</div>
                    <div v-if="item.typeid==3" class="createTeamTabsHelpContainer_ce9c9">Pick 1-3 AllRounder</div>
                    <div v-if="item.typeid==4" class="createTeamTabsHelpContainer_ce9c9">Pick 3-5 bowlers</div>
                    <div class="ctSortingHeader_a6515">
                    <div class="playerCardCell_bf9d8 playerCardAvatarCell_2b8d1"></div>
                    <div class="playerCardInfoCell_ba412"><div class="playerCardCell_bf9d8 playerCardNameCell_50086"><span>PLAYERS</span></div>
                        <div class="playerCardCell_bf9d8 playerPointsCell_aa0e3"><span>POINTS</span></div>
                        <div class="playerCardCell_bf9d8 playerPointsCell_aa0e3 activeSortKey_c7202"><span>CREDITS<span>
                            <i class="materialIcon_10a4f" style="height: 10px; width: 10px; font-size: 10px;">arrow_downward</i>
                               </span></span>
                        </div>
                        <div class="sortingHeaderIconPlaceHolder_43273">
                        </div>
                        </div>
                    </div>
              
                    <!--display player list as tab changes retrive on the card-->
                    <v-card v-for="playerB in PlayerTypeList" :key="playerB.playerId" v-on:click="ChoicePlayer(playerB)">
                        <div class="create-team__team-selector__player-list">
                            <div class="js--create-team__team-selector__player-card onboarding--player-card-0 playerCard_42b9d">
                                <div class="playerCardCell_bf9d8 playerCardAvatarCell_2b8d1">
                                    <div class="imageContainer_029e0">
                                        <div class="playerImageProfile_43b1b">
                                            <div class="playerImageContainer_6e52e">
                                                <div class="playerImage_f320d">
                                                    <b-img v-bind:src="playerB.image" rounded="circle" style="height: 54px; width: 54px;"></b-img>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="playerCardInfoCell_ba412 playerCardInfoContainer_d41f9">
                                    <div class="playerCardCell_bf9d8 playerCardNameCell_50086">
                                        <div>
                                            <div class="playerName_73cad">{{playerB.firstName}} {{playerB.lastName}}</div>
                                            <div class="playerTeamTitle_a2024"><span>{{playerB.team.teamName}}</span><span class="light">-{{playerB.playerRoleName}}</span></div>
                                        </div>
                                    </div>
                                    <div class="playerCardCell_bf9d8 playerPointsCell_aa0e3">{{playerB.points}}</div>
                                    <div class="playerCardCell_bf9d8 playerPointsCell_aa0e3">{{playerB.credits}}</div>
                                    <div class="bold playerCardIconContainer_65be8">
                                        <div class="playerCardIcon_b8a19">
                                            <div style="display:none">{{playerB.playerId}}</div>
                                            <i v-if="playerB.isSelected != true" class="materialIcon_10a4f" style="height: 24px; width: 24px; font-size: 24px;">add</i>
                                            <i v-else class="materialIcon_10a4f" style="height: 24px; width: 24px; font-size: 24px;">remove</i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </v-card>
                </v-tab-item>
            </v-tabs-items>
            <div class="text-xs-center">
                <v-btn round  color="blue" :disabled="check" v-on:click="saveTo()">continue</v-btn>
            </div>
        </div>
        <!--Right side div for selected player list display-->
        <app-teampreview></app-teampreview>


    </div>
</template>

<script>
   // import axios from 'axios';
    import teampreview from './teampreview.vue';
    import { HTTP } from '../HttpComman.js';
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    //import  EventBus  from '../caption.js';


    //import { debug } from 'util';
    //import { pipeline } from 'stream';
    export default {
        name: 'PlayerList',
        components: {
            'app-teampreview': teampreview
        },
        data() {
            return {               
                count: [],              
                btnicon: true,
                check:true,
                totalcredit: 100,
                selectedplayer: this.$store.getters.selectedplayer,
                matchid: this.$route.params.matchid,
                type: 0,
                Name: null,              
                players: [],
                PlayerTypeList: [],
                WicketKeeper: [],
                wcount :0,
                 batc :0,
                 bowlerc :0,
                allrounderc: 0,
                countTeamlist:0,
                tab: null,
                items: [{ typeid: 1, typeName: 'WK' }, { typeid: 2, typeName: 'Bat' }, { typeid: 3, typeName: 'Allrounder' }, { typeid: 4, typeName: 'Bowler' }],
            }
        },
        
            
            created() {
            //axios
            //    .get('http://idtp376.synerzipune.local:9015/api/players/' + this.matchid)
            //    .then(response => {
            //        this.players = response.data
            //    })
            
            HTTP.get(`players/` + this.matchid)
                    .then(response => {
                        this.players = response.data
                        this.playertype('WK');
                    })
                    .catch(e => {
                        this.errors.push(e)
                    })
                      
           //return this.WicketKeeper = this.player.playerRoleName.filter(this.typeName = 'WK')
             
               
               
               
                
           
        },
        mounted() {
            //axios
            //    .get('http://idtp376.synerzipune.local:8778/api/players/' + this.matchid)
            //    .then(response => {
            //        this.players = response.data
            //    })

        },
        methods: {
            //created: function ()
            //{
            //},
  
            playertype: function (playerRole) {
                if (this.selectedplayer.length > 0) {
                   // this.WicketKeeper = null;

                    

                    this.PlayerTypeList = this.players.filter(function (player) {
                        return player.playerRoleName === playerRole
                    })
                    var i;
                    for (i = 0; this.selectedplayer.length; i++) {
                        var objIndex = this.PlayerTypeList.findIndex((obj => obj.playerId == this.selectedplayer[i].playerId));
                        if (objIndex >= 0) {
                            this.PlayerTypeList[objIndex].isSelected = true
                        }
                    }
                    return this.PlayerTypeList;
                }
                else {

                    //this.WicketKeeper = null;
                    return this.PlayerTypeList = this.players.filter(function (player) {
                        return player.playerRoleName === playerRole
                    })
                }
            },
            ChoiceWicketkeeper: function (Name) {
                this.selectedplayer.push(Name);
            },
            ChoicePlayer: function (Player) {              
                 this.count = this.SelectedTypeTeam(Player.playerRoleName);
                //count for mumber of players selected for particular team in header
                this.countTeamlist = this.CountTeam(Player.team.teamName);
                //this.teamc == countTeamlist;
               
                
                switch (Player.playerRoleName) {
                    case 'WK':
                        if (this.count.length <= 0 && this.wcount <= 1)
                        {
                            this.AddandRemoveSelectedPlayer(Player);
                        }
                     
                        else {
                            alert('you can select only 1 wicketkeeper');
                        }
                        break;
                     case 'Bat':
                        if (this.count.length <= 3 && this.batc<=3) {
                            this.AddandRemoveSelectedPlayer(Player);
                        }
                        else {
                            alert('you can select upto 5 bastmen');
                           
                        }
                        break;
                    case 'Allrounder':
                        if (this.count.length <= 2 && this.allrounderc<=2) {
                            this.AddandRemoveSelectedPlayer(Player);
                        }
                        else {
                            alert('you can select only 3 Allrounder');
                        }
                        break;
                    case 'Bowler':
                        if (this.count.length <= 3 && this.bowlerc<=3) {
                            this.AddandRemoveSelectedPlayer(Player);
                        }
                        else {
                            alert('you can select only 4 Bowler');
                        }
                        break;
                }
            },

            SelectedTeam: function (playertype) {
                return this.selectedplayer.filter(function (player) {
                    return player.playerRoleName === playertype
                })
            },
            SelectedTypeTeam: function (playertype) {
                return this.selectedplayer.filter(function (player) {
                    return player.playerRoleName === playertype
                })
            },
            CountTeam: function (playertype) {
                return this.selectedplayer.filter(function (player) {
                    return player.team.teamName === playertype
                })
            },
            AddandRemoveSelectedPlayer: function (Player) {
                var playerItem = document.getElementsByClassName("playerCardIcon_b8a19");
                var i;
                for (i = 0; i < playerItem.length; i++) {
                    if (playerItem[i].children[0].innerText == Player.playerId && playerItem[i].children[1].innerText == 'remove') {
                        this.count = this.count - 1;
                        var removeplayer = this.selectedplayer.includes(Player);
                        if (removeplayer == true) {
                            if (Player.playerRoleName == 'WK') {
                                this.wcount = this.wcount - 1;
                            }
                            else if (Player.playerRoleName == 'Bat') {
                                this.batc = this.batc - 1;
                            }
                            else if (Player.playerRoleName == 'Bowler') {
                                this.bowlerc = this.bowlerc - 1;
                            }
                            else if (Player.playerRoleName == 'Allrounder') {
                                this.allrounderc = this.allrounderc - 1;
                            }
                            else
                            {
                                break;
                            }
                            if (this.totalcredit >= 0)
                            {
                                this.totalcredit = this.totalcredit + Player.credits;

                            }
                            
                            var removeIndex = this.selectedplayer.map(function (item) { return item.playerId; }).indexOf(Player.playerId);
                            this.selectedplayer.splice(removeIndex, 1);
                            var objIndex = this.PlayerTypeList.findIndex((obj => obj.playerId == Player.playerId));
                            if (objIndex >= 0) {
                                this.PlayerTypeList[objIndex].isSelected = true
                            }
                        }
                        playerItem[i].children[1].innerText = "add";
                        continue;
                    }
                    if (playerItem[i].children[0].innerText == Player.playerId && playerItem[i].children[1].innerText == 'add')
                    {
                        Player.isSelected = true;
                        this.count = this.count +1;
                        var checkplayer = this.selectedplayer.includes(Player);
                        if (checkplayer == false) {
                            if (this.selectedplayer.length >= 10) {
                                this.check = false;
                            }
                            if (Player.playerRoleName == 'WK') {
                                this.wcount = this.wcount + 1;
                            }
                            else if (Player.playerRoleName == 'Bat') {
                                this.batc = this.batc + 1;
                            }
                            else if (Player.playerRoleName == 'Bowler') {
                                this.bowlerc = this.bowlerc + 1;
                            }
                            else if(Player.playerRoleName == 'Allrounder')
                            {
                                this.allrounderc = this.allrounderc + 1;
                            }
                            else {
                                break;
                            }
                            if (this.totalcredit >= 0 && this.totalcredit >= Player.credits) {
                                this.totalcredit = this.totalcredit - Player.credits;

                                this.selectedplayer.push(Player);
                            }
                            else {
                                alert("select player with required credit");
                            }
                           
                        }

                        playerItem[i].children[1].innerText = "remove";
                    }

                }
            },
            saveTo: function () {
              
                this.$router.replace({ name: "SelectCaption" });
                //EventBus.$emit('DATA_PUBLISHED', payload)
                this.$store.commit('saveTo',this.selectedplayer);
               
               
            },           
        }
    };

</script>

<style>
    .ctSortingHeader_a6515 {
        display: flex;
        height: 36px;
        color: #acacac;
        font-size: 12px;
        border-bottom: 1px solid #e8e8e8;
        padding-left: 16px;
    }
    .v-tabs__item {
        font-weight: 600;
        padding: 6px 12px;
        padding-top: 6px;
        padding-right: 42px;
        padding-bottom: 6px;
        padding-left: 12px;
    }
        .stepperLineLast_f07b4 {
        margin-left: -30px;
    }

    .stepperLineRight_77c82 {
        left: 50%;
    }
    .stepperLineRight_77c82 {
        left: 50%;
    }

    .stepperLineActive_83254 {
        background: #00b137;
    }
   

    .stepperLineLeft_a18a6 {
        left: 0%;
    }
    .stepperLineLeft_a18a6 {
        left: 0%;
    }

   

    .stepperLineRight_77c82 {
        left: 50%;
    }
    .stepperLineLast_f07b4 {
        margin-left: -30px;
    }

    .stepNumberLabelWrapperLast_ee77c {
        align-self: flex-end;
    }


    .stepWrapper_3b103 {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        position: relative;
        flex: 1;
        height: 100%;
    }
    .createTeamTabsHelpContainer_ce9c9 {
        height: 44px;
        display: flex;
        align-items: center;
        color: #000;
        justify-content: center;
        background-color: #efeff4;
    }
    .activeStepper_2007e {
        background-color: #00a037;
    }

    .activeNumber_89478 {
        font-size: 12px;
        color: #fff;
        transform: skew(20deg);
    }
    .stepperLineActive_83254 {
        background: #00b137;
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

   

    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineFirst_1e88e {
        margin-left: 30px;
    }

    .stepperLineLeft_a18a6 {
        left: 0%;
    }


    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineRight_77c82 {
        left: 50%;
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

    

    .stepperLineActive_83254 {
        background: #00b137;
    }

    .stepperLineLeft_a18a6 {
        left: 0%;
    }

   

    .stepperLineRight_77c82 {
        left: 50%;
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


    .relative {
        position: relative;
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