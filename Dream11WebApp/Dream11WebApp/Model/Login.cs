using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public interface ILogin
    {
        Task<Login> UserLoginAsync(Login login);

        Task<Register> UserRegistration(Register register);
    }
    public class LoginData : ILogin
    {
        HttpClient httpClient;
        public LoginData(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }
        public async Task<Login> UserLoginAsync(Login login)
        {
            try
            {
                //var data = await httpClient.PostJsonAsync<Register>($"{CommanUrl.url}Account", login);
                Login _login = await BlazorHttpExtensions.PostJsonAsync<Login>(httpClient, $"{CommanUrl.url}Account", login, string.Empty);
                return _login;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                var data = new Login();
                return data;
            }
        }
        public async Task<Register> UserRegistration(Register register)
        {
            try
            {
                var data = await httpClient.PostJsonAsync<Register>($"{CommanUrl.url}account/Register", register);
                return data;
            }
            catch (Exception ex)
            {
                var data = new Register();
                return data;
            }

        }
    }

    public class Register
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string emailaddress { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string authToken { get; set; }

        public int age { get; set; }
    }

    public class Login
    {
        public int id { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
       public string password { get; set; }
        public string authToken { get; set; }

        
    }
}
