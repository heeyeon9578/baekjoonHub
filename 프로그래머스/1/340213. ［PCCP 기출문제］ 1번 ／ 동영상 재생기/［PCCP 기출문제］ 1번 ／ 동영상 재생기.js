function solution(video_len, pos, op_start, op_end, commands) {
    var answer = '';

    let videoLen = parseInt(video_len.split(":")[0])*60 + parseInt(video_len.split(":")[1]);
    let posLen = parseInt(pos.split(":")[0] )*60+ parseInt(pos.split(":")[1]);
    let opStart = parseInt(op_start.split(":")[0])*60 + parseInt(op_start.split(":")[1]);
    let opEnd = parseInt(op_end.split(":")[0])*60+parseInt(op_end.split(":")[1]);


    if(opStart<=posLen && posLen<=opEnd ){
        posLen = opEnd;
    }

    for(let i=0; i<commands.length; i++){
        if(commands[i]==="next"){
            if(posLen+10>=videoLen){ //현재 시간 + 10초가 비디오 길이보다 길거나 같으면
                posLen = videoLen;
            }else{
                posLen = posLen+10;
            }

            
        }else{ //prev
            if(posLen-10 <= 0){//현재 시간 - 10초가 0초보다 작거나 같으면
                posLen=0;
            }else{
                posLen =posLen-10;
            }
        }
        if(opStart<=posLen && posLen<=opEnd ){
            posLen = opEnd;
        }
    }

    let ansM = Math.floor(posLen/60);
    let ansS  = Math.floor(posLen % 60);

    if(ansM <10){
        ansM = '0'+ ansM.toString() +':';
    }else{
        ansM = ansM.toString()+':';
    }
    if(ansS <10){
        ansS = '0'+ ansS.toString();
    }else{
        ansS = ansS.toString();
    }

    
    return ansM + ansS;
}