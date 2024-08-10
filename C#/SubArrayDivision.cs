public static int birthday(List<int> s, int d, int m)
{
    int count = 0;
    for(int i = 0; i < s.Count; i++){
        if(i + m - 2 < s.Count){
            List<int> filteredBar = s.Skip(i).Take(i+m - i).ToList();
            if(filteredBar.Sum(x=> x) == d){
                count  = count + 1;
            }
        }
    }
    return count;
}