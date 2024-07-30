function solution(s) {
    
    let sum = 0; //첫글자와 같은 문자들
    let notSum=0; //첫글자와 다른 문자들
    let index = 0; //첫글자 인덱스
    let answer = 0; //정답 

    while (index < s.length){
        
        let x = s[index]; //첫글자

        for(let i=index; i<s.length; i++){
            if(i === s.length-1) {
                answer++;
                return answer;
            }
            if(s[i] === x){
                sum++;
            }else{
                notSum ++;
            }

            if(sum === notSum){
                answer++;
                sum =0;
                notSum=0;
                index = i+1;
                break;
            }
        }
        
        
    }
    
    return answer;
}
