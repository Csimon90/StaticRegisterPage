Console.Clear();
System.Console.WriteLine("Press any key to create a meal.");

Console.ReadKey();

Kitchen kitchen = new Kitchen();
Potato potato = new Potato();

//lets peel the potato first!!
potato.Peel();

var fries = await kitchen.FryPotatoAsync(potato);
var hamburger = kitchen.AssembleBurger();

//server meal
kitchen.ServeMeal(fries, hamburger);

Console.ReadKey();
