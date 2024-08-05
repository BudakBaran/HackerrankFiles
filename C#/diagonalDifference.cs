public static int diagonalDifference(List<List<int>> arr)
{
    int xySize = arr.Count;
    int rightToLeftSum = 0;
    int leftToRightSum = 0;
    for(int i = 0; i < xySize; i++){
        leftToRightSum += arr[i][i];
        rightToLeftSum += arr[xySize - 1 - i][i];
    }
    return Math.Abs(rightToLeftSum - leftToRightSum);
}