using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TestApp
{
    public class MyViewModel : BindableObject
    {
        private ObservableCollection<MyModel> lm;

        public ObservableCollection<MyModel> LM
        {
            get
            {
                return lm;
            }

            set
            {
                lm = value;
                OnPropertyChanged("LM");
            }
        }

		public MyViewModel()
        {
            LM = new ObservableCollection<MyModel>();
            LM.Add(new MyModel() { ID = 1, UserName = "User #1" });
			LM.Add(new MyModel() { ID = 2, UserName = "User #2" });
			LM.Add(new MyModel() { ID = 3, UserName = "User #3" });
			LM.Add(new MyModel() { ID = 4, UserName = "User #4" });
			LM.Add(new MyModel() { ID = 5, UserName = "User #5" });
			LM.Add(new MyModel() { ID = 6, UserName = "User #6" });
			LM.Add(new MyModel() { ID = 7, UserName = "User #7" });
		}
    }
}
