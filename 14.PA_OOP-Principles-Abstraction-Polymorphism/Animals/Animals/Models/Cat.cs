using Animals.Models;

public class Cat : Animal
{
    public Cat(string name, string favouriteFoof) : base(name, favouriteFoof)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + "\nMEEOW";
    }
}