def divisibleSumPairs(n, k, ar):
    # Write your code here
    count = 0
    for i in range(n-1):
        pairList = [x+ar[i] for x in ar[i+1:]]
        for num in pairList:
            if(num % k == 0):
                count = count + 1
    return count   
