function solution(A, B) {
    var answer = 0;
    let Aarr = [...A];
    if (A===B ) return 0;
    for(let i=1; i<A.length; i++){
        Aarr.unshift(Aarr.pop());
        if(Aarr.join('')===B) return i;
    }
    
    return -1;
}