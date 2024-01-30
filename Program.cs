string EndGameCommand = "i don't know";
int PlayerPoints = 0;
Console.WriteLine("Ill ask you 3 simple questions, in order to be a citizen of Chrzanów you must answer all of them 3 correctly");
Console.WriteLine($"or you could write '{EndGameCommand}' but you would never do that right? haha");
Console.WriteLine("But before we start tell me, whats your name?");
string? PlayerName = Console.ReadLine();

if (PlayerName == EndGameCommand)
{
    Console.WriteLine($"wha... what? How can you '{EndGameCommand}'?! OK THEN mister {EndGameCommand}. How about you leave then? Actually no. You failed. BYE JOKER");
    goto ExitProgram;
}
else
{
    Console.WriteLine($"{PlayerName}? Nice name, alright now that i know your name lets begin with this first question!");
}
while (true)
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Who's the current major of Chrzanów?");
    string? firstPlayerAnswer = Console.ReadLine();

    if (firstPlayerAnswer == EndGameCommand)
    {
        Console.WriteLine($"Really? I was joking when i wrote that you can you can just type '{EndGameCommand}' you know that? Not even gonna try to throw a guess? Fine, then leave.");
        goto ExitProgram;
    }
    if (firstPlayerAnswer == "Robert Maciaszek" || firstPlayerAnswer == "Maciaszek")
    {
        PlayerPoints += 1;
        Console.WriteLine("Good, that was an easy question, next one will be harder");
        Console.WriteLine("------------------------------------");
    }
    else
    {
        Console.WriteLine("What? No. Of course not. You're trying to be a citizen of Chrzanów but you don't even know who's the mayor.");
        Console.WriteLine("I doubt you will be able to answer the next question. Well here goes nothing");
        Console.WriteLine("------------------------------------");
    }

    Console.WriteLine("What is happening on 'Kąty'?");
    firstPlayerAnswer = Console.ReadLine();
    if (firstPlayerAnswer == EndGameCommand)
    {
        Console.WriteLine($"Really? I was joking when i wrote that you can you can just type '{EndGameCommand}' you know that? Not even gonna try to throw a guess? Fine, then leave.");
        goto ExitProgram;
    }
    if (firstPlayerAnswer == "nothing")
    {
        PlayerPoints += 1;
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
    if (firstPlayerAnswer == EndGameCommand)
    {
        Console.WriteLine($"Really? I was joking when i wrote that you can you can just type '{EndGameCommand}' you know that? Not even gonna try to throw a guess? Fine, then leave.");
        break;
    }
    if (firstPlayerAnswer == "A" || firstPlayerAnswer == "319")
    {
        PlayerPoints += 1;
        Console.WriteLine("YES, that is correct. Two lines connect us that is A and 319. Too bad none of them are our buses");
        Console.WriteLine("Jaworzno owns them and our entire economy depends on them... or so was i told... it was revealed to me in a dream");
        Console.WriteLine("------------------------------------");
    }
    else
    {
        Console.WriteLine("You ether own a car or never been outside drunk with friends. I am not gonna even tell you what lines are they");
        Console.WriteLine("goodluck going back home without a bus.");
        Console.WriteLine("------------------------------------");
    }
    Console.WriteLine($"Your score is {PlayerPoints}");
    if (PlayerPoints == 0)
    {
        Console.WriteLine("Wow. This was absolutly Terrible");
        Console.WriteLine($"I'm gonna be honest with you {PlayerName}. You did so bad i won't even allow you to try again. Goodbye.");
        break;
    }
    if (PlayerPoints == 1 || PlayerPoints == 2)
    {
        Console.WriteLine("Better then nothing i guess. You can try again now that you know whats wrong");
    }
    else
    {
        Console.WriteLine($"OH WOW. well well then {PlayerName}. Congrats on becoming a new citizen of Chrzanów");
        Console.WriteLine($"This was Perfect and you tottaly deserve it. Thank you for taking the test and Goodbye {PlayerName}!");
        break;
    }
    PlayerPoints = 0;
}
ExitProgram:
Console.WriteLine("Press enter to leave");
Console.ReadLine();