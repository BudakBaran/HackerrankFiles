public static int birthdayCakeCandles(List<int> candles)
{
    int maxLen = 0;
    int maxLenCount = 0;
    foreach(int candle in candles){
        if(candle > maxLen){
            maxLen = candle;
            maxLenCount = 1;
        }else if(candle == maxLen){
            maxLenCount = maxLenCount + 1;
        }
    }
    return maxLenCount;
}