function solution(targets) {
    var answer = 0;
    targets.sort((a,b)=>{
        if(a[1]===b[1]){
            return a[0]-b[0]
        }else{
            return a[1]-b[1]
        }
    })

    let temp=-1;
    for(let x of targets){
        if(x[0]>=temp){
            answer++;
            temp = x[1];
        }
    }
    console.log(targets);
    return answer;
}