using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using MongoDB.Driver;
//using MongoDB.Bson;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication2.Database
{
    public class DatabaseConnection { 
        public void BindData()
    {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=projectdb;password=Kappa123");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from cpu", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //GridView1.Datasource = ds;
            //GridView1.Databind();
            cmd.Dispose();
            conn.Close();
        }








    //{
    //    private IMongoDatabase database;
    //    private IMongoCollection<BsonDocument> collection;

    //    public DatabaseConnection(string db, string coll)
    //    {
    //        var client = new MongoClient();
    //        var database = client.GetDatabase(db);
    //        var collection = database.GetCollection<BsonDocument>(coll);
    //    }
    //    public void switchColletion(string sColl)
    //    {
    //        collection = database.GetCollection<BsonDocument>(sColl);
    //    }
    //    public async void delete(string field, string value)
    //    {
    //        var filter = Builders<BsonDocument>.Filter.Eq(field, value);
    //        await collection.DeleteManyAsync(filter);
    //    }

    //    public void insert()
    //    {
    //    }

    //    public void update()
    //    {
    //    }
    }
}