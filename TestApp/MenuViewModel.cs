using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestApp
{
    public class MenuViewModel
    {
        public List<MenuModel> Menus { get; set; }

        public MenuViewModel()
        {
            Menus = new List<MenuModel>();
			Menus.Add(new MenuModel() { PageName = "Home", PageType = typeof(HomePage) });
			Menus.Add(new MenuModel() { PageName = "Relative", PageType = typeof(RelativePage) });
			Menus.Add(new MenuModel() { PageName = "Absolute", PageType = typeof(AbsolutePage) });
			Menus.Add(new MenuModel() { PageName = "Detail", PageType = typeof(DetailPage) });
			Menus.Add(new MenuModel() { PageName = "TestApp", PageType = typeof(TestAppPage) });
		}
    }
}
