interface IMealPlan
{
    void Prepare();
}

class VegetarianMeal : IMealPlan
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Vegetarian Meal");
    }
}

class VeganMeal : IMealPlan
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Vegan Meal");
    }
}

class Meal<T> where T : IMealPlan
{
    public void GenerateMeal(T meal)
    {
        meal.Prepare();
    }
}
