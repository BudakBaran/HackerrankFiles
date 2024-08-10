public static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int count = 0;
    for(int i = 0; i < n-1; i++){
        List<int> pairList = ar.Skip(i+1).Take(n - i + 1).ToList();
        foreach(int item in pairList){
            if((item + ar[i]) % k == 0){
                count = count + 1;
            }
        }
    }
    return count;
}