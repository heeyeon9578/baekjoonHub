const s = "10 20 30 40"


console.log(solution(s));

function solution(s) {
    var answer = 0;
    let sArray =s.split(' ');
    for(let i=0; i<sArray.length; i++){
        if(sArray[i]==="Z"){
            answer -= parseInt(sArray[i-1]);
        }else{
            answer += parseInt(sArray[i]);
        }
    }
    return answer;
}