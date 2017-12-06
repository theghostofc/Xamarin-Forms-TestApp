using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            Platform.Text = DependencyService.Get<IPlatformServices>().GetPlatformName();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SignUp.Clicked += SignUp_Clicked;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SignUp.Clicked -= SignUp_Clicked;
        }

        void SignUp_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IPlatformServices>().SetUserName(UserName.Text);
            RepoDatabase db = new RepoDatabase();
            db.SetItem(new MyModel() { ID = 0, UserName = UserName.Text });
			Navigation.PopModalAsync();
		}
    }
}
