# Shell Scripting Activity:
# Write a number guessing game where the user has to guess a randomly 
# generated secret number between 0 and 100. After each guess, tell the 
# user if they guessed it right, and if not, tell the user if they were 
# over or under and how far off their guess was using temperature 
# adjectives (hot, warm, cold, etc..). Also in each try, display how 
# many times they have tried so far.

# Hint: Bash has built in function $RANDOM that generates a pseudo random number between 0 and 32767. use Modulo operator to restrict the bounds of the random number (ie, for a random number between 0 and 10, $RANDOM % 10)

# Expected Behavior
# First, generate a random number
# ask user for a guess
# tell them whether they were over or under and how far off they were
# also tell them how many times they've tried so far


randomNum=$(($RANDOM % 100))
counter = 0

echo "Try and guess the random number! (between 0 and 100)"
echo "The number is" $randomNum
read number
while [ $number -lt 0 ] || [ $number -gt 100 ]
do
    echo "Please enter a number between 0 and 100."
    read number
done
echo""
counter=$((counter+1))

while [ $number != $randomNum ]
do
    if [ $number -gt $randomNum ]
    then
        echo "You're wrong! You guessed too high."
        if [ $(($number - $randomNum)) -le 5 ]
        then
            echo "You're super hot!"
        elif [ $(($number - $randomNum)) -le 15 ]
        then
            echo "You're hot!"
        elif [ $(($number - $randomNum)) -le 25 ]
        then
            echo "You're warm!"
        elif [ $(($number - $randomNum)) -le 35 ]
        then
            echo "You're cold!"
        else
            echo "You're freezing!"
        fi
        echo "Number of tries:" $counter
        echo "Please guess again."
        read number
        while [ $number -lt 0 ] || [ $number -gt 100 ]
        do
            echo "Please enter a number between 0 and 100."
            read number
        done
        echo ""
        counter=$((counter+1))
    elif [ $number -lt $randomNum ]
    then
        echo "You're wrong! You guessed too low."
        if [ $(($randomNum - $number)) -le 5 ]
        then
            echo "You're super hot!"
        elif [ $(($randomNum - $number)) -le 15 ]
        then
            echo "You're hot!"
        elif [ $(($randomNum - $number)) -le 25 ]
        then
            echo "You're warm!"
        elif [ $(($randomNum - $number)) -le 35 ]
        then
            echo "You're cold!"
        else
            echo "You're freezing!"
        fi
        echo "Number of tries:" $counter
        echo "Please guess again."
        read number
        while [ $number -lt 0 ] || [ $number -gt 100 ]
        do
            echo "Please enter a number between 0 and 100."
            read number
        done
        echo ""
        counter=$((counter+1))
    fi
done

echo ""
echo "Total number of guesses:" $counter
echo "You're right! Have a cookie!"