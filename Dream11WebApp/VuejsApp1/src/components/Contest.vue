<template>
    <div class="contest-footer container_607ce">
        <div class="js--contest-footer innerContainer_b8f9b">
            <div class="button-group">
                <a class="btn btn btn--bordered btn--bordered--white text-color--white" v-on:click="navigate()">
                    <div class="js--contest-footer__create-team-btn">Create Team</div>
                </a>
                <a class="btn btn--flat btn--background--white" href="/cricket/my-joined-leagues/ipl/1027/14072">
                    <div class="btn js--contest-footer__joined-contests-btn">
                        <div class="buttonItemContainer_029e0">
                            <div>Joined Contests</div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</template>

<script>
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    export default {
        name: 'Contest',
        data() {
            return {
            }
        },
        methods: {
            navigate() {
                this.$router.replace({ name: "PlayerList" });
            }
        }
    }
</script>

<style scoped>
    .container_607ce {
        background-color: #3759a5;
        bottom: 0;
        position: fixed;
        width: 100%;
        max-width: 550px;
        z-index: 3;
        animation: contest-footer-animate-in 300ms cubic-bezier(0, 0, 0, 1);
    }

    .innerContainer_b8f9b {
        padding: 8px;
    }

    .button-group {
        display: flex;
        flex-direction: row;
    }

        .button-group .btn {
            flex: 1 0 0;
            margin-right: 8px;
            min-width: 0;
        }

    .text-color--white {
        color: white;
    }

    .btn--bordered--white {
        border-color: #ffffff;
    }

    .btn--bordered {
        border: 1px solid var(--color);
        --color: var(--primary-btn-color);
        color: var(--primary-btn-color);
        background: none;
        text-align: center;
        min-width: 88px;
    }

    .btn--flat {
        --color: var(--primary-btn-color);
        color: var(--primary-btn-color);
        background: none;
        text-align: center;
        min-width: 88px;
        padding: 10px 8px;
        height: auto;
    }

    .btn {
        -webkit-tap-highlight-color: transparent;
        background: none;
        border: 0;
        cursor: pointer;
        height: 28px;
        margin: 0;
        padding: 0 15px;
        text-decoration: none;
        text-transform: uppercase;
        text-align: center;
        border-radius: 4px;
        font-family: inherit;
        font-size: var(--font-small);
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .buttonItemContainer_029e0 {
        display: flex;
        color: white;
    }

    .js--contest-footer__create-team-btn {
        color: white;
    }
</style>