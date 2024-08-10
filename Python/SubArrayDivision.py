def birthday(s, d, m):
    # Write your code here
    count = 0
    for i in range(len(s)):
        if(i + m - 2 < len(s)):
            sumOfBars = sum(s[i: i+m])
            if(sumOfBars == d):
                count = count + 1
    return count    