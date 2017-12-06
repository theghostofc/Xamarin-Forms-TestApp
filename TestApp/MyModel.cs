using System;
using SQLite;

namespace TestApp
{
    public class MyModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserName { get; set; }
        
        public MyModel()
        {
        }
    }
}
