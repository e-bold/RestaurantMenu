using RestaurantMenu;

MenuItem item1 = new("Pad Thai", 18, "Stir fry rice noodles, green onions, bean sprouts, eggs, tofu, fish sauce, roasted peanuts.", "Entree" );
MenuItem item2 = new("Green Curry", 16.95, "Bamboo shoot, bell peppers, basil, coconut milk. Served with rice", "Entree");
MenuItem item3 = new("Crispy Spring Rolls", 3.50, "Glass noodles, cabbage, carrot, wrapped in spring roll wrapper and deep fried. Serve with Thai sweet chili sauce.", "Appetizer");
MenuItem item4 = new("Muu Ping", 8.95, "Grilled pork skewers marinated with palm sugar, pepper garlic paste, coriander seeds, glazed with coconut milk reduction. Served with sticky rice.", "Appetizer");
MenuItem item5 = new("Sticky Rice Cake With Coconut", 9.95, "This rice cake is a sweet dessert made with glutinous rice flour (also called sweet rice flour) and coconut shavings", "Dessert");
MenuItem item6 = new("Chè Thái ", 6.95, "A spoonful of sweet lychee bites, jackfruit slices, chewy jellies, and ice cold coconut milk.", "Dessert");


//Instantiating the Menu class
Menu menu = new();

//Adding items to the menu
menu.AddItem(item1);
menu.AddItem(item2);
menu.AddItem(item3);
menu.AddItem(item4);
menu.AddItem(item5);
menu.AddItem(item6);

//Printing the size of the menu to verify that we added items successfully
Console.WriteLine(menu.MenuItems.Count);

//Test IsNew() on one of the items from MenuItem class
Console.WriteLine(item1.IsNew());


//Testing ToString() method from MenuItem class
Console.WriteLine(item1);


//Testing if RemoveItem() method is working form Menu class
menu.RemoveItem(item2);

//Testing ToString() method from Menu class to print each items in the menu
Console.WriteLine(menu);


//Bonus Mission

MenuItem item7 = new("Chè Thái ", 6.95, "A spoonful of sweet lychee bites, jackfruit slices, chewy jellies, and ice cold coconut milk.", "Dessert");

menu.AddItem(item7);
Console.WriteLine(menu);


