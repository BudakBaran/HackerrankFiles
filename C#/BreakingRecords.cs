public static List<int> breakingRecords(List<int> scores)
{
    int minBreak = 0;
    int maxBreak = 0;
    
    int minScore = scores[0];
    int maxScore = scores[0];
    
    List<int> res = new List<int>();
    
    foreach(int score in scores){
        
        if(score < minScore){
            minBreak = minBreak + 1;
            minScore = score;
        }else if(score > maxScore){
            maxBreak = maxBreak + 1;
            maxScore = score;
        }
    }
    res.Add(maxBreak);
    res.Add(minBreak);
    
    return res;
}