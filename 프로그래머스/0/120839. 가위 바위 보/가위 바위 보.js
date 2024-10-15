function solution(rsp) {
    var answer = '';
    let rspMap = new Map();
    rspMap.set("2", "0");
    rspMap.set("0", "5");
    rspMap.set("5", "2");
    
    for(let i of Array.from(rsp)){
        if(rspMap.has(i)){
            answer+= rspMap.get(i);
        }
    }
    return answer;
}