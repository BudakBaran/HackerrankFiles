def plusMinus(arr):
    # Write your code here
    positiveCount=0
    negativeCount=0
    zeroCount=0
    arrLength = float(len(arr))
    for val in arr:
        if float(val) > 0:
            positiveCount+=1
        elif float(val) < 0:
            negativeCount+=1
        else:
            zeroCount+=1
    print(positiveCount/arrLength)
    print(negativeCount/arrLength)
    print(zeroCount/arrLength)