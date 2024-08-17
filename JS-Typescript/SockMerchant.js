function sockMerchant(n, ar) {
    // Write your code here
    let pairCount={}
    
    ar.forEach(function(num){
       if(pairCount[num] === undefined){
           pairCount[num] = false;
       }else{
           pairCount[num] = !pairCount[num]
       }
    });
    
    let count = 0;
    for(var key in pairCount) {
        if(pairCount[key] == false){
            count = count + 1;
        }
    }
    return (n - count)/2
} 