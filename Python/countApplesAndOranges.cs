public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{

        int insideApple = 0;
        int insideOrange = 0;
        foreach(int apple in apples){
            if(apple + a >= s && apple + a <=t){
                insideApple = insideApple+1;
            }
        }
        
        foreach(int orange in oranges){
            if(orange + b >= s && orange + b <=t){
                insideOrange = insideOrange+1;
            }
        }
        
        Console.WriteLine(insideApple);
        Console.WriteLine(insideOrange);
}