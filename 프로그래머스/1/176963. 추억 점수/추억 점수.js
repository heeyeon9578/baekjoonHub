function solution(name, yearning, photo) {
    var answer = [];
    for(let i=0; i<photo.length; i++){
        let tempSum=0;
        for(let j=0; j<photo[i].length; j++){
            let findData = name.indexOf(photo[i][j]);
            if(findData != -1){
                tempSum+= yearning[findData];
                
            }


        }
        answer.push(tempSum);
    }
    return answer;
}