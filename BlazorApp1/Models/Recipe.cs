public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public string ImageType { get; set; }
    public int UsedIngredientCount { get; set; }
    public int MissedIngredientCount { get; set; }
    public List<Ingredient> MissedIngredients { get; set; }
    public List<Ingredient> UsedIngredients { get; set; }
    public List<Ingredient> UnusedIngredients { get; set; }
    public int Likes { get; set; }
}

public class Ingredient
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public string Unit { get; set; }
    public string UnitLong { get; set; }
    public string UnitShort { get; set; }
    public string Aisle { get; set; }
    public string Name { get; set; }
    public string Original { get; set; }
    public string OriginalName { get; set; }
    public List<string> Meta { get; set; }
    public string Image { get; set; }
}