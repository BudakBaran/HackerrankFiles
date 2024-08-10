function divisibleSumPairs(n, k, ar) {
    // Write your code here
    let count = 0;
    for(var i = 0; i < n-1; i++){
       const pairList = ar.slice(i+1, n).map(x=> x = x + ar[i]);
       pairList.forEach(function(number){
          if(number % k == 0){
              count = count + 1;
          } 
       });
    }
    return count;
}