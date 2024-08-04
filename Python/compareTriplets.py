def compareTriplets(a, b):
    # Write your code here
    alicePoint = 0
    bobPoint = 0
    for idx, aliceP in enumerate(a):
        if aliceP > b[idx]:
            alicePoint+=1
        elif aliceP < b[idx]:
            bobPoint+=1
    return [alicePoint, bobPoint]            
