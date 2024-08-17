
function countingValleys(steps, path) {

    let currHeight = 0;
    let isUnderCheck = false;
    let countValley = 0;
    
    for(let i = 0; i < steps; i++){
        if(path[i] === 'U'){
            
            currHeight = currHeight + 1;
        }else if(path[i] === 'D'){
            
            currHeight = currHeight - 1;
        }
        
        if (currHeight < 0){
            isUnderCheck = true;
        }else{
            if(isUnderCheck){
                countValley = countValley + 1;
            }
            isUnderCheck = false;
        }
    }
    return countValley;
}
