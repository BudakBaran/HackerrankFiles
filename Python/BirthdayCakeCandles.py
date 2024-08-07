def birthdayCakeCandles(candles):
    # Write your code here
    maxLen = max(candles)
    maxLenCount = candles.count(maxLen)
    
    return maxLenCount

    # Upper here O(2N)

def birthdayCakeCandles(candles):
    # Write your code here
    maxLen = 0
    maxLenCount = 0
    for i in range(len(candles)):
        if maxLen < candles[i]:
            maxLenCount = 1
            maxLen = candles[i]
        elif maxLen == candles[i]:
            maxLenCount = maxLenCount + 1
    return maxLenCount