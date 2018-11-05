using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Kitaplik_Uygulamasi
{
    class Books
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("bookname")]
        public string BookName { get; set; }
        [BsonElement("author")]
        public string Author { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("pages")]
        public int Pages { get; set; }
        [BsonElement("point")]
        public int Point { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }

        public Books(string bookName,string author,string type,int pages,int point,string description)
        {
            BookName = bookName;
            Author = author;
            Type = type;
            Pages = pages;
            Point = point;
            Description = description;
        }

    }
}
