window.exampleJsFunctions = {
    showPrompt: function (text) {
        return prompt(text, 'Type your name here');
    },
    displayWelcome: function (welcomeMessage) {
        document.getElementById('welcome').innerText = welcomeMessage;
    },
    returnArrayAsyncJs: function () {
        DotNet.invokeMethodAsync('BlazorSample', 'ReturnArrayAsync')
            .then(data => {
                data.push(4);
                console.log(data);
            });
    },
    sayHello: function (dotnetHelper) {
        return dotnetHelper.invokeMethodAsync('SayHello')
            .then(r => console.log(r));
    },
    WriteLocalStorage: function (key, value) {
        localStorage.setItem(key, JSON.stringify(value));
    },
    ReadLocalStorage: function (key) {
        const item = localStorage.getItem(key);
        if (item) {
            return JSON.parse(item);
        }
        return null;
    },
    RemoveLocalStorage: function (key) {
        localStorage.removeItem(key);
    },
    ClearLocalStorage: function () {
        localStorage.clear();
    },
    LengthLocalStorage: function () {
        localStorage.length();
    },
    KeyLocalStorage: function (index) {
        localStorage.key(index);
    },
    SaveStringLocalStorage: function (key, value) {
        localStorage.setItem(key, value);
    },
    ReadSaveStringLocalStorage: function (key) {
        const item = localStorage.getItem(key);
        if (item) {
            return item;
        }
        return null;
    },
    Alert: function (message) {
        alert(message);
    }
};