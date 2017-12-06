using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Detail.Clicked += Detail_Clicked;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Detail.Clicked -= Detail_Clicked;
        }

        void Detail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage("Hello DMI"));
        }
    }
}
