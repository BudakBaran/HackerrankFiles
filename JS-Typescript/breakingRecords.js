function breakingRecords(scores) {
    // Write your code here
    let minBreak = 0;
    let maxBreak = 0;
    
    let minScore=scores[0];
    let maxScore=scores[0];
    
    scores.forEach(function(score){
        if(score < minScore){
            minScore = score;
            minBreak = minBreak + 1;
        }else if(score > maxScore){
            maxScore = score;
            maxBreak = maxBreak + 1;
        }
    });
    return [maxBreak, minBreak];
}