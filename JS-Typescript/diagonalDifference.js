function diagonalDifference(arr) {
    // Write your code here
    const xySize = arr.length;
    let rightToLeftSum = 0;
    let leftToRightSum = 0;
    for(let i = 0; i < xySize; i++){
        leftToRightSum = leftToRightSum + arr[i][i];
        rightToLeftSum = rightToLeftSum + arr[xySize - 1 - i][i];
    }
    return Math.abs(rightToLeftSum - leftToRightSum);
}