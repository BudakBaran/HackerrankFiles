  public static List<int> compareTriplets(List<int> a, List<int> b)
{
    int alicePoint = 0;
    int bobPoint = 0;
    List<int> resultList = new List<int>();
    for(int i = 0; i < a.Count; i++){
        if(a[i] > b[i]){
            alicePoint+=1;
        }else if(b[i] > a[i]){
            bobPoint+=1;
        }
    }
    resultList.Add(alicePoint);
    resultList.Add(bobPoint);
    return resultList;
}