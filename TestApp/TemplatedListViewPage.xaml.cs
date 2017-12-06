using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class TemplatedListViewPage : ContentPage
    {
        public TemplatedListViewPage()
        {
            InitializeComponent();
            TemplateListView.BindingContext = new EmployeeViewModel();
        }
    }
}
