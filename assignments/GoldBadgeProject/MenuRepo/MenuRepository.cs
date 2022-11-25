public class MenuRepository
{
    private readonly
    List<MenuItems>_menuRepositoryDb = new List<MenuItems>();

    private int _count;

    public bool
    AddMenuItemToDatabase
    (MenuItem MenuItem)
    {
        if (MenuItem is null)
        {
            return false;
        }
        else
        {
            _count++;
            MenuItem.Id = _count; 
            _MenuItemDb.Add();
            return true; 
        }
    }

    public List<MenuItem>GetAllMenuItemsData()
    {
        return _MenuItemsDb;
    }

    public ItemNumber GetMenuItemsData(int ItemNumber)
    {
        foreach (MenuItems m in _menuRepositoryDb)
        {
            if (m.ItemNumber == ItemNumber)
            {
                return m;
            }
        }
        return null; 
    }
public bool UpdateMenuItemsData(int ItemNumber,
MenuItems updateMenuItemsData)
{
    MenuItems menuItemsInDb = GetMenuItemsData
    (ItemNumber);

    if(menuItemsInDb != null)
    {
        menuItemsInDb.ItemNumber = 
        updatedMenuItemsData.ItemNumber;
        
        menuItemsInDb.ItemName =
        updatedMenuItemsInDb.ItemName;
        
        menuItemsInDb.ItemDescription = 
        UpdatedMenuItems.ItemDescription;        

        menuItemsInDb.IngredientList = 
        updateMenuItemsData.IngredientList;

        menuItemsInDb.Prices = 
        updateMenuItemsData.Prices;

        return true;
    }
    return false; 
}

public bool DeleteMenuItemsData(int itemNumber)
{
    MenuItems MenuItemsInDb = GetMenuItemsData
    (ItemNumber);

    if (MenuItemsInDb != null)
    {
        return _menuRepositoryDb.remove(MenuItemsInDb);
    }
    return false; 
}

}