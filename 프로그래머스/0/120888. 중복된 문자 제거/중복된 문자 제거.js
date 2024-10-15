function solution(my_string) {
    var answer = '';
    let tempSet = new Set(Array.from(my_string));
    tempSet.forEach(v=> answer += v);
    
    return answer
}