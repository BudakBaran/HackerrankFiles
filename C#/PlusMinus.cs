public static void plusMinus(List<int> arr)
{
    float positiveCount = 0;
    float negativeCount = 0;
    float zeroCount = 0;
    float arrLength = arr.Count;
    foreach(float val in arr){
        if(val > 0){
            positiveCount++;
        }else if(val < 0){
            negativeCount++;
        }else{
            zeroCount++;
        }
    }
    Console.WriteLine(positiveCount/arrLength);
    Console.WriteLine(negativeCount/arrLength);
    Console.WriteLine(zeroCount/arrLength);

}