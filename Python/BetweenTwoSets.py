def checkIsAllArrayFactorOfNumber(element, arr):
    isFactor = True
    for number in arr:
        if(element % number != 0):
            isFactor = False
            continue
    return isFactor
def checkIsFactorNumberToArray(element, arr):
    isFactor = True
    for number in arr:
        if(number % element != 0):
            isFactor = False
            continue
    return isFactor
    
def getTotalX(a, b):
    # Write your code here
    res = []
    minElementSec = min(b)
    maxElementFirst = max(a)
    
    for number in range(maxElementFirst, minElementSec+1):
        if(checkIsAllArrayFactorOfNumber(number, a) and checkIsFactorNumberToArray(number,b)):
            res.append(number)
    return len(res)