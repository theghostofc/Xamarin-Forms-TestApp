using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class GesturesPage : ContentPage
    {
        public GesturesPage()
        {
            InitializeComponent();
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped+= TapGesture_Tapped;
            tapGesture.NumberOfTapsRequired = 1;
            myLabel.GestureRecognizers.Add(tapGesture);
            MessagingCenter.Subscribe<string>(this, "Main", HandleAction);
            MessagingCenter.Send<string>("Main", "Hello");
            MessagingCenter.Unsubscribe<string>(this, "Main");
        }

        void HandleAction(string obj)
        {
            DisplayAlert("Alert", obj, "OK");
        }

        void TapGesture_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "My Label", "OK");
        }

        void BlueHandle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "Blue Button", "OK");
        }

        void GreenHandle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "Green Button", "OK");
        }
    }
}
