using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MongoDB.Driver;

namespace todo_app
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			MongoClient client = new MongoClient();
			var mongoDB = client.GetDatabase("new");
			var newCollection = mongoDB.GetCollection<string>("collection");

			Todo todo = new Todo();

			StartProgram(args);		
            
		}
      
    }
}

//mi az az async
//