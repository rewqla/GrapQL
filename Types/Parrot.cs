namespace GraphQL.Types;

public class Parrot : IPet
{
    public Parrot(string name, bool canTalk)
    {
        Name = name;

        CanTalk = canTalk;
    }
    public string Name { get; }
    public bool CanTalk { get; }
}