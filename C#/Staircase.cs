public static void staircase(int n)
{
    for(int i = 0; i < n; i++){
        for(int si = 0; si < n; si++){
            if (si >= n-i-1){
                Console.Write("#");
            }
            else{
                Console.Write(" ");
            } 
        }
        Console.WriteLine("");
    }
}