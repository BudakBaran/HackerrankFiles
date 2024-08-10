    public enum DividerMode 
    {
        Arr,
        Num
    }
    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static bool checkIsNumFactorOfArr(int num, List<int> arr, DividerMode mode){
        bool isFactorial = true;
        int dividend = 0;
        int divider = 0;
        if(mode == DividerMode.Arr){
            // ARR Divides
            dividend = num;
        }
       
        
        foreach(int element in arr){
            if(mode == DividerMode.Arr){
                divider = element;
            }else{
                divider = num;
                dividend = element;
            }
            
            if(dividend % divider != 0){
                isFactorial = false;
                break;
            }
        }
        return isFactorial;
    }
    public static int getTotalX(List<int> a, List<int> b)
    {
        int minValueOfSecondArr = b.Min(x=> x);
        int maxValueOfFirstArr = a.Max(x=> x);
        int len = 0;
        for(int factor = maxValueOfFirstArr; factor <= minValueOfSecondArr; factor++){
            if(checkIsNumFactorOfArr(factor, a, DividerMode.Arr) && checkIsNumFactorOfArr(factor, b, DividerMode.Num)){
                len = len + 1;
            }
        }
        return len;
    }