namespace Animals.Models;

public abstract class Animal
{

    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFoof)
    {
        this.name = name;
        this.favouriteFood = favouriteFoof;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.name} and my fovourite food is {this.favouriteFood}";
    }
}
