using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace friendloop.Model;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? IdUser { get; set; }

    [BsonRequired] public string? Username { get; set; }

    [BsonRequired] public string? Email { get; set; }

    [BsonRequired] public string? Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? Bio { get; set; }

    public string? ProfilePicture { get; set; }

}