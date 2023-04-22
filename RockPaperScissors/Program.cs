namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
            
        }
        public static void Game()
        {
            int playerScore = 0;
            int computerScore = 0;

            while (true)
            {
                if (playerScore == 3)
                {
                    Utils.YouWin();
                    Utils.PlayAgain();
                }
                else if (computerScore == 3)
                {
                    Utils.YouLose();
                    Utils.PlayAgain();
                }
                Console.WriteLine(@"
__________ _________   ____  __.    __________ __________ __________       __________________ __________   _________ 
\______   \\_   ___ \ |    |/ _|    \______   \\______   \\______   \     /   _____/\_   ___ \\______   \ /   _____/ 
 |       _//    \  \/ |      <       |     ___/ |     ___/ |       _/     \_____  \ /    \  \/ |       _/ \_____  \  
 |    |   \\     \____|    |  \      |    |     |    |     |    |   \     /        \\     \____|    |   \ /        \ 
 |____|_  / \______  /|____|__ \     |____|     |____|     |____|_  /    /_______  / \______  /|____|_  //_______  / 
        \/         \/         \/                                  \/             \/         \/        \/         \/  
             -----------------------------------------------------------------------------------------------------
                            
");
                string[] choices = { "rock", "paper", "scissors" };
                // Getting and checking user choice.
                string playerChoice = Utils.getPlayerInput();
                bool isChoiceValid = false;
                foreach (string choice in choices)
                {
                    if (choice == playerChoice)
                    {
                        isChoiceValid = true;
                    }
                }
                if (!isChoiceValid)
                {
                    Utils.Exit("Invalid Choice");
                }
                // Getting computer choice.
                Random random = new Random();
                int randInt = random.Next(0, 3);
                string computerChoice = choices[randInt];

                // Comparing choices.
                if (playerChoice == computerChoice) {
                    Utils.ShowChoices(playerChoice, computerChoice, playerScore, computerScore);
                    continue;
                } else if ((playerChoice == "rock" && computerChoice == "scissors") || (playerChoice == "paper" && computerChoice == "rock") || (playerChoice == "scissors" && computerChoice == "paper"))
                {
                    playerScore += 1;
                    Utils.ShowChoices(playerChoice, computerChoice, playerScore, computerScore);
                    continue;
                } else
                {
                    computerScore += 1;
                    Utils.ShowChoices(playerChoice, computerChoice, playerScore, computerScore);
                    continue;
                }
                
            }

        }
    }
}