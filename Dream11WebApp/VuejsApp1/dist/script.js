Vue.component('signUpForm', {
    template: '#signUpForm',
    data() {
        return {
            password: '',
            confirmPassword: '',
            email: '',
            msg: [],
            disableSubmitButton: true,
        }
    },
    watch: {
        email(value) {
            this.eventName();
            this.email = value;
            this.check_email(value);
        },
        password(value) {
            this.eventName();
            this.password = value;
            this.checkPassword(value);
        },
        confirmPassword(value) {
            this.eventName();
            this.confirmPassword = value;
            this.checkConfirmPassword(value);
        }
    },
    methods: {
        changeToTnc() {
            this.$emit('change', 'tnc');
        },
        check_email(value) {
            if (/^\w+([\.-]?\ w+)*@\w+([\.-]?\ w+)*(\.\w{2,3})+$/.test(value)) {
                this.msg[name] = '';
            } else {
                this.msg[name] = 'Keep Typing... We are waiting for correct Email';
            }
        },
        checkPassword(value) {
            this.passwordLengthCheck(value);
        },
        checkConfirmPassword(value) {
            if (this.passwordLengthCheck(value)) {
                if (value == this.password) {
                    this.msg[name] = '';
                    this.disableSubmitButton = true;
                } else {
                    this.msg[name] = "Password does not match, please try again";
                }
            }
        },
        passwordLengthCheck(passwordToCheck) {
            remainingChars = 6 - passwordToCheck.length;
            if (passwordToCheck.length < 6) {
                this.msg[name] = 'Password must contain 6 characters. ' + remainingChars + ' more to go...';
            } else {
                this.msg[name] = '';
                return true;
            }
        },
        eventName() {
            name = event.target.name;
        },
        submit() {
            alert('complete regestration')
        }
    }
});

Vue.component('tnc', {
    template: '#tnc',
    methods: {
        back_to_signup() {
            this.$emit('change', 'signUpForm');
        }
    }
});

new Vue({
    el: '#app',
    data: {
        componentName: 'signUpForm'
    },
    methods: {
        change(newComp) {
            this.componentName = newComp;
        }
    }
})



