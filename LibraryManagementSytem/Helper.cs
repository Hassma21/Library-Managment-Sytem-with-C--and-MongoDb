using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem
{
    public static class Helper
    {
        public static MongoClient dbClient = new MongoClient("mongodb://127.0.0.1:27017");

        public static IMongoDatabase db = dbClient.GetDatabase("LibraryDB");
        public static IMongoCollection<Book> collection = db.GetCollection<Book>("Books");
        public static IMongoCollection<StudentBook> collection2 = db.GetCollection<StudentBook>("StudentBooks");

    }
}
