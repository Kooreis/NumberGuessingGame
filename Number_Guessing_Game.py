import random

print("Welcome to the Number Guessing Game!")
print("Guess a number between 1 and 100.")

number_to_guess = random.randint(1, 100)
number_of_tries = 0

while True:
    user_guess = int(input("Your guess: "))
    number_of_tries += 1

    if user_guess < number_to_guess:
        print("Too low!")
    elif user_guess > number_to_guess:
        print("Too high!")
    else:
        print("Congratulations! You found the number in " + str(number_of_tries) + " tries.")
        break