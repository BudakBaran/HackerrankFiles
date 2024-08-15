def migratoryBirds(arr):
    return max(set(arr), key = arr.count)

#dictionary version runs fastly

def migratoryBirds(arr):
    birdDict = {}
    mostFrequentBird=""
    mostFrequentCount=0
    sameFrequentBirdList=[]
    for bird in arr:
        birdDict[bird] = birdDict.get(bird,0) + 1
        if(birdDict[bird] > mostFrequentCount):
            mostFrequentCount = birdDict[bird]
            mostFrequentBird = bird
            sameFrequentBirdList=[]
            sameFrequentBirdList.append(bird)
        elif (birdDict[bird] == mostFrequentCount):
            sameFrequentBirdList.append(bird)
    return min(sameFrequentBirdList)