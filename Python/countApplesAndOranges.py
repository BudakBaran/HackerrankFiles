def countApplesAndOranges(s, t, a, b, apples, oranges):
    # Write your code here
    applesUpdated = [apple + a for apple in apples] 
    orangesUpdated = [orange + b for orange in oranges]
    insideAppleCount = 0
    insideOrangeCount = 0
    for apple in applesUpdated:
        if apple >= s and apple <= t:
            insideAppleCount = insideAppleCount + 1
            
    for orange in orangesUpdated:
        if orange >= s and orange <= t:
            insideOrangeCount = insideOrangeCount + 1
    print(insideAppleCount)
    print(insideOrangeCount)