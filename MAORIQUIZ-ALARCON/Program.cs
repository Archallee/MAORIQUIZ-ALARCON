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

    }
}