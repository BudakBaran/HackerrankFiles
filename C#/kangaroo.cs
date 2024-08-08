public static string kangaroo(int x1, int v1, int x2, int v2)
{
    int differenceStarting = x1 - x2;
    int differenceEachJump = v1 - v2;
    if (v1 > v2 && (differenceStarting) % (differenceEachJump) == 0){
        return "YES";
    }
    else{
        return "NO";
    }
}