using System;
using Xamarin.Forms;
using TestApp.iOS;
using Foundation;

[assembly: Dependency(typeof(iOSServices))]
namespace TestApp.iOS
{
    public class iOSServices : IPlatformServices
    {
        public iOSServices()
        {
        }

        public string GetPlatformName()
        {
            return "Hello from iOS";
        }

        public string GetUserName()
        {
            return NSUserDefaults.StandardUserDefaults.StringForKey("UserName") ?? string.Empty;
        }

        public void SetUserName(string name)
        {
            NSUserDefaults.StandardUserDefaults.SetString(name, "UserName");
        }

        public string GetDocumentsPath()
        {
            var docs = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var fileName = System.IO.Path.Combine(docs, "myFile.txt");
            return fileName;
        }
    }
}
