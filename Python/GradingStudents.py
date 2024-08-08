def gradingStudents(grades):
    # Write your code here
    res = []
    for grade in grades:
        if grade > 37:
            remain = 5 - (grade % 5)
            divide = math.floor(grade/5)
            rounded = 5 * (divide + 1)
            if remain < 3:
                res.append(rounded)
            else:
                res.append(grade)
        else:
            res.append(grade)
    return res