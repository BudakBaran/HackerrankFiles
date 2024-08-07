def findMinFiveSum(arr):
    sumMinFive = 0
    for i in range(4):
        sumMinFive = sumMinFive + arr[i]
    return sumMinFive    

def findMaxFiveSum(arr):
    sumMaxFive = 0
    for i in range(4):
        sumMaxFive = sumMaxFive + arr[len(arr)-i-1]
    return sumMaxFive    
           
def miniMaxSum(arr):
    arr.sort()
    print(findMinFiveSum(arr), findMaxFiveSum(arr))
    # Write your code here