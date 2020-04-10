using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async void OnGet()
        {
            
        }

        public async Task<IActionResult> OnGetFetchData()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<Person>("bar");
            
            await collection.Find(FilterDefinition<Person>.Empty).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnGetSeedDatabase()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<Person>("bar");

            //// insert documents if they don't already exist
            //for (var x = 1; x < 10001; x++)
            //{
            //    var filter = Builders<Person>.Filter.Eq(i => i.Id, x);
            //    var person = new Person
            //    {
            //        Id = x,
            //        Friend1 = new Friend { Id = x },
            //        Friend2 = new Friend { Id = x },
            //        Friend3 = new Friend { Id = x },
            //        Friend4 = new Friend { Id = x },
            //        Name1 = $"Jack{x}",
            //        Name2 = $"Jack{x}",
            //        Name3 = $"Jack{x}",
            //        Name4 = $"Jack{x}",
            //        Name5 = $"Jack{x}",
            //        Name6 = $"Jack{x}",
            //        Name7 = $"Jack{x}",
            //        Name8 = $"Jack{x}",
            //        Name9 = $"Jack{x}",
            //        Name10 = $"Jack{x}",
            //        Name11= $"Jack{x}",
            //        Name12 = $"Jack{x}",
            //        Name13 = $"Jack{x}",
            //        Name14 = $"Jack{x}",
            //        Name15 = $"Jack{x}",
            //        Name16 = $"Jack{x}",
            //        Name17 = $"Jack{x}",
            //        Name18 = $"Jack{x}",
            //        Name19 = $"Jack{x}",
            //        Name20 = $"Jack{x}",
            //        Name21 = $"Jack{x}",
            //        Name22 = $"Jack{x}",
            //        Name23 = $"Jack{x}",
            //        Name24 = $"Jack{x}",
            //        Name25 = $"Jack{x}",
            //        Name26 = $"Jack{x}",
            //        Name27 = $"Jack{x}",
            //        Name28 = $"Jack{x}",
            //        Name29 = $"Jack{x}",
            //        Name30 = $"Jack{x}",
            //        Name31 = $"Jack{x}",
            //        Name32 = $"Jack{x}",
            //        Name33 = $"Jack{x}",
            //        Name34 = $"Jack{x}",
            //        Name35 = $"Jack{x}",
            //    };
            //    await collection.ReplaceOneAsync(filter, person);
            //}
            return Page();
        }
    }

    public class Person
    {
        [BsonId]
        public int Id { get; set; }
        public Friend Friend1 { get; set; }
        public Friend Friend2 { get; set; }
        public Friend Friend3 { get; set; }
        public Friend Friend4 { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public string Name6 { get; set; }
        public string Name7 { get; set; }
        public string Name8 { get; set; }
        public string Name9 { get; set; }
        public string Name10 { get; set; }
        public string Name11 { get; set; }
        public string Name12 { get; set; }
        public string Name13 { get; set; }
        public string Name14 { get; set; }
        public string Name15 { get; set; }
        public string Name16 { get; set; }
        public string Name17 { get; set; }
        public string Name18 { get; set; }
        public string Name19 { get; set; }
        public string Name20 { get; set; }
        public string Name21 { get; set; }
        public string Name22 { get; set; }
        public string Name23 { get; set; }
        public string Name24 { get; set; }
        public string Name25 { get; set; }
        public string Name26 { get; set; }
        public string Name27 { get; set; }
        public string Name28 { get; set; }
        public string Name29 { get; set; }
        public string Name30 { get; set; }
        public string Name31 { get; set; }
        public string Name32 { get; set; }
        public string Name33 { get; set; }
        public string Name34 { get; set; }
        public string Name35 { get; set; }
    }

    public class Friend
    {
        public int Id { get; set; }
    }


}
