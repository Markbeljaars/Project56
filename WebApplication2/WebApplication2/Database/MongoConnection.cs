using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApplication2.Database
{
    public class MongoConnection : IDatabase
    {
        IMongoDatabase database;
        IMongoCollection<BsonDocument> collection;

        public MongoConnection(string db, string coll)

        { 
            var client = new MongoClient();
            this.database = client.GetDatabase(db);
            this.collection = database.GetCollection<BsonDocument>(coll);
        }
        public void switchColletion(string sColl)
        {
            collection = database.GetCollection<BsonDocument>(sColl);
        }
        public async void delete(string field, string value)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);
            await collection.DeleteManyAsync(filter);
        }

        public void insert()
        {
        }

        public void update()
        {
        }
        ~MongoConnection()
        {
            
        }
}