<template>
    <!--<b-container class="bv-example-row">
        <b-row>
            <b-col cols="8">-->
                <header>
                    <div>
                        <div class="headerContainer_199c8 headerFixed_38df7 headerShadow_22469">
                            <div class="row-1 headerRow_c14ad">
                                <div class="headerCenter_4d6f0">Dream11</div>
                            </div>
                        </div>
                    </div>
                </header>
            <!--</b-col>
        </b-row>
    </b-container>-->
</template>

<script>
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    export default {
        name: 'Header',
        data() {
            return {};
        }
    };
</script>

<style scoped>
    .bv-example-row {
        margin-left: 0px;
    }
    .headerShadow_22469 {
        box-shadow: 0px 1px 4px 0px rgba(0, 0, 0, 0.3);
    }

    .headerFixed_38df7 {
        position: fixed;
        top: 0;
        max-width: 575px;
        width: 100%;
    }

    .headerContainer_199c8 {
        background-color: #c51d23;
        color: #FFF;
        z-index: 2;
    }

    .headerRow_c14ad {
        display: flex;
        justify-content: space-between;
        height: 50px;
    }

    .headerLeft_36c4e {
        display: flex;
        flex: 1 0 0;
        justify-content: flex-start;
        align-items: center;
    }

    .headerCenter_4d6f0 {
        display: flex;
        flex: 1 0 0;
        justify-content: center;
        align-items: center;
    }

    .headerRight_ba2d2 {
        display: flex;
        flex: 1 0 0;
        justify-content: flex-end;
        align-items: center;
    }
</style>