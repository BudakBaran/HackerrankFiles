function checkIsArrayFactorialOfNumber(num, arr){
    let isFactorial = true;
    
    arr.some(function(element){
        if(num % element != 0){
            isFactorial = false;
            return true
        }
    });
    return isFactorial;
}

function checkIsNumFactorialOfArray(num, arr){
    let isFactorial = true;
    
    arr.some(function(element){
        if(element % num != 0){
            isFactorial = false;
            return true
        }
    });
    return isFactorial;
}

function getTotalX(a, b) {
    // Write your code here
    const minNumOfSecArr = Math.min.apply(Math,b);
    const maxOfFirstArr = Math.max.apply(Math,a);
    let size = 0;
    for(var facNum = maxOfFirstArr; facNum <= minNumOfSecArr; facNum++){
        if(checkIsNumFactorialOfArray(facNum, b) && checkIsArrayFactorialOfNumber(facNum, a)){
            size = size + 1;
        }
    }
    return size;
}