using System;
using System.IO;
using SQLite;
using TestApp.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSDBServices))]
namespace TestApp.iOS
{
    public class iOSDBServices : IDBServices
    {
        public iOSDBServices()
        {
        }

        SQLiteAsyncConnection IDBServices.GetAsyncConnection()
        {
            var fileName = "mydb.db3";
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(documents, fileName);
            var connection = new SQLiteAsyncConnection(databasePath, true);
            return connection;
        }
    }
}
