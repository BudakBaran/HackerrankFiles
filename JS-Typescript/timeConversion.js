function timeConversion(s) {
    // Write your code here
    let firstTwoString = s.slice(0,2);
    let firstTwoInteger = parseInt(firstTwoString);
    let lastTwoString = s.slice(-2);
    let withoutExtras = s.slice(2);
    withoutExtras = withoutExtras.slice(0,-2);
    if(lastTwoString == "AM"){
        if(firstTwoInteger >= 12){
            firstTwoInteger = firstTwoInteger-12;
        }
    }else{
        if(firstTwoInteger < 12){
            firstTwoInteger = firstTwoInteger+12;
        }
    }
    return String(firstTwoInteger).padStart(2, '0')+withoutExtras;
}