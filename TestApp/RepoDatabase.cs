using System;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace TestApp
{
    public class RepoDatabase
    {
        protected SQLiteAsyncConnection db;

        public RepoDatabase()
        {
            db = DependencyService.Get<IDBServices>().GetAsyncConnection();
            db.CreateTableAsync<MyModel>(CreateFlags.None);
        }

        public async Task<MyModel> GetItemById(int id)
        {
            var query = await db.Table<MyModel>().Where(x => x.ID == id).FirstOrDefaultAsync();
            return query;
        }

		public async Task<MyModel> GetItemByName(string name)
		{
            var query = await db.Table<MyModel>().Where(x => x.UserName.Equals(name)).FirstOrDefaultAsync();
			return query;
		}
		
        public async void SetItem(MyModel data)
        {
            if (data.ID == 0)
                await db.InsertAsync(data);
            else
                await db.UpdateAsync(data);
        }
    }
}
