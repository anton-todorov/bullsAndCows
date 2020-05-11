# Bulls and Cows game (Console .NET core)
The game of Bulls and Cows in console .Net core version

## About
[Bulls and Cows](https://en.wikipedia.org/wiki/Bulls_and_Cows) (also known as **Cows and Bulls** or **Pigs and Bulls**) is an old code-breaking mind or paper and pencil game for two or more players, predating the commercially marketed board game [Mastermind](https://en.wikipedia.org/wiki/Mastermind_(board_game)).

It is a game that may date back a century or more which uses numbers or words. It is played by two opponents.

## Game rules
Bulls and Cows is a 2 player game. One player thinks of a number, while the other player tries to guess it.

* The number to be guessed must be a 4 digit number, using only digits from 1 - 9, each digit atmost once. e.g. 1234 is valid, 0123 is not valid, 9877 is not valid, 9876 is valid.
* For every guess that the player makes, he gets 2 values - the number of bulls and the number of cows. 1 bull means the guess contains and the target number have 1 digit in common, and in the correct position. 1 cow means the guess and the target have 1 digit in common, but not in correct position. e.g. Let the target be 1234. Guessing 4321 will give 0 bulls and 4 cows. 3241 will give 1 bull and 3 cows. 4 bulls means you have won the game!

## Prerequisites
```
.NET core 3.1
```

## To-Do List
- Different levels for playing, showing differently complexed output
 
 ## Authors
* **Anton Todorov** - *Initial work* - [LinkedIn](www.linkedin.com/in/anton-todorov89) | [GitHub](https://github.com/anton-todorov)

### Others
[Contributors](https://github.com/anton-todorov/bullsAndCows/graphs/contributors) who participated in this project.

## License

This project is free of license, thus LICENSE.md is not present.

## Credits and acknowledgments
* **Anton Todorov** - *Initial work* - [LinkedIn](www.linkedin.com/in/anton-todorov89) | [GitHub](https://github.com/anton-todorov)
