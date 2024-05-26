using RestaurantMenu;

MenuItem item1 = new("Pad Thai", 18, "Stir fry rice noodles, green onions, bean sprouts, eggs, tofu, fish sauce, roasted peanuts.", "Entree", "Yes");
MenuItem item2 = new("Green Curry", 16.95, "Bamboo shoot, bell peppers, basil, coconut milk. Served with rice", "Entree", "No");
MenuItem item3 = new("Crispy Spring Rolls", 3.50, "Glass noodles, cabbage, carrot, wrapped in spring roll wrapper and deep fried. Serve with Thai sweet chili sauce.", "Appetizer", "Yes");
MenuItem item4 = new("Muu Ping", 8.95, "Grilled pork skewers marinated with palm sugar, pepper garlic paste, coriander seeds, glazed with coconut milk reduction. Served with sticky rice.", "Appetizer", "Yes");

Console.WriteLine(item1.Name);
Console.WriteLine(item2.DateAdded);
Console.WriteLine(item3.Price);
Console.WriteLine(item4.Ingredients);
