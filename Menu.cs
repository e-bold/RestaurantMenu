using System.Text;

namespace RestaurantMenu 
{
    public class Menu
    {
        public List<MenuItem> MenuItems {get; set;} = [];
        public DateTime LastUpdated {get; set;} = DateTime.Now;
        
        public void AddItem(MenuItem newItem)
        {
            MenuItems.Add(newItem);
            LastUpdated = DateTime.Now;
            newItem.DateAdded = DateTime.Now;
        }
        public void RemoveItem(MenuItem item)
        {
            MenuItems.Remove(item);
            LastUpdated = DateTime.Now;
        }
        //overriding ToString() method to print each menu Items from MenuItem class
        public override string ToString()
        {
            string nl = Environment.NewLine;
            StringBuilder appetizers = new();
            StringBuilder mainCourses =new();
            StringBuilder desserts = new();
            foreach(MenuItem item in MenuItems)
            {
                if (Equals(item.Category, "Appetizer"))
                {
                    appetizers.Append(nl).Append(item).Append(nl);
                } 
                else if (Equals(item.Category, "Entree"))
                {
                    mainCourses.Append(nl).Append(item).Append(nl);
                }
                else if(Equals(item.Category, "Dessert"))
                {
                    desserts.Append(nl).Append(item).Append(nl);
                }
            }
            return nl + "Thai Kitchen in Da Loop" + nl + nl +
            "APPETIZERS" + appetizers + nl +
            "ENTREES" + mainCourses + nl +
            "DESSERTS" + desserts + nl +
            "LAST UPDATED " + LastUpdated.ToString("f") + nl;
        }
        

    }
}

