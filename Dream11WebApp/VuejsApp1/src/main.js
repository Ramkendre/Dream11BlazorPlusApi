import Vue from 'vue';
import App from './App.vue';
//import App from './components/Registration.vue';
import Vuetify from 'vuetify';
import axios from 'axios';
import router from './routers'
import eventbus from './caption.js'
import BootstrapVue from 'bootstrap-vue'
import { store } from './store.js';
import VeeValidate from "vee-validate";
import Vuelidate from 'vuelidate'
Vue.use(Vuelidate)
Vue.use(BootstrapVue)
Vue.use(Vuetify)
Vue.use(axios)
Vue.use(VeeValidate);

Vue.config.productionTip = true;


new Vue({
    router,
    store,
    eventbus,
    render: h => h(App)
}).$mount('#app');


new Vue({
    e1: '#app',
    router,
    render: h=>h(App)
})






