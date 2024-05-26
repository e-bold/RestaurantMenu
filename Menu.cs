namespace RestaurantMenu 
{
    public class Menu
    {
    public List<MenuItem> MenuItems {get; set;} = [];
    public DateTime LastUpdated {get; set;} = DateTime.Now;
    }
}

