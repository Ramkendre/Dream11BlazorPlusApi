<template>
    <div> <app-header></app-header>
    <div class="headerspcae"></div>
        <app-TabMenu></app-TabMenu>
    </div>
</template>

<script>
    import header from '../components/Header.vue';
    import TabMenu from '../components/TabMenu.vue';
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    export default {
        name: 'Home',
        components: {
            'app-header': header,
            'app-TabMenu': TabMenu
        },
        data() {
            return {};
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .headerspcae {
        margin-top: 30px;
      
    }
</style>
