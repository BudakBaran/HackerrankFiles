public static string timeConversion(string s)
{
    string timeLineS = s.Substring(s.Length - 2);

    string time = s.Remove(s.Length-2, 2);
    time = time.Remove(0, 2);
    string timeHour = s.Substring(0, 2);
    int intTimeHour = Int32.Parse(timeHour);

    if(timeLineS == "AM"){
        if(intTimeHour >= 12){
            intTimeHour = intTimeHour-12;
        }
    }else{
        if(intTimeHour < 12){
            intTimeHour = intTimeHour+12;
        }
    }
    string newHour = intTimeHour.ToString("D2");
    time = newHour+time;
    return time;
}