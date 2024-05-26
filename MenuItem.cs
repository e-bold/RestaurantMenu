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

    //INSTANCE METHOD!!! Uses dateadded from the menu class additem method. Then subtracts it from current date. Then converts it to days old integer and returns if it is less than 120 days (true) if not returns false. 
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

    //Override Equals() and GetHashCode() methods. we highlighted Name field and click refactor => check equals and gethashcode. This method checks if we are going to add duplicate menuitem.
    public override bool Equals(object? toBeCompared)
    {
        //reference check
        if(this == toBeCompared)
        {
            return true;
        }
        //null check
        if(toBeCompared == null)
        {
            return false;
        }
        //class check
        if(GetType() != toBeCompared.GetType())
        {
            return false;
        }

        //cast to class. testing if this item's name is same as other (tobecompared) item's name
        MenuItem otherItem = (MenuItem)toBeCompared;
        return Name == otherItem.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}
