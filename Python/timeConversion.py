def timeConversion(s):
    # Write your code here
    lastTwo = s[len(s) - 2:]
    remainWithoutLastFirstTwo = s[:len(s) - 2]
    firstTwo = s[:2]
    remainWithoutLastFirstTwo = remainWithoutLastFirstTwo[2:]
    intFirstTwo = int(firstTwo)
    if lastTwo == "AM":
        if int(firstTwo) >= 12:
            intFirstTwo = intFirstTwo-12
    else:
        if int(firstTwo) < 12:
            intFirstTwo = intFirstTwo+12
    return str(intFirstTwo).zfill(2)+remainWithoutLastFirstTwo