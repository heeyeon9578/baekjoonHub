function solution(n, t, m, p) {
    var answer = '';

    let totalLength = 0;
    let tempNum = 0;
    let allNums = [];

    while (totalLength <t*m){
        let result = makeGinSu(n , tempNum);
        allNums = allNums.concat(result);
        totalLength += result.length;
        tempNum ++;
    }
   
    

    let index = p-1;
    let tempAnswer = [];
    while(tempAnswer.length < t){
        tempAnswer.push(allNums[index]);
        index = index+ m;
    }
    
    //n진수로 만드는 함수
    function makeGinSu(n, value){
        let returnValue =[];
        while(value !==1){
            const nextValue = parseInt(value / n) ;
            if(nextValue ===0) {
                switch(value){
                    case 10: value= 'A'; break;
                    case 11: value ='B'; break;
                    case 12: value='C'; break;
                    case 13: value='D'; break;
                    case 14: value='E'; break;
                    case 15: value='F'; break;
                    default: value= value; break;
                }
                returnValue.push(value) ;
                
                returnValue.reverse();
              
                return returnValue;
            }

            let tempValue = value % n;
            switch(tempValue){
                case 10: tempValue= 'A'; break;
                case 11: tempValue ='B'; break;
                case 12: tempValue='C'; break;
                case 13: tempValue='D'; break;
                case 14: tempValue='E'; break;
                case 15: tempValue='F'; break;
                default: tempValue= tempValue; break;
            }
            returnValue.push(tempValue);
            value = nextValue;
        }
        returnValue.push(1);
        returnValue.reverse();
       
        return returnValue;
    }

    for(let i=0; i<tempAnswer.length; i++){
        answer += tempAnswer[i].toString();
    }


    return answer;
}