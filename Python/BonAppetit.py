def bonAppetit(bill, k, b):
    # Write your code here
    sumOfAll = sum(bill)
    discarded = sumOfAll - bill[k]
    annaShouldPay = discarded/2
    if (b - annaShouldPay == 0):
        print("Bon Appetit")
    else:
        print(int(b - annaShouldPay))