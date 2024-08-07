function staircase(n) {
    // Write your code here
    for(let i = 0; i < n; i++){
        for(let si=0; si < n; si++){
            if(si >= n-i-1){
                process.stdout.write("#");
            }else{
                process.stdout.write(" ");
            }
        }
        process.stdout.write("\n");
    }
}