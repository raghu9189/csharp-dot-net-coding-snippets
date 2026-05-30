namespace MyApp2.DesignPatterns;

// User Entity
#nullable disable
public class User
{
    public int Id {get; set;}
    public string Name {get; set;}
}

// User Repository Interface
#nullable disable
public interface IUserRepository
{
    List<User> GetAll();
    User GetByID(int id);
    void AddUser(User user);
}

// Implement Repository

public class UserRepository : IUserRepository
{
    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User GetByID(int id)
    {
        throw new NotImplementedException();
    }
}

public static class RepositoryPattern
{
    public static void Run()
    {
        
    }
}

