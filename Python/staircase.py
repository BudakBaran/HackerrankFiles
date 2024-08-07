def staircase(n):
    # Write your code here
    for i in range(n):
        for si in range(n):
            if si >= n-i-1:
                print("#", end="")
            else: 
                print(" ", end="")
        print("")
