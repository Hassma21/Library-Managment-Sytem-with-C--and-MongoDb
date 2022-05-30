using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSytem
{
    [BsonIgnoreExtraElements]
    public class StudentBook
    {
        private static int _count = 1;
        public StudentBook( string studentName, string studentSurname, string studentId, string title, string author, string editor, string ıSBN, string publishYear, string edition, string publisher, string pagecount, string language,string date)
        {
            
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentId = studentId;
            Title = title;
            Author = author;
            Editor = editor;
            ISBN = ıSBN;
            PublishYear = publishYear;
            Edition = edition;
            Publisher = publisher;
            Pagecount = pagecount;
            Language = language;
            Amount = _count;
            Date = date;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("StudentName")]
        public string StudentName { get; set; }

        [BsonElement("StudentSurname")]
        public string StudentSurname { get; set; }

        [BsonElement("StudentId")]
        public string StudentId { get; set; }

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
        public  int Amount { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }



    }
}
