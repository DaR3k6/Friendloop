using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace friendloop.Model;

public class Like
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? IdLike { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? PostId { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? UserId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}