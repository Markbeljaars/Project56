using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WebApplication2.Database
{
    interface IDatabase
    {
        void switchColletion(string sColl);
        void insert();
        void update();
        void delete(string field, string value);
    

    }
}
