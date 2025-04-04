using Ayura.API.Features.Activity.Models;
using Ayura.API.Features.Sleep.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ayura.API.Models;

[BsonIgnoreExtraElements] // to ignore extra elements that are in mongo but not in model
public class User
{
    [BsonId] // to map Id property to _id attribute in mongodb
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    [BsonElement("role")] public string Role { get; set; } = null!;

    [BsonElement("email")] public string Email { get; set; } = null!;

    [BsonElement("password")] public string Password { get; set; } = null!;

    [BsonElement("fname")] public string FirstName { get; set; } = null!;

    [BsonElement("lname")] public string LastName { get; set; } = null!;

    [BsonElement("birthDay")] public DateTime BirthDay { get; set; }

    [BsonElement("gender")] public char Gender { get; set; }

    [BsonElement("nationality")] public string Nationality { get; set; } = null!;

    [BsonElement("height")] public int Height { get; set; }

    [BsonElement("weight")] public double Weight { get; set; }

    [BsonElement("bloodGroup")] public string BloodGroup { get; set; } = null!;

    [BsonElement("activityLevel")] public string ActivityLevel { get; set; } = null!;
    
    [BsonElement("joinedCommunities")]    
    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> JoinedCommunities { get; set; } = new List<string>();
    
    [BsonElement("measurableActivities")] public MeasurableActivities MeasurableActivities { get; set; } = null!;
    [BsonElement("sleepHistories")] public List<SleepHistory> SleepHistories{ get; set; } = null!;
}