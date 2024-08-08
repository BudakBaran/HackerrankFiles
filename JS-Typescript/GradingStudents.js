function gradingStudents(grades) {
    // Write your code here
    let res = [];
    grades.forEach(function(grade) {
        const divided = Math.floor(grade/5);
        const rounded = 5*(divided+1);

        if(grade > 37){
            const remain = 5-(grade%5);
            if(remain < 3){
                res.push(rounded);
            }else{
                res.push(grade);
            }
        }else{
            res.push(grade);
        }
    });
    return res;
}