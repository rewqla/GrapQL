namespace GraphQL.Types;
public class Cat : IPet, IMammal
{
    public Cat(string name, bool isEvil, CatLives lives)
    {
        Name = name;
        IsEvil = isEvil;
        Lives = lives;
    }
    public string Name { get; }
    public bool IsEvil { get; }
    public CatLives Lives { get; }
}

public enum CatLives
{
    One, Two, Three, Four, Five, Six, Seven, Eight, Nine, NineAndAHalf
}