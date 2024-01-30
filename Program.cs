
using System.Runtime.CompilerServices;

Console.WriteLine("Ill ask you 5 simple questions, in order to be a citizen of Chrzanów you must answer at least 3 correctly");
        Console.WriteLine("------------------------------------");

        Console.WriteLine("Who's the current major of Chrzanów?");
        string? firstPlayerAnswer = Console.ReadLine();

if (firstPlayerAnswer == "I don't know")
{
    break;
}

        if (firstPlayerAnswer == "Robert Maciaszek")
        {
            Console.WriteLine("Good, that was an easy question, next one will be harder");
            Console.WriteLine("------------------------------------");
        }
        else
        {
            Console.WriteLine("What? Of course not. You're trying to be a citizen of Chrzanów but you don't even know who's the mayor.");
            Console.WriteLine("I doubt you will be able to answer the next question. Well here goes nothing");
            Console.WriteLine("------------------------------------");
        }
        Console.WriteLine("What is happening on 'Kąty'?");
        firstPlayerAnswer = Console.ReadLine();
        if (firstPlayerAnswer == "nothing")
        {
            Console.WriteLine("uh..yeah actually, nothing ever happens on Kąty. Fine that counts");
            Console.WriteLine("------------------------------------");
        }
         else
        {
         Console.WriteLine("you are WROOOOOONG, WRONG WRONG WROOOOONG. Nothing ever happens on kąty. NEXT QUESTION");
         Console.WriteLine("------------------------------------");
        }
        Console.WriteLine("What is the name of the bus line that connects Chrzanów and Jaworzno?");
        firstPlayerAnswer = Console.ReadLine();
        if (firstPlayerAnswer == "A" && firstPlayerAnswer == "319")
        {
            Console.WriteLine("YES, that is correct. Two lines connect us that is A and 319. Too bad none of them are our buses");
            Console.WriteLine("Jaworzno owns them and our entire economy depends on them... or so was i told... it was revealed to me in a dream");
            Console.WriteLine("ALRIGHT NEXT QUESTION");
            Console.WriteLine("------------------------------------");
        }
         else
        {
         Console.WriteLine("You ether own a car or never been outside drunk with friends. I am not gonna even tell you what lines are they");
         Console.WriteLine("goodluck going back home without a bus. I doubt you'll be able to answer next 2 questions");
         Console.WriteLine("------------------------------------");
        }       
// 4. count the correct answers
// 5. if player has more then 3 correct answers he is a citizen and if not then he is a losser

Console.WriteLine("Dziękuje za test, jesteś teraz obywatelem miasta Chrzanowa");
        Console.ReadLine();
