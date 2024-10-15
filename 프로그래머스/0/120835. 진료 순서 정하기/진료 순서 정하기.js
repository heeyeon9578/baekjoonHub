function solution(emergency) {
    var answer = [];
    let newArr = [...emergency];
    newArr.sort((a,b)=>b-a);
    
    return emergency.map(v=> newArr.indexOf(v) +1 );
}