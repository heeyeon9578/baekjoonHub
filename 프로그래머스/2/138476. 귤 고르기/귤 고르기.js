function solution(k, tangerine) {
    let tanMap = new Map();
    // let sortMapValue = []; //큰 -> 작
    let answer=0;
    for(let i=0; i<tangerine.length; i++){
        if(tanMap.has(tangerine[i])){
            tanMap.set(tangerine[i], tanMap.get(tangerine[i])+1);
        }else{
            tanMap.set(tangerine[i], 1);
        }
       
    }

    // tanMap.forEach(element => {
    //     if(sortMapValue.length===0){
    //         sortMapValue.push(element)
    //     }else if( sortMapValue[sortMapValue.length-1] <=element){
    //         let tempLast = sortMapValue[sortMapValue.length-1];
    //         sortMapValue[sortMapValue.length-1]  = element;
    //         sortMapValue.push(tempLast);
    //     }
    //     else if( sortMapValue[sortMapValue.length-1] >element){
            
            
    //         sortMapValue.push(element);
    //     }
    // });
    // 개수를 내림차순으로 정렬
    let sortMapValue = Array.from(tanMap.values()).sort((a, b) => b - a);
    let tempK = k;
    for(let i=0; i<sortMapValue.length; i++){

        tempK = tempK-sortMapValue[i];
        answer++;
        if(tempK <=0) break;
    }

    return answer;
}