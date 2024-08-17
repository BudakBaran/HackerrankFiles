public static int pageCount(int n, int p)
{
    return Math.Min(p/2, n/2-p/2);
}