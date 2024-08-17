    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int,bool> pairDict = new Dictionary<int,bool>();
        
        foreach(int i in ar){
            
            if(!pairDict.ContainsKey(i)){
                
                pairDict.Add(i, false);           
            }else{
                
                pairDict[i] = !pairDict[i];
            }
        }
        
        int counter = 0;
        foreach(var item in pairDict){
            if(item.Value == false){
                counter = counter + 1;
            }
        }
        
        return (n - counter)/2;
    }