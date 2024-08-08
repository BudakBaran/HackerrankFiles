function countApplesAndOranges(s, t, a, b, apples, oranges) {
    // Write your code here
    let appleCount = 0;
    let orangeCount = 0;
    apples.forEach(function(apple) {
        if(apple + a >= s && apple + a <= t){
            appleCount = appleCount+1;
        }
    });
    
    oranges.forEach(function(orange){
        if(orange + b >= s && orange + b <= t){
            orangeCount = orangeCount+1;
        }
    });
    console.log(appleCount);
    console.log(orangeCount);
}