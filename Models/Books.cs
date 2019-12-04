using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Test.Models
{

    // [BsonIgnoreExtraElements]
    public class Books
    {

        // [BsonId]
     
        public ObjectId Id { get; set; }

     
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("Author")]
        public string Author { get; set; }
    }


}