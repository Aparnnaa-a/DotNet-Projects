using Genericlistofclassexpenses;

    List<Menu> menus = new List<Menu>
{
    new Menu { Name = "Chiken Biriyani", Description =  "Tasty"},
    new Menu { Name = "Meals", Description = "Good" }
};

foreach (var menu in menus)
{
    Console.WriteLine($"{menu.Name} - {menu.Description}");
}
