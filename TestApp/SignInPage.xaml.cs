using System;
using System.Collections.Generic;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace TestApp
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SignUp.Clicked += SignUp_Clicked;
            SignIn.Clicked += SignIn_Clicked;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SignUp.Clicked -= SignUp_Clicked;
            SignIn.Clicked -= SignIn_Clicked;
        }

        void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUpPage());
        }

        void SignIn_Clicked(object sender, EventArgs e)
        {
    //        string userName = UserName.Text;
    //        string savedUserName = DependencyService.Get<IPlatformServices>().GetUserName();

    //        RepoDatabase db = new RepoDatabase();
    //        MyModel dbSavedUser = await db.GetItemByName(userName);

    //        //if (CrossConnectivity.Current.IsConnected) ;

    //        //if (userName.Equals(savedUserName))
    //        if (userName.Equals(dbSavedUser.UserName))
    //        {
				//App.Current.Properties["UserName"] = userName;
				//App.Current.MainPage = new NavigationPage(new HomePage());
            //}
            //else
                //ErrorLabel.Text = "Invalid User";
            App.Current.MainPage = new NavigationPage(new HomePage());
		}
    }
}
