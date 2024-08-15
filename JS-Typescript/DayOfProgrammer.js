function dayOfProgrammer(year) {
    // Write your code here
    let isLeapYear = false;
    let remain = 0;
    
    if(year === 1918){
        return "26"+".09."+year;
    }else if(year >= 1919){
        if( (year % 400 === 0) || (year % 4 === 0 && year % 100 !== 0)){
            isLeapYear = true;
        }
    }else if(year <= 1917){
        if(year % 4 === 0){
            isLeapYear = true;
        }
    }
    
    remain = 256 - (isLeapYear ? 244 : 243);
    
    return remain+".09."+year;
}