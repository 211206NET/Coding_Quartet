# !/bin/bash



randomNum=$((RANDOM % 100))
counter=0

echo "please choose random number between 0 and 100"
echo $randomNum
read number

while [ $number -lt 0 ] || [ $number -gt 100 ]
do
    echo "Please enter a number between 0 and 100."
    read number
done
echo""
counter=$((counter+1))

((equation=($randomNum - $number)))
result=${equation#-}

while [ $number != $randomNum ]
do
    if [ $result -le 15 ]
    then
        echo "You're burning up"
    elif [ $result -le 25 ]
    then 
        echo "You're hot"
    elif [ $result -le 35 ]
    then
        echo "You are cold"
    else 
        echo "Frost bite is about to set in"
    fi
    
    echo "Please guess again."
    read number
    ((equation=($randomNum - $number)))
    result=${equation#-}
    counter=$((counter+1))

    while [ $number -lt 0 ] || [ $number -gt 100 ]
    do
        echo "Please enter a number between 0 and 100."
        read number

    done
echo "you tried "$counter "times"
done
echo ""
echo "You're Right!"

