function birthdayCakeCandles(candles) {
    // Write your code here
    let maxLengthCount=0;
    let maxLength=0;
    for(let i = 0; i < candles.length; i++){
        if(candles[i] > maxLength){
            maxLengthCount = 1;
            maxLength = candles[i];
        }else if(maxLength == candles[i]){
            maxLengthCount = maxLengthCount + 1;
        } 
    }
    return maxLengthCount;
}