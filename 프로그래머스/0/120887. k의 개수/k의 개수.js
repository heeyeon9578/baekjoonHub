function solution(i, j, k) {
    var answer = 0;
    let str = '';
    for(let k=i; k<j+1; k++){
        str += k.toString();
    }
    return Array.from(str).filter(v=> v=== k.toString()).length;
}