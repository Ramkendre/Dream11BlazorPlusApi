<template>
    <div id="teampreview">
        <div class="appBgImage_ceacf">
        <div class="absolute">
            <div class="team-preview-page js--team-preview teamPreviewContainer_cdfeb desktopTeamPreviewContainer_25c6c">
                <div class="content_eaf85 containerWithoutHeader_0f1f0" style="background-image: url(&quot;https://assets.dream11.com/public/imgs/cricket-artwork.svg&quot;);">
                    <div class="playerArea_eac11">
                        <div>
                            <div class="spaceAround_64779 tall_a7bdc">
                                <div class="teamPreviewRowWrapper_0c54c">
                                    <div class="rowTitle_b91f3">Allrounder</div>
                                    <div class="spaceAround_64779 rowContent_8aa5f">
                                        <div class="spaceAround_64779 rowContent_8aa5f" v-for="AR in SelectedTeam('Allrounder')" :key="AR.playerId">

                                            <div class="js--field-player fieldPlayerMain_32975">
                                                <div>
                                                    <div class="playerImageProfile_0cc1f">
                                                        <div class="imageProfileContainer_6e52e">
                                                            <div class="player-image-profile__image">
                                                                <b-img v-bind:src="AR.image" rounded="circle" style="height: 54px; width: 54px;"></b-img>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="playerTitleContainer_cbc2d"><div class="fieldPlayerTitle_75d21 homeTeamPlayerTitle_c0c14">{{AR.firstName}}</div></div>
                                                <div class="playerPoints_d4e06">{{AR.credits}}</div>
                                            </div>
                                        </div>
                                   </div>
                                </div>
                                <div class="teamPreviewRowWrapper_0c54c">
                                    <div class="rowTitle_b91f3">Bowler</div>
                                    <div class="spaceAround_64779 rowContent_8aa5f">

                                        <div class="spaceAround_64779 rowContent_8aa5f" v-for="AR in SelectedTeam('Bowler')" :key="AR.playerId">
                                            <div class="js--field-player fieldPlayerMain_32975">
                                                <div>
                                                    <div class="playerImageProfile_0cc1f">
                                                        <div class="imageProfileContainer_6e52e">
                                                            <div class="player-image-profile__image">
                                                                <b-img v-bind:src="AR.image" rounded="circle" style="height: 54px; width: 54px;"></b-img>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="playerTitleContainer_cbc2d"><div class="fieldPlayerTitle_75d21 homeTeamPlayerTitle_c0c14">{{AR.firstName}}</div></div>
                                                <div class="playerPoints_d4e06">{{AR.credits}}</div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
   
</template>

<script>
    export default {
        name: 'teampreview',
        data() {
            return {
                selectedplayer: this.$store.getters.selectedplayer               
            }

        },
        methods: {
            SelectedTeam: function (playertype) {
                return this.selectedplayer.filter(function (player) {
                    return player.playerRoleName === playertype
                })
            },
        }
    };
</script>

<style scoped>
</style>