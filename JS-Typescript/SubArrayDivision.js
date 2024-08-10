function birthday(s, d, m) {
    // Write your code here
    let count = 0;
    for(var i = 0; i < s.length; i++){
        if(i + m - 2 < s.length){
            const sumOfBars = s.slice(i, i+m).reduce((a, b) => a + b, 0);
            if(sumOfBars == d){
                count = count + 1;
            }
        }
    }
    return count;
}