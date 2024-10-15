function solution(s) {
    var answer = '';
    
    ;
    return [...s].filter(c=> s.split(c).length ===2).sort().join('');
}