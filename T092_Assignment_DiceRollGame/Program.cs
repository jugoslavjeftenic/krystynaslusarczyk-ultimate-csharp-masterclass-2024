using T092_Assignment_DiceRollGame;

Dice dice = new(new Random());
DiceRollGame diceRollGame = new(dice);

GameResult gameResult = diceRollGame.Play();
DiceRollGame.PrintResult(gameResult);
