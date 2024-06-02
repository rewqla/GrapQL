namespace GraphQL.Types;

public class Query
{
    private bool _dog;
    public Book GetBook() => new Book("C# in depth", new Author("Jon Skeet"));

    public IEnumerable<IPet> GetPets() => new IPet[]{
        new Dog("Buddy","Goled Retriever"),
        new Cat("Snowball",true,CatLives.Nine),
        new Parrot("Iago",true),
        new Cat("Snowball_2",true,CatLives.Five),
        new Cat("Snowball_3",true,CatLives.One),
    };

    public IEnumerable<Cat> GetAllCats(CatLives? lives)
    {
        if (lives is not null)
            return GetPets().OfType<Cat>().Where(x => x.Lives == lives);

        return GetPets().OfType<Cat>();
    }

    public IMammal GetCatOrDog()
    {
        _dog = !_dog;
        return _dog ? new Dog("Buddy", "Goled Retriever") : new Cat("Snowball", true, CatLives.One);
    }

    public string GetDogName(Dog dog) => dog.Name;

    public string GetDogOrCatName(DogOrCat dogOrCat) => dogOrCat.Cat?.Name ?? dogOrCat.Dog?.Name!;
}

[OneOf]
public record DogOrCat(Dog? Dog, Cat? Cat);