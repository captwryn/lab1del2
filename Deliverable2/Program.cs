using System;
class MainClass
{
    public static void Main()
    {
        int j = 1;
        int a1 = 1;
        int a2 = 1;
        int a3 = 1;

        while (j < 2)
        {
            Console.Write("Please say what you would like to say to the chat bot from these options: 'hello', 'bye', 'sup', or 'hello there':");
            string answer = Console.ReadLine().ToLower();
            if (answer == "hello")
            {
                if (a1 < 2)
                {
                    Console.WriteLine("Hi good to see you");
                    a1++;
                }
                else Console.WriteLine("I'm sorry but you have already said that");
            }
            else if (answer == "bye")
            {
                Console.WriteLine("Good bye!");
                j++;
            }
            else if (answer == "sup")
            {
                if (a2 < 2)
                {
                    Console.WriteLine("I am good");
                    a2++;
                }
                else Console.WriteLine("I'm sorry but you have already said that");
            }
            else if (answer == "hello there")
            {
                if (a3 < 2)
                {
                    Console.WriteLine("General Kenobi");
                    a3++;
                }
                else Console.WriteLine("I'm sorry but you have already said that");
            }
            else Console.WriteLine("Sorry I don't understand, please try again");
        

        }
    }
}