Random card = new Random();


//player's card draws and the total value of all the player's cards
int firstCard = 0;
int secondCard = 0;
int thirdCard = 0;
int fourthCard = 0;
int fifthCard = 0;
int playerCardTotal = 0;

//stores the user's response to the prompt "play Blackjack?"
string? playGame = "";

//opponent's card draws and the total value of all the opponent's cards
int opponentCard1 = 0;
int opponentCard2 = 0;
int opponentCard3 = 0;
int opponentCardTotal = 0;

Console.WriteLine("Would you like to play blackjack?");
Console.WriteLine("Type 'yes' or 'no'.");

//TO_DO : cast playgame value .ToLower
playGame = Console.ReadLine();

//TO-DO:
//1 output game rules
//2 create outer loop for playgame value of 'yes'or 'no'
//3 create inner loop for draw card = 'yes'or 'no'

//Game Loop
do
{

    Console.WriteLine("BlackJack Rules:");
    Console.WriteLine("Aces are worth 1, Jack = 11, Queen = 12, King = 13. There are no jokers.");

    Console.WriteLine("You will begin with one card. At the start of the round, you will see the sum of your opponent's hand.");
    Console.WriteLine("Your goal is to get the sum off all cards in your hand as close as possible to 21, without going over.");
    Console.WriteLine("Continue drawing cards until the sum of your hand is greater than your opponent, but less than 21.");
    Console.WriteLine("If the sum of your cards exceeds 21, you lose. If your opponent's hand is closer to 21 than yours, you lose.");
    Console.WriteLine("If you beat your opponent's hand without going over 21, you win!");

    firstCard = card.Next(1, 14);


    switch (firstCard)
    {
        case 1:
        Console.WriteLine("Your first card is an Ace");
        break;

        case 2:
        Console.WriteLine("Your first card is a 2");
        break;

        case 3:
        Console.WriteLine("Your first card is a 3");
        break;

        case 4:
        Console.WriteLine("Your first card is a 4");
        break;

        case 5:
        Console.WriteLine("Your first card is a 5");
        break;

        case 6:
        Console.WriteLine("Your first card is a 6");
        break;

        case 7:
        Console.WriteLine("Your first card is a 7");
        break;

        case 8:
        Console.WriteLine("Your first card is an 8");
        break;

        case 9:
        Console.WriteLine("Your first card is a 9");
        break;

        case 10:
        Console.WriteLine("Your first card is a 10");
        break;

        case 11:
        Console.WriteLine("Your first card is a Jack");
        break;

        case 12:
        Console.WriteLine("Your first card is a Queen");
        break;

        case 13:
        Console.WriteLine("Your first card is a King");
        break;

    }


} while (playGame == "yes");

