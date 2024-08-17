def sockMerchant(n, ar):
    # Write your code here
    pairCount={}
    
    for i in range(n):
        if ar[i] not in pairCount.keys():
            pairCount[ar[i]]=False
        else:
            pairCount[ar[i]] = not pairCount[ar[i]]
    return (n-sum(value == False for value in pairCount.values())) // 2 