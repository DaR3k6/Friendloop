using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace friendloop.Model;

public class Post
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? IdPost { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? UserId { get; set; }

    [BsonRequired]
    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}