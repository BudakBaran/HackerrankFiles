function bonAppetit(bill, k, b) {
    // Write your code here
    const sumOfAll = bill.reduce((a,b) => a + b, 0);
    const discarded = sumOfAll - bill[k];
    const annaShouldPay = discarded/2;
    if (b - annaShouldPay == 0){
        console.log("Bon Appetit")
    }
    else{
        console.log(b - annaShouldPay)
    }
}