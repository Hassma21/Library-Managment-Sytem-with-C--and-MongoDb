using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryManagementSytem
{
    [BsonIgnoreExtraElements]
    public class Book
    {
        
        public Book( string title, string author, string editor, string ıSBN, string publishYear, string edition, string publisher, string pagecount, string language, string amount)
        {
            
            Title = title;
            Author = author;
            Editor = editor;
            ISBN = ıSBN;
            PublishYear = publishYear;
            Edition = edition;
            Publisher = publisher;
            Pagecount = pagecount;
            Language = language;
            Amount = amount;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Title")]
        public string Title { get; set; }
        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Editor")]
        public string Editor { get; set; }

        [BsonElement("ISBN")]
        public string ISBN { get; set; }

        [BsonElement("PublishYear")]
        public string PublishYear { get; set; }

        [BsonElement("Edition")]
        public string Edition { get; set; }

        [BsonElement("Publisher")]
        public string Publisher { get; set; }


        [BsonElement("Pagecount")]
        public string Pagecount { get; set; }

        [BsonElement("Language")]
        public string Language { get; set; }

        [BsonElement("Amount")]
        public string Amount { get; set; }


    }
}