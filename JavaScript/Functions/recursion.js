function factorial(num) {
    if(num < 0){
        return -1;
    }
    if(num == 1 || num == 0)
        return 1;
    return num * factorial(num-1);
}

function showNumberInDiapason(num1, num2) {
    if(num1 == num2){
        console.log(num2);
        return;
    }
    console.log(num1);
    showNumberInDiapason(num1 + 1, num2);
}

function showNumberInDiapasonDescending(num1, num2) {
    if(num1 == num2){
        console.log(num1);
        return;
    }
    console.log(num2);
    showNumberInDiapasonDescending(num1, num2 - 1);
}

function reverseWithRecursion(number) {
    if(number > 10){
        return `${number % 10}`+reverseWithRecursion(Math.floor((number / 10)));
    }
    else{
        return `${number}`;
    }
    //Array.reverse() - not today
    //String.reverse() - not today :)
}

function sumOfNumbersDigits(number) {
    if(number > 10){
        return number % 10 + sumOfNumbersDigits(Math.floor((number / 10)));
    }
    else{
        return number;
    }
}

function writeRoundBrackets(numberOfBrackets, closeCount) {
    if(closeCount === undefined){
        closeCount = 0;
    }
    if(numberOfBrackets > 0){
        return `(` + writeRoundBrackets(numberOfBrackets - 1, closeCount + 1);
    }
    if(numberOfBrackets == 0 && closeCount > 0){
        return `)` + writeRoundBrackets(numberOfBrackets, closeCount - 1);
    }
    if(numberOfBrackets == 0 && closeCount == 0){
        return "";
    }
}