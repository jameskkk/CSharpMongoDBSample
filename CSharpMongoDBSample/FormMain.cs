using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace CSharpMongoDBTest
{

    /// <summary>
    /// Install MongoDB.Driver and MongoDB.Bson from Nuget
    /// </summary>
    public partial class FormMain : Form
    {
        private string m_IPAddress = "10.2.21.39";
        //private string m_IPAddress = "127.0.0.1";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt("price", 30000) & builder.Lt("price", 55000);

            var docs = cars.Find(filter).ToList();

            docs.ForEach(doc => {
                Console.WriteLine(doc);
            });

            Console.WriteLine("Query end!");
        }

        private void btnQueryAll_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);
            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var cars = db.GetCollection<BsonDocument>("cars");
            var documents = cars.Find(new BsonDocument()).ToList();

            foreach (BsonDocument doc in documents)
            {
                Console.WriteLine(doc.ToString());
            }

            Console.WriteLine("Query all end!");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var doc = new BsonDocument
            {
                {"name", "BMW"},
                {"price", 34621}
            };

            cars.InsertOne(doc);

            Console.WriteLine("Insert One end!");
        }

        /*
            { "name" : "Audi", "price" : 52000 }
            { "name" : "Mercedes", "price" : 57127.0 }
            { "name" : "Volvo", "price" : 29000.0 }
            { "name" : "Bentley", "price" : 350000.0 }
            { "name" : "Citroen", "price" : 21000.0 }
            { "name" : "Hummer", "price" : 41400.0 }
            { "name" : "Volkswagen", "price" : 21600.0 }
        */
        private void btnInsertMany_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var carsList = new List<BsonDocument>()
            {
                new BsonDocument
                {
                    {"name", "BMW"},
                    {"price", 34621},
                },
                new BsonDocument
                {
                    {"name", "Audi"},
                    {"price", 52000}
                },
                new BsonDocument
                {
                    {"name", "Mercedes"},
                    {"price", 57127.0}
                },
                new BsonDocument
                {
                    {"name", "Volvo"},
                    {"price", 29000.0}
                },
                new BsonDocument
                {
                    {"name", "Bentley"},
                    {"price", 350000.0}
                },
                new BsonDocument
                {
                    {"name", "Citroen"},
                    {"price", 21000.0}
                },
                new BsonDocument
                {
                    {"name", "Hummer"},
                    {"price", 41400.0}

                },
                new BsonDocument
                {
                    {"name", "Volkswagen"},
                    {"price", 21600.0},
                    {"note", "Kent's car"}
                },
                new BsonDocument
                {
                    {"name", "Lexus"},
                    {"price", 41600.0},
                    {"note", "John's car"}
                }
            };
           
            cars.InsertMany(carsList);

            Console.WriteLine("Insert Many end!");
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var command = new BsonDocument { { "dbstats", 1 } };
            var result = db.RunCommand<BsonDocument>(command);
            Console.WriteLine(result.ToJson());

            Console.WriteLine("Get Status end!");
        }

        private void btnListDB_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);
            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases are:");

            foreach (var item in dbList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List DB end!");
        }

        private void btnSkipLimit_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var docs = cars.Find(new BsonDocument()).Skip(3).Limit(3).ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

            Console.WriteLine("Skip and Limit end!");
        }

        private void btnProjections_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var cars = db.GetCollection<BsonDocument>("cars");
            var docs = cars.Find(new BsonDocument()).Project("{_id: 0}").ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

            Console.WriteLine("Projections end!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var cars = db.GetCollection<BsonDocument>("cars");
            var filter = Builders<BsonDocument>.Filter.Eq("name", "BMW");

            cars.DeleteOne(filter);

            Console.WriteLine("Delete end!");
        }

        private void btnDropDB_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");

            db.DropCollection("cars");
            //var cars = db.GetCollection<BsonDocument>("cars");
            //cars.Drop();

            Console.WriteLine("DropDB end!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 預設連線(localhost: 27017)
            string url = "mongodb://" + m_IPAddress + ":27017";
            Console.WriteLine("url = " + url);
            var dbClient = new MongoClient(url);

            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var cars = db.GetCollection<BsonDocument>("cars");

            var filter = Builders<BsonDocument>.Filter.Eq("name", "Audi");
            var update = Builders<BsonDocument>.Update.Set("price", 52000);

            cars.UpdateOne(filter, update);

            Console.WriteLine("Update end!");
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            if (txtIP.Text != "")
            {
                m_IPAddress = txtIP.Text;
            }
        }
    }
}
