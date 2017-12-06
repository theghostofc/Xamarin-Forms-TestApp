using System;
using SQLite;

namespace TestApp
{
    public interface IDBServices
    {
        SQLiteAsyncConnection GetAsyncConnection();
    }
}
