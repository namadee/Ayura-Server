using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ayura.API.Models;

public class Comment
{
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   
   public string? Id { get; set; }

   [BsonElement("content")] public string Content { get; set; } = null!;
   [BsonElement("author")] public string AuthorId { get; set; } = null!;
   [BsonElement("post")] public string? PostId { get; set; }
   
}