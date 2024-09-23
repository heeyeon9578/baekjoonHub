function solution(progresses, speeds) {
    var answer = [];
    let whatDate=[];

    for(let i=0; i<progresses.length; i++){
        let tempDate = parseInt((100-progresses[i])/speeds[i]);
        if((100-progresses[i])%speeds[i] >0) tempDate++;
        whatDate.push(tempDate);
    }


    let tempAns=1;
    let index=0;
    let bigNum  = whatDate[0];

    for(let i=0; i<whatDate.length; i++){
        if(i === whatDate.length-1){
            answer.push(tempAns);
            break;
        }
        
        if(bigNum< whatDate[i+1]){
            answer.push(tempAns);
            tempAns=1;
            bigNum = whatDate[i+1];
           
        }else{
           tempAns++;
        }
    }
    console.log(whatDate);
    return answer;
}