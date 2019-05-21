<template>
    <div id="app">
        <div class="vscroll">
            <b-container class="bv-example-row">
                <b-row>
                    <b-col cols="8">

                        <router-view>
                        </router-view>

                    </b-col>
                    <!--<div class="appBgImage_ceacf"></div>-->
                </b-row>
            </b-container>
            <!--<app-TabMenu></app-TabMenu>-->
        </div>
    </div>
</template>

<script>
    //import TabMenu from './components/TabMenu.vue'
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    import SelectCaption from './components/SelectCaption'
    import PlayerList from './components/PlayerList'
    import teampreview from './components/teampreview.vue'

    export default {
        name: 'app',
        components: {
            //'app-TabMenu': TabMenu
            PlayerList,
            SelectCaption,
            teampreview
        },
        methods: {
            showModal() {
                this.$refs['my-modal'].show()
            },
            hideModal() {
                this.$refs['my-modal'].hide()
            },
            data() {
                return {
                    form: {                       
                            username: "",
                            password: "",
                            firstname: "",
                            lastName: "",
                            emailaddress: "",
                            age: 0,
                            id: '',
                            show: true
                    }
                }
            },

            onSubmit(evt) {
                evt.preventDefault()
                var form = { email: this.email, password: this.password, cpassowrd: this.cpassword };
                alert(JSON.stringify(form))
            },
        },

    };

</script>


<style>

    /*body {
        background-image: url('assets/abc.jpg');
        background-repeat: no-repeat;
        
        background-size: 68%;
        background-position: right top;
    }*/

    .bv-example-row {
        margin-left: 0px;
    }
    .vscroll {
        /*overflow: auto;*/
    }
.appBgImage_ceacf { background-image: url('assets/abc.jpg');
                    position: fixed; left: 590px; right: 0; background-size: cover; top: 0; bottom: 0; }
</style>
