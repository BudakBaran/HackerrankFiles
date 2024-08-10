def breakingRecords(scores):
    # Write your code here
    breakMin = 0
    minScore = 0
    maxScore = 0
    breakMax = 0
    
    minScore = scores[0]
    maxScore = scores[0]
    for score in scores[1:]:
        if score < minScore:
            breakMin = breakMin + 1
            minScore = score
        elif score > maxScore:
            breakMax = breakMax + 1
            maxScore = score
    return [breakMax, breakMin]