def countingValleys(steps, path):
    # Write your code here
    currHeight = 0
    isUnderCheck = False
    countValley = 0
    for step in range(steps):
        if path[step] == 'U':
            currHeight = currHeight + 1

        elif path[step] == 'D':
            currHeight = currHeight - 1

        if currHeight < 0:
            isUnderCheck = True
        else:
            if( isUnderCheck ):
                countValley = countValley + 1
                isUnderCheck = False
            else:
                isUnderCheck = False
    return countValley 