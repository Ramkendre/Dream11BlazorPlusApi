import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)


export const store = new Vuex.Store({
    state: {
        selectedplayer: []
    },
    mutations: {
        saveTo(state, selectedplayer) {
            //localStorage.clear();
            //state.selectedplayer = null;
            state.selectedplayer = selectedplayer;
           // this.$set(this.selectedplayer)
             Vue.set(state, selectedplayer, selectedplayer);
           
        }
    },
    getters: {
        selectedplayer: state => state.selectedplayer


    },
    actions: {
        SelectViceCaption: (context, selectedplayer) => {
            context.commit('saveTo', selectedplayer);
        },
        SelectCaption: (context, selectedplayer) => {
            context.commit('saveTo', selectedplayer);
        }
    }
})
