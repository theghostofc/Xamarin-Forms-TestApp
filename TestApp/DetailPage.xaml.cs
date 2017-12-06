using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class DetailPage : ContentPage
    {
        private MyViewModel vm;
        public DetailPage(string detail = "")
        {
            InitializeComponent();
            DetailLabel.Text = detail;
            Title = "Detail Page";
            vm = new MyViewModel();
            BindingContext = vm;
        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            string data = (vm.LM.Count + 1).ToString();
            vm.LM.Add(new MyModel(){ID = vm.LM.Count + 1, UserName = "User #" + data});
        }

        void Remove_Clicked(object sender, System.EventArgs e)
        {
            if(vm.LM.Count > 0)
                vm.LM.RemoveAt(vm.LM.Count - 1);
        }

        void ListItem_Clicked(object sender, System.EventArgs e)
        {
            var mi = ((MenuItem)sender);
            MyModel m = (MyModel)mi.CommandParameter;
            vm.LM.Remove(m);
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            myList.EndRefresh();
        }
    }
}
