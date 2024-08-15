public static int migratoryBirds(List<int> arr)
{
    Dictionary<int,int> birdCountListDict = new Dictionary<int,int>();
    int mostFrequentBirdCount = 0;
    List<int> sameFrequentList = new List<int>();
    
    foreach(int bird in arr){
        if(birdCountListDict.ContainsKey(bird)){
            
            birdCountListDict[bird] =  birdCountListDict[bird] + 1;
            if( birdCountListDict[bird] > mostFrequentBirdCount ){
                
                mostFrequentBirdCount = birdCountListDict[bird];
                sameFrequentList  = new List<int>();
                sameFrequentList.Add(bird);
            }else if(birdCountListDict[bird] == mostFrequentBirdCount ){
                sameFrequentList.Add(bird);
            }
        }else{
            birdCountListDict[bird]=1;
        }
    }
    return sameFrequentList.Min();
}