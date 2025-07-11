
//without Generics we need to define two different classes
class IntPrinter
{
    public int? dataInt;
}
class StringPrinter
{
    public string? dataStr;
}

//with Generics One Class does the job

class GeenricsLearn<T>
{
    public T dataT;
    public T PrintData()
    {
        return dataT;
    }
}

//single generic type parameter classes
class MyGenericClass<T>
{

}

//multiple generic type parameter classes
class MyMultipleGenericClass<T1, T2>
{

}

//generic methods
//a method inside any class (generic or non generic) can be generic
class Utilities
{
    public T Display<T>(T value)
    {
        System.Console.WriteLine($"The value is: {value}");
        return value;
    }
}



public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

//generic interfaces
interface IRepository<T>
{
    void Add(T item);
    T? Get(int id);
}

//interface implementations
class UserRepository : IRepository<User>
{
    private List<User> users = new List<User>();
    public void Add(User item)
    {
        // Add the user to the database or a list
        users.Add(item);
    }

    public User? Get(int id)
    {
        // Return a user for the given id
        return users.FirstOrDefault(u => u.Id == id); // Example, replace with real logic
    }
}

