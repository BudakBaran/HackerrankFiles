function kangaroo(x1, v1, x2, v2) {
    // Write your code here
    const differenceStarting = x1 - x2;
    const differenceEachJump = v1 - v2;
    if (v1 > v2 && (differenceStarting) % (differenceEachJump) == 0){
        return "YES"
    }
    else{
        return "NO"
    }
}