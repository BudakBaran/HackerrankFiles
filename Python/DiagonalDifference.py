def diagonalDifference(arr):
    # Write your code here
    rightToLeftSum = 0
    leftToRightSum = 0
    size = len(arr)
    for i in range(size):
        leftToRightSum = leftToRightSum + arr[i][i]
        rightToLeftSum = rightToLeftSum + arr[size - 1 - i][i]
    return abs(leftToRightSum - rightToLeftSum)