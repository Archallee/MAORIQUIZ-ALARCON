using System.Diagnostics;
{
    /*declare play() so that the method returns to no value
     * ask for the user's name
     * should display an introduction with the user's name
     * ask user for which level
     * display total score of user
     * if users score less than or equal to 5, display a particular message
     * if users score more than or equal to 6, display a particular message
     * if users score less than or uqual to 20, display a particular message
     * if users score more than or equal to 21, display a particular message
     * display outro message and ask user if they want to play again
     * if they want to play again, they can press s 
     * if they don't want to play anymore, they can press any key to end the quiz 
     * thank the user for using this program
     */

    play();
}
static void play()
{
    string answer = "";

    int point = 0;

    Console.Clear();
    Console.WriteLine("Welcome to the Maori Quiz!\nWhat\'s your name?");

    string name = Console.ReadLine();

    Console.WriteLine($"Okay {name}, This multiple choice quiz will contain 3 levels and 10 questions");
    Console.WriteLine($"Make sure to read each question carefully,\nGoodluck {name.ToUpper()}!");
    start();

    void start()
    {
        Console.WriteLine("Please choose a level you want to answer:\n1. Easy\n2. Medium\n3. Hard");
        int chose = (Convert.ToInt32(Console.ReadLine()));
        while (!int.TryParse(Console.ReadLine(), out chose) || chose <= 0 || chose >= 4)
        {
            Console.WriteLine("Please enter a valid number");
        }
        Console.WriteLine(chose);
        Console.Clear();

        if (chose == 1)
        {
            level1();
        }

        else if (chose == 2)
        {
            level2();
        }

        else if (chose == 3)
        {
            level3();
        }
        else
        {
            Console.WriteLine("Please enter a valid option");
            start();
        }
    }
    void endscore()
    {
        //this will indicate the total score and will give a particular message.
        Console.WriteLine("Your total score is " + point);
        if (point < 5)
        {
            Console.WriteLine($"Nice try {name}, you still did your best, you just need a little more practice.");
        }
        else if (point > 5)
        {
            Console.WriteLine($"Good job {name}, you did great on this quiz!");
        }
        Console.WriteLine("\nCongratulations on finishing the quiz!\n\nIf you want to try another level press s, but if you want to exit thi program press any oter key\n");

        string restart = Console.ReadLine();

        if (restart == "s")
        {
            Console.Clear();
            start();
        }
        else
        {
            Console.Write("Thank you very much for using his program, I hope you had fun!\n\npress enter to exit.");
            Environment.Exit(0);
        }
    }
}