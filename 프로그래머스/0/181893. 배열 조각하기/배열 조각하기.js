function solution(arr, query) {
    var answer = [];
    answer = [...arr];
    for(let i=0; i<query.length; i++){
        if(i%2 ===0) answer = answer.slice(0,query[i]+1);
        else  answer = answer.slice(query[i], answer.length );
    }
    return answer;
}