    public class Kitchen
    {
    public async Task<Fries> FryPotatoAsync(Potato potato)
    {
    //check if potato is peeled
        if(potato.IsPeeled ==true ) 
        {
            System.Console.WriteLine("Dropping in the Fries.");
            await Task.Delay(2000);

                System.Console.WriteLine("The Fries are frying");
                await Task.Delay(3000);

                System.Console.WriteLine("Ding the Fries are done!");
                return new Fries(potato);
            }
            else
            {
                System.Console.WriteLine("The potato isn't peeled.");
                return null;
            }
        }


    public async Task<Fries> FryPotatoRefactorAsync(Potato potato)
    {
        //check if potato is peeled
        if(potato.IsPeeled ==true ) 
        {
            //changing color to yellow ("-----------,14");
            PrettyPrint("Drop the raw fries in the Fryer." ,14);
            await Task.Delay(5000);

            PrettyPrint("The Fries are working on their golden crispy tan..." ,7);
            await Task.Delay(5000);

            PrettyPrint("Ding! The Fries are done!" ,11);
            return new Fries(potato);
        }
        else
        {
            System.Console.WriteLine("The potato isn't peeled.");
            return null;
        }
    }

//synchronous method.. again.

    public Hamburger AssembleBurger()
    {
        var time = 1000;
        PrettyPrint("Assembling the burger." ,13);

        PrettyPrint("Setting the Bottom Bun down." ,4);
        Task.Delay(time).Wait();

        PrettyPrint("Set Patty gently on bun." ,12);
        Task.Delay(time).Wait();

        PrettyPrint("Place Cheese on top of patty." ,14);
        Task.Delay(time).Wait();

        PrettyPrint("Add Lettuce." ,10);
        Task.Delay(time).Wait();

        PrettyPrint("Don't forget Pickles." ,12);
        Task.Delay(time).Wait();

        PrettyPrint("Let's get Saucy." ,2);
        Task.Delay(time).Wait();

        PrettyPrint("Smack that round Top Bun on." ,13);
        Task.Delay(time).Wait();
        
        PrettyPrint("Burger Assembled!" ,13);
        
        return new Hamburger();

    }

    public bool ServeMeal (Fries fries, Hamburger hamburger)
    {
        if(fries==null)
        {
            PrettyPrint("The Fries are not ready.",9);
            return false;
        }
        else
        {
            PrettyPrint("Add Burger and Fries to bag and serve to customer.",15);
            return true;
        }
    }

    public void PrettyPrint(string message, int color)
        {
            //casting to console color via 'int color' being 'passed in the method'
            //Black 0
            //DarkBlue 1
            //DarkGreen 2
            //DarkCyan 3
            //DarkRed 4
            //DarkMagenta 5
            //DarkYellow 6
            //Gray 7
            //DarkGray 8
            //Blue 9
            //Green 10
            //Cyan 11
            //Red 12
            //Magenta 13
            //Yellow 14 used above^^^
            //White 15

        //change the color
        Console.ForegroundColor=(ConsoleColor)color;
        // write our message
        System.Console.WriteLine(message);
        //change the color back.
        Console.ResetColor();
    }
}
