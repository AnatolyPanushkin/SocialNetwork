using SocialNetwork.Entities;

namespace SocialNetwork.Domain;

public class User : Entity
{
    public UserName UserName { get; private set; }
    public Birthday Birthday { get; private set; }

    /*birthdate
    publication 
        friends*/
    
}