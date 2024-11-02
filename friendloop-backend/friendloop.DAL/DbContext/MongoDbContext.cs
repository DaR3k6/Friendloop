using friendloop.Model;
using MongoDB.Driver;

namespace friendloop.DAL.DbContext;

public class MongoDbContext
{
    private readonly IMongoDatabase _mongoDatabase;
    
    public MongoDbContext(IMongoClient mongoClient, string databaseName)
    {
        _mongoDatabase = mongoClient.GetDatabase(databaseName);
        InitializeCollections();
    }
    
    public IMongoCollection<T> GetCollection<T>()
    {
        return _mongoDatabase.GetCollection<T>(typeof(T).Name.ToLower()); 
    }
    
    private void InitializeCollections()
    {
        CreateCollectionIfNotExists("users");
        CreateCollectionIfNotExists("post"); 
        CreateCollectionIfNotExists("like");
        CreateCollectionIfNotExists("following");
        CreateCollectionIfNotExists("comment");
    }

    private void CreateCollectionIfNotExists(string collectionName)
    {
        var collectionList = _mongoDatabase.ListCollectionNames().ToList();

        if (!collectionList.Contains(collectionName))
        {
            _mongoDatabase.DropCollection(collectionName);
        }
    }

    public IMongoCollection<User> Users => _mongoDatabase.GetCollection<User>("Users");
    public IMongoCollection<Post> Posts => _mongoDatabase.GetCollection<Post>("Posts");
    public IMongoCollection<Like> Likes => _mongoDatabase.GetCollection<Like>("Likes");
    public IMongoCollection<Follower> Followers => _mongoDatabase.GetCollection<Follower>("Followers");
    public IMongoCollection<Comment> Comments => _mongoDatabase.GetCollection<Comment>("Comments");
}