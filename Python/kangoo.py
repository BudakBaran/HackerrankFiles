def kangaroo(x1, v1, x2, v2):
    # Write your code here
    differenceStarting = x1 - x2;
    differenceEachJump = v1 - v2;
    if v1 > v2 and (differenceStarting) % (differenceEachJump) == 0:
        return "YES"
    else:
        return "NO"