<template>

    <div id="login">
        <div id="login_title">
            <h3>Login</h3>
        </div>
        <div>
            <form v-on:login.prevent="login">

                <div class="form-group">
                    <label for="formName">UserName:</label>
                    <input type="text" name="username" id="formName" v-model="loginuser.username" v-validate="'required'"
                           v-bind:class="{'form-control': true, 'error': errors.has('username') }">
                    <span v-show="errors.has('username')" class="text-danger">{{ errors.first('username') }}</span>
                </div>
                <div class="form-group">
                    <label for="formName">password:</label>
                    <input type="text" name="password" id="password" v-model="loginuser.password" v-validate="'required'"
                           v-bind:class="{'form-control': true, 'error': errors.has('password') }">
                    <span v-show="errors.has('password')" class="text-danger">{{ errors.first('password') }}</span>
                </div>
            </form>         
            <!--<b-form-group id="input-group-1"
                          label="Enter user name:"
                          label-for="input-1">
                <b-form-input id="username" v-model="loginuser.username" type="Email" required></b-form-input>
            </b-form-group>

            <b-form-group id="input-group-1"
                          label="Password:"
                          label-for="input-1">
                <b-form-input id="password" v-model="loginuser.password" type="Password" required></b-form-input>
            </b-form-group>-->
            <b-button type="button" v-on:click="login()">Login</b-button>  &nbsp;

            <b-button id="show-btn" @click="showModal" type="button" >New Registration</b-button>
        </div>


        <!-- below signup form -->
        <b-modal ref="my-modal" hide-footer title="Sign Up Form">
            <div>
                <form v-on:login.prevent="onSubmit">
                    <div class="form-group">
                        <label for="formName">UserName</label>
                        <input type="text" name="username" id="formName" v-model="loginuser.username" v-validate="'required'"
                               v-bind:class="{'form-control': true, 'error': errors.has('username') }">
                        <span v-show="errors.has('username')" class="text-danger">{{ errors.first('username') }}</span>
                    </div>
                    <div class="form-group">
                        <label for="formName">password</label>
                        <input type="text" name="password" id="password" v-model="loginuser.password" v-validate="'required'"
                               v-bind:class="{'form-control': true, 'error': errors.has('password') }">
                        <span v-show="errors.has('password')" class="text-danger">{{ errors.first('password') }}</span>
                    </div>
                    <div class="form-group">
                        <label for="formName">firstname</label>
                        <input type="text" name="firstname" id="formName" v-model="loginuser.firstname" v-validate="'required'"
                               v-bind:class="{'form-control': true, 'error': errors.has('username') }">
                        <span v-show="errors.has('firstname')" class="text-danger">{{ errors.first('firstname') }}</span>
                    </div>
                    <div class="form-group">
                        <label for="formName">lastname</label>
                        <input type="text" name="lastname" id="lastname" v-model="loginuser.lastname" v-validate="'required'"
                               v-bind:class="{'form-control': true, 'error': errors.has('lastname') }">
                        <span v-show="errors.has('lastname')" class="text-danger">{{ errors.first('lastname') }}</span>
                    </div>
                    <div class="form-group">
                        <label for="formName">mailid</label>
                        <input type="text" name="emailaddress" id="emailaddress" v-model="loginuser.emailaddress" v-validate="'required'"
                               v-bind:class="{'form-control': true, 'error': errors.has('emailaddress') }">
                        <span v-show="errors.has('emailaddress')" class="text-danger">{{ errors.first('emailaddress') }}</span>
                    </div>
                    </form>


            </div>
            <div class="d-block text-center">
                <b-button @click="onSubmit" type="submit"  variant="primary">Submit</b-button>
            </div>
        </b-modal>
        <div class="appBgImage_ceacf"></div>
    </div>

</template>

<script>
    import { HTTP } from '../HttpComman.js';
    import 'bootstrap/dist/css/bootstrap.css'
    import 'bootstrap-vue/dist/bootstrap-vue.css'
    import { required, minLength, between } from 'vuelidate/lib/validators'
    export default {
       
        name: 'Login',
        data() {
            return {                 
                loginuser: {                  
                    username: "",
                    password: "",
                    firstname: "",
                    lastName: "",
                    emailaddress: "",
                    age: 0,
                    id: ''
                
                },
                logindetail:
                    {
                    username: "",
                    password: "",
                    firstName: "",
                    lastName:"",
                    authToken: "",
                    id:''
                    
                }
            }
        },
        validations: {
            name: {
                required,
                minLength: minLength(4)

            },
            password: {
                between: between(20, 30)
            }
        },
        //created() {
        //HTTP.get(`Account`,this.loginuser)
        //    .then(response => {
        //        this.logindetail = response.data
        //    })
        //    .catch(e => {
        //        this.errors.push(e)
        //    });
        //},
        methods: {
          
            showModal() {
                this.$refs['my-modal'].show()
            },
            hideModal() {
                this.$refs['my-modal'].hide()
            },
            login()
            {
                this.$validator.validateAll().then(() => {

                    var logindetail = [];
                    // logindetail= this.loginuser;
                    var respo = [];


                    HTTP.post(`Account/`, this.loginuser)
                        .then((response) => {
                            respo = this.loginuser;
                            logindetail = response.data;
                            if (respo.username)
                                if (respo.username === logindetail.username) {
                                    this.$router.replace({ name: "Home" });
                                } else {
                                    //Console.log("The username and / or password is incorrect");
                                }
                        })
                        .catch(e => {
                            this.errors.push(e)
                        });
                }
               
            )},
            onSubmit() {
                this.$validator.validateAll().then(() => {
                    HTTP.post(`Account/Register`, this.loginuser)
                        .then(response => {
                            this.logindetail = response.data
                        })
                        .catch(e => {
                            this.errors.push(e)
                        });
                    this.$refs['my-modal'].hide()
                    //if (this.loginuser.id === this.logindetail.id) {
                    //    this.$router.replace({ name: "Home" });
                    //} else {
                    //    console.log("The username and / or password is incorrect");
                    //}


                    this.$router.replace({ name: "Login" });


                });
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

    #login {
        width: 500px;
        background-color: #FFFFFF;
        margin: auto 0px;
        margin-top: 20px;
        margin-left: 10px;
        padding: 0px;
    }

    #login_title {
        height: 47px;
        margin-top: 10px;
        margin: auto 0px;
        text-align: center;
    }
    h1 {
        color: #858585;
        margin: 30px 0;
    }

    label {
        color: #858585;
    }

    .form-control:focus {
        border-color: #7BE855;
        box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(123,232,85,.6);
    }

    .form-control.error {
        border-color: #E84444;
        box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(232,68,68,.6);
    }

</style>