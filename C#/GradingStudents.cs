public static List<int> gradingStudents(List<int> grades)
{
    List<int> res = new List<int>();
    
    foreach(int grade in grades){
        
        int remain = 5 - (grade % 5);
        int divide = grade/5;
        int rounded = 5 * (divide + 1);
        
        if(grade > 37){
            
            if(remain < 3){
                
                res.Add(rounded);
            }else{
                
                res.Add(grade);
            }
        }else{
            res.Add(grade);
        }
    }
    return res;
}