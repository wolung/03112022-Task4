int coffee = 10;
int tea = 10;
int sugar = 10;
int milk = 10;
int cups = 10;
int menu3 = 0;
do
{
    Console.WriteLine("Coffe machine");
    Console.WriteLine("What do to drink");
    Console.WriteLine("1 - Coffee");
    Console.WriteLine("2 - Tea");
    int menu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("1 - With sugar");
    Console.WriteLine("2 - With milk");
    Console.WriteLine("3 - With sugar and milk");
    Console.WriteLine("4 - No sugar or milk");
    int menu2 = Convert.ToInt32(Console.ReadLine());


    if (menu == 1)
    {
        if (menu2 == 1)
        {



            if (cups == 0)
            {
                Console.WriteLine("We are out of cups. Sorry");
            }
            else
            {
                cups = cups - 1;
                if (coffee == 0)
                {
                    Console.WriteLine("We are out of coffee. Sorry");
                    cups = cups + 1;
                }
                else
                {
                    coffee = coffee - 1;
                    if (sugar == 0)
                    {
                        Console.WriteLine("We are out of sugar. Sorry");
                        cups = cups + 1;
                        coffee = coffee + 1;
                    }
                    else
                    {
                        sugar = sugar - 1;
                        Console.WriteLine("Coffee with sugar is served for you.");
                    }

                }
            }
        }
        else
        {
            if (menu2 == 2)
            {
                Console.WriteLine("Option not ready. Sorry");
            }
            else
            {
                if (menu2 == 3)
                {
                    Console.WriteLine("Option not ready. Sorry");
                }
                else
                {
                    if (menu2 == 4)
                    {
                        Console.WriteLine("Option not ready. Sorry");
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice");
                    }
                }
            }
        }
    }
    else
    {
        if (menu == 2)
        {
            Console.WriteLine("Option not ready. Sorry");
        }
        else
        {
            Console.WriteLine("Wrong choice");
        }
    }
    Console.WriteLine("");
    Console.WriteLine("How many tea left?" + tea);
    Console.WriteLine("How many coffe left?" + coffee);
    Console.WriteLine("How many sugar left?" + sugar);
    Console.WriteLine("How many milk left?" + milk);
    Console.WriteLine("How many cups left?" + cups);
    Console.WriteLine("");
    Console.WriteLine("Do you want start from begin? (1 - YES or 2 - NO)");
    menu3 = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
} while (menu3 == 1);


Console.ReadKey();
