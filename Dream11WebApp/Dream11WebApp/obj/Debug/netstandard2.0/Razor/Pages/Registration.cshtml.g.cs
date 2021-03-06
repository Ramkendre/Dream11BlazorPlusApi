#pragma checksum "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a61ccaa73bfd0e34638bad3a171f6f428ff316d"
// <auto-generated/>
#pragma warning disable 1591
namespace Dream11WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using Dream11WebApp;
    using Dream11WebApp.Shared;
    using Microsoft.AspNetCore.Components.Services;
    using Dream11WebApp.Model;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/Registration")]
    public class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "registrationformbackbody");
            builder.AddContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<div class=\"centered-form\"> </div>\r\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "panel panel-default");
            builder.AddContent(6, "\r\n\r\n        ");
            builder.AddMarkupContent(7, "<div class=\"panel-heading\">\r\n            <h3 class=\"panel-title panel-text-color\">Please sign up for Dream11 <small>It\'s free!</small></h3>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 21px\"></div>\r\n        ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "panel-body");
            builder.AddMarkupContent(10, "\r\n            ");
            builder.OpenElement(11, "div");
            builder.AddAttribute(12, "class", "row");
            builder.AddContent(13, "\r\n                ");
            builder.OpenElement(14, "div");
            builder.AddAttribute(15, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(16, "\r\n                    ");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", "form-group");
            builder.AddContent(19, "\r\n                        ");
            builder.OpenElement(20, "input");
            builder.AddAttribute(21, "type", "text");
            builder.AddAttribute(22, "class", "form-control input-sm");
            builder.AddAttribute(23, "placeholder", "First Name");
            builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.firstname));
            builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.firstname = __value, register.firstname));
            builder.CloseElement();
            builder.AddContent(26, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(27, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(28, "\r\n                ");
            builder.OpenElement(29, "div");
            builder.AddAttribute(30, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(31, "\r\n                    ");
            builder.OpenElement(32, "div");
            builder.AddAttribute(33, "class", "form-group");
            builder.AddContent(34, "\r\n                        ");
            builder.OpenElement(35, "input");
            builder.AddAttribute(36, "type", "text");
            builder.AddAttribute(37, "class", "form-control input-sm");
            builder.AddAttribute(38, "placeholder", "Last Name");
            builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.lastname));
            builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.lastname = __value, register.lastname));
            builder.CloseElement();
            builder.AddContent(41, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(42, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(43, "\r\n            ");
            builder.CloseElement();
            builder.AddContent(44, "\r\n\r\n            ");
            builder.OpenElement(45, "div");
            builder.AddAttribute(46, "class", "row");
            builder.AddContent(47, "\r\n                ");
            builder.OpenElement(48, "div");
            builder.AddAttribute(49, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(50, "\r\n                    ");
            builder.OpenElement(51, "div");
            builder.AddAttribute(52, "class", "form-group");
            builder.AddContent(53, "\r\n                        ");
            builder.OpenElement(54, "input");
            builder.AddAttribute(55, "type", "text");
            builder.AddAttribute(56, "class", "form-control input-sm");
            builder.AddAttribute(57, "placeholder", "User Name");
            builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.username));
            builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.username = __value, register.username));
            builder.CloseElement();
            builder.AddContent(60, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(61, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(62, "\r\n                ");
            builder.OpenElement(63, "div");
            builder.AddAttribute(64, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(65, "\r\n                    ");
            builder.OpenElement(66, "div");
            builder.AddAttribute(67, "class", "form-group");
            builder.AddContent(68, "\r\n                        ");
            builder.OpenElement(69, "input");
            builder.AddAttribute(70, "type", "email");
            builder.AddAttribute(71, "class", "form-control input-sm");
            builder.AddAttribute(72, "placeholder", "Email Address");
            builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.emailaddress));
            builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.emailaddress = __value, register.emailaddress));
            builder.CloseElement();
            builder.AddContent(75, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(76, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(77, "\r\n            ");
            builder.CloseElement();
            builder.AddContent(78, "\r\n\r\n            ");
            builder.OpenElement(79, "div");
            builder.AddAttribute(80, "class", "row");
            builder.AddContent(81, "\r\n                ");
            builder.OpenElement(82, "div");
            builder.AddAttribute(83, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(84, "\r\n                    ");
            builder.OpenElement(85, "div");
            builder.AddAttribute(86, "class", "form-group");
            builder.AddContent(87, "\r\n                        ");
            builder.OpenElement(88, "input");
            builder.AddAttribute(89, "type", "password");
            builder.AddAttribute(90, "class", "form-control input-sm");
            builder.AddAttribute(91, "placeholder", "Password");
            builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.password));
            builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.password = __value, register.password));
            builder.CloseElement();
            builder.AddContent(94, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(95, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(96, "\r\n                ");
            builder.OpenElement(97, "div");
            builder.AddAttribute(98, "class", "col-xs-6 col-sm-6 col-md-6");
            builder.AddContent(99, "\r\n                    ");
            builder.OpenElement(100, "div");
            builder.AddAttribute(101, "class", "form-group");
            builder.AddContent(102, "\r\n                        ");
            builder.OpenElement(103, "input");
            builder.AddAttribute(104, "type", "password");
            builder.AddAttribute(105, "class", "form-control input-sm");
            builder.AddAttribute(106, "placeholder", "Confirm Password");
            builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(register.confirmpassword));
            builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => register.confirmpassword = __value, register.confirmpassword));
            builder.CloseElement();
            builder.AddContent(109, "\r\n                    ");
            builder.CloseElement();
            builder.AddContent(110, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(111, "\r\n            ");
            builder.CloseElement();
            builder.AddContent(112, "\r\n            ");
            builder.OpenElement(113, "div");
            builder.AddAttribute(114, "class", "row");
            builder.AddContent(115, "\r\n                ");
            builder.OpenElement(116, "div");
            builder.AddAttribute(117, "class", "col-xs-12 col-sm-12 col-md-12");
            builder.AddContent(118, "\r\n                    ");
            builder.OpenElement(119, "button");
            builder.AddAttribute(120, "type", "submit");
            builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Register));
            builder.AddAttribute(122, "class", "btn btn-info btn-block");
            builder.AddContent(123, "Register");
            builder.CloseElement();
            builder.AddContent(124, "\r\n                ");
            builder.CloseElement();
            builder.AddContent(125, "\r\n            ");
            builder.CloseElement();
            builder.AddMarkupContent(126, "\r\n        ");
            builder.CloseElement();
            builder.AddContent(127, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(128, "\r\n\r\n");
            builder.CloseElement();
            builder.AddContent(129, "\r\n\r\n");
            builder.OpenComponent<Dream11WebApp.Pages.AdImage>(130);
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 67 "F:\CurrentWorkBk\BlazorApp\Dream11WebApp\Dream11WebApp\Pages\Registration.cshtml"
           
    Register registration { get; set; }
    Register register = new Register();
    private async Task Register()
    {
        if (register.username == null || register.password == null)
        {
            toastService.ShowToast("Can not null username & EmailId and password", Common.ToastLevel.Error);
        }
        else
        {
            registration = await LoginData.UserRegistration(register);
            if (registration.firstname != null)
            {
                UriHelper.NavigateTo("");
            }
            else
            {
                toastService.ShowToast("Something it's wrong", Common.ToastLevel.Error);
            }
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogin LoginData { get; set; }
    }
}
#pragma warning restore 1591
