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
        if (point <= 5)
        {
            Console.WriteLine($"Nice try {name}, you still did your best, you just need a little more practice.");
        }
        else if (point >= 6)
        {
            Console.WriteLine($"Good job {name}, you did great on this quiz!");
        }
        else if (point >= 10)
        {
            Console.WriteLine($"Wow, you really did great on this quiz {name}!");
        }
        else if (point >= 20)
        {
            Console.WriteLine($"WOW {name}! You did really great on this quiz, you almost got the perfect score!");
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
    /* if user selects 1 it will go to level 1
     * it will display the question and choices per number
     * if the user submits any other key except for A,B,C,D it will ask them to submita valid answer
     * if the user submits the correct answer it will add 1 point to their score and display a message
     * if the user submits the wrong answer, their score will remain the same and display a message
     * */
    void level1()
    {
        Console.WriteLine("1. On sunny days we need to wear a pōtae on our heads. What is a pōtae? \nA. GLASSES\nB. HAT\nC. SCARF\nD. WIG");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("2. E tū and e noho are...\nA. JUMP AND DANCE\nB. RUN AND WALK\nC. CLAP AND LAUGH\nD. STAND UP AND SIT DOWN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("3. Tamariki are like a map of their own parents. What is Tamariki?\nA. ADULTS\nB. CHILDREN\nC. TREES\nD. LAKES");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("4. The colour of the bag is as kākāriki as a plant. What is kākāriki?\nA. PINK\nB. YELLOW\nC. GREEN\nD. BLUE");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("5. What animal is a Hoiho?\nA. GOAT\nB. HORSE\nC. PIGEON\nD. CAT");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("6. Moana greets Mōrena to her neighbours everyday at 7am. What is Mōrena?\nA. GOODBYE\nB. MORE PLEASE\nC. STAY THERE\nD. GOOD MORNING");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("7. I'm hungry. can we get some kai? What is kai?\nA. CLOTHES\nB. FOOD\nC. TOYS\nD. SLEEP");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("8. The color of the flamingo is māwhero. What is māwhero?\nA. RED\nB. GREEN\nC. PINK\nD. YELLOW");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("9. What animal is a poaka?\nA. DUCK\nB. MOUSE\nC. TIGER\nD. PIG");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("10. The color of her hair is like wood, it's Parauri. What is Parauri?\nA. BLACK\nB. GREY\nC. BROWN\nD. GREEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        endscore();
    }
    /* if user selects 2 it will go to level 2
     * it will display the question and choices per number
     * if the user submits any other key except for A,B,C,D it will ask them to submita valid answer
     * if the user submits the correct answer it will add 1 point to their score and display a message
     * if the user submits the wrong answer, their score will remain the same and display a message
     * */
    void level2()
    {
        Console.WriteLine("1. Kupu o te Ra means...\nA. WORD OF THE DAY\nB. WORD ON THE STREET\nC. DO YOUR SPELLING HOMEWORK\nD. THE SUN IS TALKING");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("2. If you are feeling Harikoa, what are you feeling?\nA. SAD\nB. HAPPY\nC. SUPRISED\nD. SICK");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("3. Which of the following Maori words means bird?\nA. HIPI\nB. HEIHEI\nC. MANU\nD. NGERU");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("4. If our Tumuaki was doing a Kanikani. What would he be doing?\nA. SITTING\nB. WALKING\nC. RUNNING\nD. DANCING");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("5. What does the word Whanau mean?\nA. FAR NOW\nB. FOUR\nC. FAMILY\nD. FAIR");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("6. Where would you be if you were in a Whare Kakano?\nA. CHICKEN COOP\nB. SEED HOUSE\nC. DINING HALL\nD. MEETING HOUSE");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("7. Where would you be if you were in a Whare Heihei?\nA. CHICKEN COOP\nB. SEED HOUSE\nC. DINING HALL\nD. MEETING HOUSE");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("8. Where would you be if you were in a Whare Kai?\nA. CHICKEN COOP\nB. SEED HOUSE\nC. DINING HALL\nD. MEETING HOUSE");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("9. Where would you be if you were in a WhareNUI?\nA. CHICKEN COOP\nB. SEED HOUSE\nC. DINING HALL\nD. MEETING HOUSE");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("10. What does the word aroha means?\nA. ARROW HEAD\nB. LOVE\nC. AROUND\nD. BACK");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        endscore();
    }
    /* if user selects 3 it will go to level 3
     * it will display the question and choices per number
     * if the user submits any other key except for A,B,C,D it will ask them to submita valid answer
     * if the user submits the correct answer it will add 1 point to their score and display a message
     * if the user submits the wrong answer, their score will remain the same and display a message
     * */
    void level3()
    {
        Console.WriteLine("1.Heoi anō tāku mō nāianei means...\nA. LET US GO\nB. THAT IS ALL FOR NOW\nC. THANK YOU\nD. HOW ARE YOU");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "B")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("2. Kia ora rawa atu means...\nA. MANY THANKS\nB. YOUR WELCOME\nC. THAT IS ALL FOR NOW\nD. REGARDS");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("3. Ngā mihi means...\nA. MANY THANKS\nB. YOUR WELCOME\nC. THAT IS ALL FOR NOW\nD. REGARDS");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("4. Noho ora mai means...\nA. ALL THE BEST\nB. YOURS SINCERELY\nC. SEE YOU\nD. WITH BEST WISHES");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("5. Ngā manaakitanga means...\nA. ALL THE BEST\nB. YOURS SINCERELY\nC. SEE YOU\nD. WITH BEST WISHES");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("6. He tī māu? means...\nA. WOULD YOU LIKE A TEA\nB. WHERE\nC. YES, ONE MOMENT PLEASE\nD. MY COMPUTER IS BROKEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("7. Kua te pakaru taku rorohiko means...\nA. WOULD YOU LIKE A TEA\nB. WHERE\nC. YES, ONE MOMENT PLEASE\nD. MY COMPUTER IS BROKEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "D")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("8. Ki hea means...\nA. WOULD YOU LIKE A TEA\nB. WHERE\nC. YES, ONE MOMENT PLEASE\nD. MY COMPUTER IS BROKEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("9. Āe, taihoa ake nei means...\nA. WOULD YOU LIKE A TEA\nB. WHERE\nC. YES, ONE MOMENT PLEASE\nD. MY COMPUTER IS BROKEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "C")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        Console.WriteLine("10. Me hui tahi tāua means...\nA. I WOULD LIKE TO MEET WITH YOU\nB. I WOULD LIKE TO MEET WITH YOU ALL\nC. YES, I HAVE A PEN\nD. NO, I DON'T HAVE A PEN");
        Console.WriteLine("Answer: ");
        answer = Console.ReadLine();
        while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
        {
            Console.WriteLine("Please write a valid answer from the choices. Make sure that your answer is in upper case.");
            answer = Console.ReadLine();
        }
        Console.Clear();

        if (answer == "A")
        {
            point += 1;
            Console.WriteLine("Correct");
        }
        else
        {
            point += 0;
            Console.WriteLine("Incorrect");
        }
        endscore();
    }

}