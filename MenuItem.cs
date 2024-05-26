namespace RestaurantMenu;

public class MenuItem
{
    //Fields
    public string Name {get; set;}
    public double Price {get; set;}
    public string Ingredients {get; set;}
    public string Category {get; set;}
    public DateTime DateAdded {get; set;}

    //Constructor
    public MenuItem (string name, double price, string ingredients, string category)
    {
        Name = name;
        Price = price;
        Ingredients = ingredients;
        Category = category;
    }

    //Uses dateadded from the menu class additem method. Then subtracts it from current date. Then converts it to days old integer and returns if it is less than 120 days (true) if not returns false.
     public bool IsNew()
     {
        TimeSpan age = DateTime.Now.Subtract(DateAdded);
        int daysOld = age.Days;
        return daysOld < 120;
     }

    //Override default toString() method to print the each menuItem and format it
    string nl = Environment.NewLine;
    public override string ToString()
    {
        string newText = IsNew() ? " - New!" : " Old Item";
        return Name + newText + " | $" + Price + nl +
        "Ingredients: " + Ingredients + nl;
    }



}
