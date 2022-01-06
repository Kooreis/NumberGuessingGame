# Python Documentation

# Number Guessing Game

This is a simple Python script for a number guessing game. The game generates a random number between 1 and 100, and the player has to guess the number. The game provides hints whether the guessed number is too high or too low, and continues until the player guesses the correct number. The game also keeps track of the number of tries the player took to guess the number.

## Script Explanation

The script starts by welcoming the player to the game and instructing them to guess a number between 1 and 100.

```python
print("Welcome to the Number Guessing Game!")
print("Guess a number between 1 and 100.")
```

The script then generates a random number between 1 and 100 using the `random.randint()` function. This is the number that the player has to guess. The script also initializes a counter variable `number_of_tries` to keep track of the number of guesses made by the player.

```python
number_to_guess = random.randint(1, 100)
number_of_tries = 0
```

The script then enters an infinite loop where it repeatedly asks the player to enter their guess. The player's guess is read using the `input()` function and converted to an integer using the `int()` function.

```python
while True:
    user_guess = int(input("Your guess: "))
    number_of_tries += 1
```

The script then checks if the player's guess is less than, greater than, or equal to the generated number. If the guess is less than the number, it prints "Too low!". If the guess is greater than the number, it prints "Too high!". If the guess is equal to the number, it congratulates the player, tells them the number of tries they took, and breaks out of the loop.

```python
    if user_guess < number_to_guess:
        print("Too low!")
    elif user_guess > number_to_guess:
        print("Too high!")
    else:
        print("Congratulations! You found the number in " + str(number_of_tries) + " tries.")
        break
```

## Imported Libraries

The script imports the `random` library, which is a built-in Python library for generating random numbers. The `random.randint(a, b)` function is used in this script to generate a random integer between `a` and `b` (both inclusive).

---

# C# Documentation

# Number Guessing Game in C#

This repository contains a simple console-based number guessing game implemented in C#. The game generates a random number between 1 and 100, and the player's goal is to guess this number.

## Script Description

The script initiates a game where the user is asked to guess a number between 1 and 100. The game continues until the user guesses the correct number. After each guess, the game provides a hint whether the guessed number is too high or too low. The game also keeps track of the number of attempts the user has made.

## Code Breakdown

```CSharp
using System;
```
The `System` namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

```CSharp
Random random = new Random();
int secretNumber = random.Next(1, 101);
```
A new instance of the `Random` class is created, which is then used to generate a random number between 1 and 100. This number is what the user will attempt to guess.

```CSharp
int attempts = 0;
bool isGuessed = false;
```
Two variables are initialized: `attempts` to keep track of the number of guesses the user makes, and `isGuessed` to determine when the game should end.

```CSharp
while (!isGuessed)
```
The game continues to run as long as the `isGuessed` variable is `false`.

```CSharp
if (int.TryParse(userInput, out userGuess))
```
The `int.TryParse` method is used to check if the user's input can be converted to an integer. If it can, the input is stored in the `userGuess` variable.

```CSharp
if (userGuess > secretNumber)
{
    Console.WriteLine("Too high! Try again:");
}
else if (userGuess < secretNumber)
{
    Console.WriteLine("Too low! Try again:");
}
else
{
    Console.WriteLine($"Congratulations! You've guessed the number in {attempts} attempts.");
    isGuessed = true;
}
```
The user's guess is compared to the secret number. If the guess is too high or too low, the game provides a hint and asks for another guess. If the guess is correct, a congratulatory message is displayed, and the `isGuessed` variable is set to `true`, ending the game.

---

# Java Documentation

# Java Number Guessing Game

This is a simple number guessing game implemented in Java. The program generates a random number between 1 and 100, and the user is prompted to guess the number. The user has unlimited attempts to guess the number, and after each incorrect guess, the program provides a hint whether the guessed number is too high or too low. When the user guesses the number correctly, the program congratulates the user and displays the number of attempts it took to guess the number.

## Code Explanation

The script uses two imported Java libraries:

1. `java.util.Random`: This library is used to generate a random number which the user has to guess. The `nextInt(100)` method is used to generate a random integer between 0 (inclusive) and the specified value (exclusive), in this case 100.

2. `java.util.Scanner`: This library is used to read the user's input. The `nextInt()` method is used to get the integer that the user inputs as their guess.

The `main` method is the entry point of the program. It first generates a random number to guess and initializes the number of tries to 0. It then enters a while loop where it prompts the user to guess a number. If the guessed number is equal to the number to guess, the user wins and the loop ends. If the guessed number is less than the number to guess, the program prints "Too low! Try again." If the guessed number is greater than the number to guess, the program prints "Too high! Try again." The number of tries is incremented after each guess.

After the user guesses the number correctly, the program prints "You win!", the number that was to be guessed, and the number of tries it took the user to guess the number.

## How to Run

To run this program, you need to have Java installed on your machine. You can then compile the program using the `javac` command and run it using the `java` command.

---
