function less(num1, num2) {
    if (num1 > num2) {
        return num1
    }
    else return num2
}

function calculate(num1, num2, symbol) {
    switch (symbol) {
        case "+":
            return num1 + num2;
            break;
        case "-":
            return num1 - num2;
            break;

        case "*":
            return num1 * num2;
            break;

        case "/":
            return num1 / num2;
            break;
        default:
            return "Exception!"
    }

}

function isNumberPrime(num){
    let A = true;
    for(let i = 2; i < num; i++){
        if(num % i == 0){
            A = false;
        }
    }
    if(A){
        return "Prime";
    }
    else return "Not a Prime";
}

function biggestNumber(){
    let biggest = arguments[0];
    for (const iterator of arguments) {
        if(biggest < iterator){
            biggest = iterator;
        }
    }
    return biggest;
}

function showAllOddOrEvenNumbers(num1, num2, checkForEven) {
    if(num1 > num2){
        [num1, num2] = [num2, num1];        
    }
    let numbers = new Array();
    if(checkForEven == false){
        for(let i = num1; i <= num2;i++){
            if((i % 2) == 1){
                numbers.push(i);
            }
        }
    }
    if(checkForEven == true){
        for(let i = num1; i <= num2; i++){
            if((i % 2) == 0){
                numbers.push(i);
            }
        }
    }
    return numbers;
}