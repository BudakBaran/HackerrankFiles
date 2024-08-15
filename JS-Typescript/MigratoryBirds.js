function migratoryBirds(arr) {
    // Write your code here
    let birdDictionary = {}
    let mostFrequentBirdCount = 0;
    let sameFrequentList = [];
    arr.forEach(function(bird){
        
       if(birdDictionary[bird] === undefined ||  birdDictionary[bird] === null){
           birdDictionary[bird] = 1;
       }else{
            birdDictionary[bird] = birdDictionary[bird] + 1;
       }
       
       if( birdDictionary[bird] > mostFrequentBirdCount){
           mostFrequentBirdCount = birdDictionary[bird];
           sameFrequentList=[bird]
       }else if(mostFrequentBirdCount === birdDictionary[bird]){
           sameFrequentList=[...sameFrequentList,bird]
       }
    });
    return Math.min(...sameFrequentList);
}