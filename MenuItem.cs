namespace RestaurantMenu;

public class MenuItem
{
    //Fields
    public string Name {get; set;}
    public double Price {get; set;}
    public string Ingredients {get; set;}
    public string Category {get; set;}
    public string NewItem {get;set;}
    public DateTime DateAdded {get; set;}

    //Constructor
    public MenuItem (string name, double price, string ingredients, string category, string newItem)
    {
        Name = name;
        Price = price;
        Ingredients = ingredients;
        Category = category;
        NewItem = newItem;
    }
    
}
