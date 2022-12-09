using System;

class Program
{
    public static Queue<string> checklist = new Queue<string>();
    public static Queue<int> priceList = new Queue<int>();

    static void Main(string[] args)
    {
        InputChecklist();
    }

    public static string InputList()
    {
        string list = Console.ReadLine();
        return list;
    }

    public static int InputPrice()
    {
        int price = int.Parse(Console.ReadLine());
        return price;  
    } 
    static void InputChecklist()
    {
        string list = InputList();
        checklist.Push(list);
        int price = InputPrice();
        priceList.Push(price);

        bool sublist = bool.Parse(Console.ReadLine());

        if (sublist = true)
        {
            list = InputList();
            checklist.Push(list);

            int price1 = 0;
            price1 += InputPrice();
            if (price1 < price)
            {
                priceList.Push(price1);
                InputChecklist();
            }
            else
            {
                InputChecklist();        
            }
        }
        else
        {
            string value = checklist.Pop();
            Console.WriteLine(value);
        }

    }
}