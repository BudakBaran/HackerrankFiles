public static string dayOfProgrammer(int year)
{
    bool isLeapYear = false;
    int remain = 0;

    if(year >= 1919){
        
        if( (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
            isLeapYear = true;
        }
    }else if(year <= 1917){
        
        if(year % 4 == 0){
            isLeapYear = true; 
        }
    }else{
        return "26.09."+year.ToString();
    }
    remain = 256 - (isLeapYear ? 244 : 243);
    
    return remain.ToString()+".09."+year.ToString();
}