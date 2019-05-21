using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public class ExampleJsInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public ExampleJsInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task CallHelloHelperSayHello(string name)
        {
            // sayHello is implemented in wwwroot/exampleJsInterop.js
            return _jsRuntime.InvokeAsync<object>(
                "exampleJsFunctions.sayHello",
                new DotNetObjectRef(new HelloHelper(name)));
        }

        public Task SetItem<TItem>(string key, TItem item)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            return _jsRuntime.InvokeAsync<TItem>(MethodNames.SET_ITEM_METHOD, key, item);
        }
        public Task SetStringItem<Object>(string key, string item)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            return _jsRuntime.InvokeAsync<object>(MethodNames.SETSTRING_ITEM_METHOD, key, item);
        }
        public Task<TItem> GetItem<TItem>(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            return _jsRuntime.InvokeAsync<TItem>(MethodNames.GET_ITEM_METHOD, key);
        }

        public Task<Object> GetStringItem<Object>(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            return _jsRuntime.InvokeAsync<Object>(MethodNames.GETSTRING_ITEM_METHOD, key);
        }

        public Task<int> Length() => _jsRuntime.InvokeAsync<int>(MethodNames.LENGTH_METHOD, StorageTypeNames.LOCAL_STORAGE);
        public Task Clear() => _jsRuntime.InvokeAsync<object>(MethodNames.CLEAR_METHOD, StorageTypeNames.LOCAL_STORAGE);

        public Task RemoveItem(string key)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            return _jsRuntime.InvokeAsync<object>(MethodNames.REMOVE_ITEM_METHOD, key);
        }
    }
    internal class MethodNames
    {
        public const string LENGTH_METHOD = "exampleJsFunctions.LengthLocalStorage";
        public const string KEY_METHOD = "exampleJsFunctions.KeyLocalStorage";
        public const string GET_ITEM_METHOD = "exampleJsFunctions.ReadLocalStorage";
        public const string SET_ITEM_METHOD = "exampleJsFunctions.WriteLocalStorage";
        public const string GETSTRING_ITEM_METHOD = "exampleJsFunctions.ReadSaveStringLocalStorage";
        public const string SETSTRING_ITEM_METHOD = "exampleJsFunctions.SaveStringLocalStorage";
        public const string REMOVE_ITEM_METHOD = "exampleJsFunctions.RemoveLocalStorage";
        public const string CLEAR_METHOD = "exampleJsFunctions.ClearLocalStorage";
    }
    internal class StorageTypeNames
    {
        public const string SESSION_STORAGE = "sessionStorage";
        public const string LOCAL_STORAGE = "localStorage";
    }
    public class HelloHelper
    {
        public HelloHelper(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        [JSInvokable]
        public string SayHello() => $"Hello, {Name}!";

        [JSInvokable]
        public string WriteStorage()
        {
            return $"Hello, {Name}!";
        }
        [JSInvokable]
        public Object ReadStorage()
        {
            return $"Hello!";
        }
    }
}
