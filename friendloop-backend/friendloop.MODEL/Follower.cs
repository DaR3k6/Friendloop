using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace friendloop.Model;

public class Follower
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? FollowerId { get; set; }

    [BsonRequired]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? FolloweeId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}