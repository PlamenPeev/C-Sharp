using Animals.Models;

internal class Dog : Animal
{
    public Dog(string name, string favouriteFoof) : base(name, favouriteFoof)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + "\nBORK";
    }
}