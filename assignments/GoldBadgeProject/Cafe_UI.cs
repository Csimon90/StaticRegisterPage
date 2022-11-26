using static System.Console;
using System;

public class Program_UI
{
    private readonly MenuRepository _mRepo = new MenuRepository();

    public void Run()
    {
        SeedData();
        RunApplication();
    }
    private void RunApplication()
    {
        Clear();
        bool isRunning = true;
        while (isRunning)
        {
            WriteLine("Welcome To kCafe UI \n" +
            "Please Make A Selection\n" +
            "1. Add Menu Item To Database\n" +
            "2. See All Menu Items\n" +
            "3. See A Menu Item\n" +
            "4. Update Existing Menu Item Data\n" +
            "5. Delete Existing Menu Item Data\n" +
            "0. Exit Application\n");
            string userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                case "One":
                case "one":
                case "ONE":
                    AddMenu ItemToDatabase();
                    break;
                case "2":
                    SeeAllMenuItems();
                    break;
                case "3":
                    SeeAMenuItem();
                    break;
                case "4":
                    UpdateExistingMenuItemData();
                    break;
                case "5":
                    DeleteExistingMenuItemData();
                    break;
                case "0":
                    isRunning = ExitApplication();
                    break;
                default:
                    WriteLine("Invalid Selection, Please try again.");
                    PressAnyKeyToContinue();
                    break;
            }
        }

    }
    private bool ExitApplication()
    {
        Clear();
        WriteLine("Thanks for using KCafe UI.");
        PressAnyKeyToContinue();
        return false;
    }
    private void DeleteExistingMenuItemsData()
    {
        Clear();
        WriteLine("Please input an existing menu item number:");
        int userInput = int.Parse(ReadLine());
        MenuItems menuItems = _mRepo.GetMenuItemsData(userInput);
        if (MenuItems is null)
        {
            WriteLine($"Sorry the menu item number: {userInput} doesn't exist.");
        }
        else
        {
            if (_gRepo.DeleteMenuItemsData(menuItems.Id))
            {
                WriteLine("SUCCESS!");
            }
            else
            {
                WriteLine("FAIL!");
            }
        }
        ReadKey();
    }
    private void UpdateExistingMenuItemsData()
    {
        Clear();
        WriteLine("Please input an existing menu item number:");
        int userInput = int.Parse(ReadLine());
        MenuItems menuItems = _mRepo.GetMenuItemsData(userInput);
        if (MenuItems is null)
        {
            WriteLine($"Sorry the menu item number: {userInput} doesn't exist.");
        }
        else
        {
            MenuItems updatedMenuItems = new MenuItems();

            WriteLine("Please enter the menu items meal number.");
            updatedMenuItems.ItemNumber = ReadLine();

            WriteLine("Please enter the menu item's name.");
            updatedMenuItems.MealName = ReadLine();

            WriteLine("Please enter the menu item's description.");
            updatedMenuItems.Description = ReadLine();

            WriteLine("Please enter ingredient list.");
            updatedMenuItems.ingredientList = ReadLine();

            WriteLine("Please enter cost of item.");
            updatedMenuItems.Price = ReadLine();

            if (_mRepo.UpdateMenuItemsData(MenuItems.Id, updatedMenuItems))
            {
                WriteLine("Update was successful! ^_^");
            }
            else
            {
                WriteLine("Update was unsuccessful. Check your entry and try again. ");
            }
        }
        ReadKey();
    }
    private void SeeAMenuItem()
    {
        Clear();
        WriteLine("== Menu Item Listing ==");
        WriteLine("Please enter an existing menu item's number:");
        int userInput = int.Parse(ReadLine());
        MenuItems MenuItems = _mRepo.GetMenuItemsData(userInput);
        DisplayMenuItemsData(MenuItems);
        ReadKey();
    }

    private void SeeAllMenuItems()
    {
        Clear();
        WriteLine("== Menu Items Listing ==");
        List<MenuRepository> < MenuItemsInDb = _mRepo.GetAllMenuItemsData();
        foreach (MenuItems d in MenuItemsInDb)
        {
            DisplayMenuItemsData(d);
        }
        ReadLine();
    }
    private void DisplayMenuItemsData(MenuItems d)
    {
        WriteLine($"MenuItemsNumber: {d.MenuItemsNumber}\n" +
                $"MenuItemsName: {d.MenuItemsName}\n" +
                $"MenuItemsDescription: {d.MenuItemsDescription}\n" +
                $"MenuItemsIngredients: {d.MenuItemsIngredients}\n" +
                $"MenuItemsPrice: {d.MenuItemsPrice}\n" +
                "------------------------------------------\n");
    }

    private void AddMenuItemToDatabase()
    {
        Clear();
        MenuItems MenuItems = new MenuItems();

        WriteLine("Please enter the menu item's number.");
        MenuItems.Number = ReadLine();

        WriteLine("Please enter the menu item's name.");
        MenuItems.Name = ReadLine();

        WriteLine("Please enter the menu item's description.");
        MenuItems.Description = ReadLine();

        WriteLine("Please enter ingredient list.");
        MenuItems.ingredients = ReadLine();

        WriteLine("Please enter price of item.");
        MenuItems.Price = ReadLine();

        if (_mRepo.AddMenuItemsToDatabase(MenuItems))
        {
            WriteLine($"{MenuItems.Name} was added to the Database!");
        }
        else
        {
            WriteLine("Sorry, Invalid Database Operation.");
        }

        ReadLine();
    }

    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any Key to Continue.");
        ReadKey();
    }

    private void SeedData()
    {
        //create some data and store it in the Db
        MenuItems MenuItemA = new MenuItems("Chicken Nuggets", MenuItems.Number);
        MenuItems MenuItemB = new MenuItems("CheeseBurger", MenuItems);
        MenuItems MenuItemC = new MenuItems("Pancakes", MenuItems);

        //add them to db...
        _mRepo.AddMenuItemsToDatabase(MenuItemA);
        _mRepo.AddMenuItemsToDatabase(MenuItemB);
        _mRepo.AddMenuItemsToDatabase(MenuItemC);
    }
}
















