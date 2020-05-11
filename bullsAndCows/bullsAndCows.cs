using System;

namespace bullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Initial number: ");
            string input = Console.ReadLine();
            string guessing = "";
            int attempts = 0;

            int initialNumber = 0, guessingNumber = 0;

            while (input != "Exit")
            {
                for (int firstDigit = 0; firstDigit <= input.Length - 2; firstDigit++)
                {
                    for (int secondaryDigit = firstDigit + 1; secondaryDigit <= input.Length - 1; secondaryDigit++)
                    {
                        if (input[firstDigit] == input[secondaryDigit])
                        {
                            Console.WriteLine("Invalid initial number. The digits should be different from each other.");
                            Console.Write("Try a different initial number: ");
                            goto Input;
                        }

                        if (Char.ConvertToUtf32(input, firstDigit) < 48 || Char.ConvertToUtf32(input, firstDigit) > 57 || Char.ConvertToUtf32(input, secondaryDigit) < 48 || Char.ConvertToUtf32(input, secondaryDigit) > 57)
                        {
                            Console.WriteLine("Invalid initial number. The initial number should only contain different digits.");
                            Console.Write("Try a different initial number: ");
                            goto Input;
                        }
                    }
                }

                initialNumber = int.Parse(input);

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Competition has started. We have a valid initial number set.");

            Guessing:
                guessing = Console.ReadLine();
                if (guessing == "Exit") goto Exit;

                int bulls = 0, cows = 0;

                for (int firstDigit = 0; firstDigit <= guessing.Length - 2; firstDigit++)
                {
                    for (int secondaryDigit = firstDigit + 1; secondaryDigit <= guessing.Length - 1; secondaryDigit++)
                    {
                        if (guessing[firstDigit] == guessing[secondaryDigit])
                        {
                            Console.WriteLine("Invalid guessing number. The digits should be different from each other.");
                            Console.Write("Try a different guessing number: ");
                            goto Guessing;
                        }

                        if (Char.ConvertToUtf32(guessing, firstDigit) < 48 || Char.ConvertToUtf32(guessing, firstDigit) > 57 || Char.ConvertToUtf32(guessing, secondaryDigit) < 48 || Char.ConvertToUtf32(guessing, secondaryDigit) > 57)
                        {
                            Console.WriteLine("Invalid guessing number. The guessing number should only contain different digits.");
                            Console.Write("Try a different guessing number: ");
                            goto Guessing;
                        }
                    }
                }

                guessingNumber = int.Parse(guessing);
                attempts++;

                if (guessingNumber == initialNumber) break;
                else
                {
                    for (int initialDigitPosition = 0; initialDigitPosition <= input.Length - 1; initialDigitPosition++)
                    {
                        for (int guessingDigitPosition = 0; guessingDigitPosition <= guessing.Length - 1; guessingDigitPosition++)
                        {
                            if (input[initialDigitPosition] == guessing[guessingDigitPosition])
                            {
                                if (initialDigitPosition == guessingDigitPosition) bulls++;
                                else cows++;
                            }
                        }
                    }
                }

                if (bulls == 0)
                {
                    if (cows == 0)
                    {
                        Console.WriteLine($"Your try with {guessing} do not contain any correct numbers.");
                        Console.Write("Next try...");
                        goto Guessing;
                    }
                    else
                    {
                        Console.WriteLine($"Your try with {guessing} has {cows} cow(s).");
                        Console.Write("Next try...");
                        goto Guessing;
                    }
                }
                if (bulls > 0)
                {
                    if (cows == 0)
                    {
                        Console.WriteLine($"Your try with {guessing} has {bulls} bulls(s).");
                        Console.Write("Next try...");
                        goto Guessing;
                    }
                    else
                    {
                        Console.WriteLine($"Your try with {guessing} has {bulls} bull(s) and {cows} cow(s).");
                        Console.Write("Next try...");
                        goto Guessing;
                    }
                }

            Input:
                input = Console.ReadLine();
            }

            if (guessingNumber == initialNumber && guessingNumber != 0 && initialNumber != 0)
            {
                Console.WriteLine($"Congratulations! You won the game with {attempts} attempts!\nThe guessed number is {guessingNumber}");
            }

        Exit:
            if (input == "Exit" || guessing == "Exit")
            {
                Console.Clear();
                Console.WriteLine("Exiting the game...");
                Console.ReadKey();
                return;
            }
        }
    }
}
