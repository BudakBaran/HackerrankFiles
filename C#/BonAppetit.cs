public static void bonAppetit(List<int> bill, int k, int b)
{
    int sumOfAll = bill.Sum();
    int discarded = sumOfAll - bill[k];
    int annaShouldPay = discarded/2;
    if (b - annaShouldPay == 0){
        Console.WriteLine("Bon Appetit");
    }
    else{
        Console.WriteLine(b - annaShouldPay);
    }
}