function solution(n) {
    var answer = 0;
    
    let fac = 1;
    for(let i=1; i<12; i++){
        
        fac *= i;
        if((fac)>n){
          return  answer = i-1;
            
        }
    }
    return answer;
}