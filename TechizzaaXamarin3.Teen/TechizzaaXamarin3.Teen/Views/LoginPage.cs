using System;

using Xamarin.Forms;

using TechizzaaXamarin3;
using TechizzaaXamarin3.Teen;

namespace TechizzaaXamarin3.Views
{
    /// <summary>
    ///   Login page for the application. Use any username/password - so long as they are not blank.
    ///   The background colour of the button will change once a valid username/password is entered.
    /// </summary>
    class LoginPage : ContentPage
    {
        #region Private Declarations

        readonly LoginInfo _credentials = new LoginInfo();

        #endregion

        #region Constructor

        public LoginPage()
        {
            #region Set some properties on the Page
           
            Padding = new Thickness(20);
            Title = "Login";
            BindingContext = _credentials;
           
            #endregion

            #region Create some Entry controls to capture username and password.
          
            Entry loginInput = new Entry { Placeholder = "User Name" };
            loginInput.SetBinding(Entry.TextProperty, "UserName");

            Entry passwordInput = new Entry { IsPassword = true, Placeholder = "Password" };
            passwordInput.SetBinding(Entry.TextProperty, "Password");
          
            #endregion

            #region Create a button to login with
           
            Button loginButton = new Button
            {
                Text = "Login",
                BorderRadius = 5,
                TextColor = Color.White,
                BackgroundColor = Colours.BackgroundGrey
            };
            loginButton.Clicked += LogMeIn;
            loginButton.SetBinding(BackgroundColorProperty, new Binding("LoginButtonColour"));
           
            #endregion

            #region Adding Controls to Stack Layout

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                          {
                              loginInput,
                              passwordInput,
                              loginButton
                          },
                Spacing = 10,
            };

            #endregion
        }

        #endregion

        #region Log Me In

        async void LogMeIn(object sender, EventArgs eventArgs)
        {
          

            App.IsLoggedIn = _credentials.CanLogin();
            if (!App.IsLoggedIn)
            {
                var page = new ContentPage();
                var result = page.DisplayAlert("Hey!", "I'm Here.", "OK", null);
            }

            await Navigation.PopAsync();

        }

        #endregion
    }
}
