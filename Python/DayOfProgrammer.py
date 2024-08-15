def dayOfProgrammer(year):
    # Write your code here
    isLeapYear = False
    remain = 0
    if year == 1918:
        return "26.09." + str(year)
    elif year >= 1919:
        if (year % 400 == 0) or (year % 4 == 0 and year % 100 != 0):
            isLeapYear = True
    elif year <= 1917:
        if year % 4 == 0:
            isLeapYear = True

    remain = 256 - (244 if isLeapYear else 243)
    return str(remain)+".09."+str(year)