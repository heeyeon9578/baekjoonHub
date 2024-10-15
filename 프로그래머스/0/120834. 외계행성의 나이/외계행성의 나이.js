function solution(age) {
    var answer = '';
    let alphas = Array.from('abcdefghijklmnopqrspuvwxyz');
    let ages =  Array.from(age.toString());
    for(let i of ages){
        answer += alphas[parseInt(i)]
    }
    return answer;
}