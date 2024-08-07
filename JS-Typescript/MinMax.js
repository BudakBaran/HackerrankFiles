function findMinSum(arr){
    let sum=0;
    for(let i = 0; i < 4; i++){
        sum = sum + arr[i]; 
    }
    return sum;
}

function findMaxSum(arr){
    let sumMax=0;
    for(let i = 0; i < 4; i++){
        sumMax = sumMax + arr[arr.length-i-1]; 
    }
    return sumMax;
}

function miniMaxSum(arr) {
    // Write your code here
    arr.sort();
    console.log(findMinSum(arr)+" "+findMaxSum(arr))
    
}