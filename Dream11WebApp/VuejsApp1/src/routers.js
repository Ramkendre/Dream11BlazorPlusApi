import Vue from 'vue'
import Router from 'vue-router'
import Login from './components/Login.vue';
import Home from './components/Home.vue';
import PlayerList from './components/PlayerList.vue';
import Contest from './components/Contest.vue';
import SelectCaption from './components/SelectCaption.vue'
import JoinContests from './components/JoinContests.vue'

Vue.use(Router)

export default new Router({
    routes: [
        {
            path: "/",
            redirect: {
                name: "Login"
            }
        },
        {
            path: "/Login",
            name: "Login",
            component: Login
        },
        {
            path: "/Home",
            name: "Home",
            component: Home
        },
        {
            path: '/PlayerList/:matchid',
            name: 'PlayerList',
            component: PlayerList
        },
        {
            path: '/Contest',
            name: 'Contest',
            component: Contest
        },
        {
            path: '/SelectCaption',
            name: 'SelectCaption',
            component: SelectCaption
        },
        {
            path: '/JoinContests',
            name: 'JoinContests',
            component: JoinContests
        }
    ]
})

