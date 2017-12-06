using System;
using Xamarin.Forms;
using TestApp.Droid;
using Android.Content;
using Android.Preferences;

[assembly: Dependency(typeof(AndroidServices))]
namespace TestApp.Droid
{
    public class AndroidServices : IPlatformServices
    {
        public AndroidServices()
        {
        }

        public string GetPlatformName()
        {
			return "Hello from Android";
		}

        public string GetUserName()
        {
			ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Android.App.Application.Context);
			//ISharedPreferences prefs = Android.App.Application.Context.GetSharedPreferences("prt", FileCreationMode.Private);
			return prefs.GetString("UserName", string.Empty);
		}

        public void SetUserName(string name)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Android.App.Application.Context);
            //ISharedPreferences prefs = Android.App.Application.Context.GetSharedPreferences("prt", FileCreationMode.Private);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString("UserName", name);
            editor.Apply();
        }

        public string GetDocumentsPath()
		{
			var docs = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var fileName = System.IO.Path.Combine(docs, "myFile.txt");
			return fileName;
		}
	}
}
