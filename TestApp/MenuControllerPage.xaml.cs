using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class MenuControllerPage : MasterDetailPage
    {
        MenuPage menuPage;
        public MenuControllerPage()
        {
            InitializeComponent();
            menuPage = new MenuPage();
            Master = menuPage;
            Detail = new NavigationPage(new HomePage());
            menuPage.MenuList.ItemTapped += MenuList_ItemTapped;
        }

        void MenuList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var page = e.Item as MenuModel;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page.PageType));
            menuPage.MenuList.SelectedItem = null;
            IsPresented = false;
        }
    }
}
