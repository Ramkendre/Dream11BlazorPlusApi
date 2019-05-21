<template>

    <div>
        <div class="tabwidth">
            <v-toolbar color="white"
                       dark
                       tabs>

                <template v-slot:extension>
                    <v-tabs v-model="tab"
                            color="cyan"
                            grow>
                        <v-tabs-slider color="yellow"></v-tabs-slider>

                        <v-tab v-for="item in items"
                               :key="item">
                            {{ item }}
                        </v-tab>
                    </v-tabs>
                </template>
            </v-toolbar>

            <v-tabs-items v-model="tab">
                <v-tab-item v-for="item in items"
                            :key="item">
                    <div style="margin-top:1px;"></div>
                    <v-card flat>
                        <!--<v-card-text v-for="txt in text"
                    :key="txt"> txt.Name </v-card-text>-->
                        <v-layout>
                            <v-flex xs12>
                                <v-card class="Black--text" v-for="match in matchinfo" :key="match.matchId" v-on:click="navigate(match.matchId)">
                                    <!--v-for="txt in text" :key="txt.id">-->
                                    <v-card-title primary-title>
                                        <div class="row">
                                            <span class="title font-weight-light">{{match.seriesName}}</span>
                                        </div>

                                    </v-card-title>

                                    <v-card flat>
                                        <div class="matchCardMain_954a1">
                                            <div class="flex_029e0">
                                                <div class="flagWrapper_7ce16 flagWrapperLeft_b977f flagWrapperDesktop_f137b" style="background-color: rgb(251, 192, 112);">
                                                    <div class="flagLeftPosition_cac11">
                                                        <div class="lazy-loader lazyLoader_cbc2d lazyLoaderLoaded_80f0a" style="height: 64px; width: 64px;">
                                                            <img v-bind:src="match.teams[0].logo" style="height: 64px; width: 64px;">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="squadShortName_a116b squadShortNameLeft_db179">{{match.teams[0].teamName}}</div>
                                            </div>
                                            <div class="matchCardTimer_a5620 matchCardTimerDesktop_48a55">
                                                <div>{{match.tImeSlot}}s left</div>
                                            </div>
                                            <div class="flex_029e0">
                                                <div class="squadShortName_a116b squadShortNameRight_42ab0">{{match.teams[1].teamName}}</div>
                                                <div class="flagWrapper_7ce16 flagWrapperRight_c02f4 flagWrapperDesktop_f137b" style="background-color: rgb(244, 143, 148);">
                                                    <div class="flagRightPosition_cc260">
                                                        <div class="lazy-loader lazyLoader_cbc2d lazyLoaderLoaded_80f0a" style="height: 64px; width: 64px;">
                                                            <img v-bind:src="match.teams[1].logo" style="height: 64px; width: 64px;">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </v-card>

                                    <v-card-actions>
                                        <v-btn class="Black--text" flat>0 Contest Joined</v-btn>
                                    </v-card-actions>

                                    <div class="cardspace"></div>
                                </v-card>
                            </v-flex>
                        </v-layout>

                    </v-card>
                </v-tab-item>
            </v-tabs-items>
        </div>

        <div class="appBgImage_ceacf"></div>
    </div>


</template>

<script>
   // import axios from 'axios';
    import { HTTP } from '../HttpComman.js';
    export default {
        name: 'Home',

        data() {
            return {
                matchid: 0,
                matchinfo: [],
                tab: null,
                items: [
                    'CRICKET', 'FOOTBALL', 'HBA', 'HOCKEY'
                ],
            }
        },
        created() {
            HTTP.get(`matches`)
                .then(response => {
                    this.matchinfo = response.data
                })
                .catch(e => {
                    this.errors.push(e)
                })
        },
        //mounted() {
        //    axios
        //        .get('http://idtp376.synerzipune.local:9015/api/matches')
        //        .then(response => {
        //            this.matchinfo = response.data
        //        })
        //},
        methods: {
            navigate: function (matchid) {
                this.$router.replace({ name: "PlayerList", params: { matchid: matchid } });
            }
        }
    }
</script>

<style scoped>
    .appBgImage_ceacf {
        background-image: url('../assets/abc.jpg');
        position: fixed;
        left: 590px;
        right: 0;
        background-size: cover;
        top: 0;
        bottom: 0;
    }
    .tabwidth {
        width: 575px;
    }

    .cardspace {
        width: 575px;
        margin-top: 7px;
    }

    .matchCardMain_954a1 {
        display: flex;
        justify-content: space-between;
        min-height: 48px;
        align-items: center;
        margin: 0px 0;
    }

    .flex_029e0 {
        display: flex;
    }

    .flagWrapperDesktop_f137b {
        width: 72px;
        height: 52px;
    }

    .flagWrapperLeft_b977f {
        margin: 0 12px 0 0;
        justify-content: flex-end;
        border-top-right-radius: 20px;
        border-bottom-right-radius: 20px;
    }

    .flagWrapper_7ce16 {
        display: flex;
        align-items: center;
    }

    .flagLeftPosition_cac11 {
        left: 16px;
        position: relative;
    }

    .flagRightPosition_cc260 {
        right: 16px;
        position: relative;
    }


    .lazyLoaderLoaded_80f0a {
        position: static;
    }

    .lazyLoader_cbc2d {
        position: relative;
    }

    .lazyLoaderImgLoaded_cf703 {
        opacity: 1;
    }

    .lazyLoaderImgFit_49680 {
        object-fit: cover;
    }

    .lazyLoaderImg_0ab5d {
        /*height: 100%;*/
        opacity: 0;
        transition: opacity 300ms linear;
        /*width: 100%;*/
    }

    .squadShortNameLeft_db179 {
        left: 20px;
        justify-content: flex-start;
        font-size: 16px;
    }

    .squadShortName_a116b {
        position: relative;
        display: flex;
        align-items: center;
        white-space: nowrap;
        width: 40px;
        color: #282828;
        font-weight: 600;
    }

    .matchCardTimerDesktop_48a55 {
        font-size: 14px;
    }

    .matchCardTimer_a5620 {
        font-weight: 500;
        color: #e10000;
        text-align: center;
        padding: 8px;
    }

    .flex_029e0 {
        display: flex;
    }

    .squadShortNameRight_42ab0 {
        right: 20px;
        justify-content: flex-end;
        font-size: 16px;
    }

    .flagWrapperRight_c02f4 {
        justify-content: flex-start;
        margin: 0 0 0 12px;
        border-top-left-radius: 20px;
        border-bottom-left-radius: 20px;
    }
</style>