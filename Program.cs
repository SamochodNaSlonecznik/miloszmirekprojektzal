internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ill ask you 5 simple questions, in order to be a citizen of Chrzanów you must answer at least 3 correctly");

        Console.WriteLine("Who's the current major of Chrzanów?");
        string firstPlayerAnswer = Console.ReadLine();
        if (firstPlayerAnswer == "Robert Maciaszek")
        {
            Console.WriteLine("Good, that was an easy question, next one will be harder");
        }
        else
        {
            Console.WriteLine("What? Of course not. You're trying to a citizen of Chrzanów but you don't even know who's the mayor.");
            Console.WriteLine("I doubt you will be able to answer the next question. Well here goes nothing");
        }

        // 4. count the correct answers
        // 5. if player has more then 3 correct answers he is a citizen and if not then he is a losser

        Console.WriteLine("Dziękuje za test, jesteś teraz obywatelem miasta Chrzanowa");
        Console.ReadLine();
    }
}