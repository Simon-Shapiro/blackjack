Random number = new Random();


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

firstCard = 

} while (playGame == "yes");

