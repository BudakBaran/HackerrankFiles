function plusMinus(arr) {
    // Write your code here
        let positiveCount = 0;
        let negativeCount = 0;
        let zeroCount = 0;
        let arrLength = arr.length;
        arr.forEach((val) =>{
            if(val > 0){
                positiveCount++;
            }else if(val < 0){
                negativeCount++;
            }else{
                zeroCount++;
            }
        });
        console.log(positiveCount/arrLength);
        console.log(negativeCount/arrLength);
        console.log(zeroCount/arrLength);
}
