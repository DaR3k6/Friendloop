using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace friendloop.Model;

public class Comment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? IdComment { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? PostId { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? UserId { get; set; }

    [BsonRequired]
    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}