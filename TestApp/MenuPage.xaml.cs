using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class MenuPage : ContentPage
    {
        public ListView MenuList { get { return menuList; }}
        public MenuPage()
        {
            InitializeComponent();
			Title = "Menu Page";
			Icon = "icon.png";
			menuList.BindingContext = new MenuViewModel();
        }
    }
}
