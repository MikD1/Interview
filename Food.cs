namespace Interview;

public class Food
{
    public Food(Guid id, string name, string category, int energy, float price)
    {
        Id = id;
        Name = name;
        Category = category;
        Energy = energy;
        Price = price;
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public int Energy { get; set; }

    public float Price { get; set; }
}