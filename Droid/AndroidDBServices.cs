using System;
using SQLite;
using TestApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidDBServices))]
namespace TestApp.Droid
{
    public class AndroidDBServices : IDBServices
    {
        public AndroidDBServices()
        {
        }

        SQLiteAsyncConnection IDBServices.GetAsyncConnection()
        {
            throw new NotImplementedException();
        }
    }
}
