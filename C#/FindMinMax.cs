public static BigInteger findMinFiveSum(List<int> arr){
    BigInteger sum=0;
    for(int i = 0; i < 4; i++){
        sum = sum + arr[i]; 
    }
    return sum;
}

public static BigInteger findMaxFiveSum(List<int> arr){
    BigInteger sumMax=0;
    for(int i = 0; i < 4; i++){
        sumMax = sumMax + arr[arr.Count-i-1]; 
    }
    return sumMax;
}

public static void miniMaxSum(List<int> arr)
{
    arr.Sort();
    BigInteger minFive = findMinFiveSum(arr);
    BigInteger maxFive = findMaxFiveSum(arr);
    Console.Write(minFive + " ");
    Console.Write(maxFive);
}