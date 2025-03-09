function solution(bandage, health, attacks) {
    var answer = 0;
    let attacksLen = attacks[attacks.length-1][0];
    let nowH =health;
    let howLong = 0;
    let nowIndex = 0;
    for(let i=0; i<=attacksLen; i++){ //0초부터 attacks의 마지막 초까지

        if(attacks[nowIndex][0] === i){
            nowH -= attacks[nowIndex][1];
            howLong=0;
            if(nowH <0) return -1;
            nowIndex++;
        }else{

            if(nowH <= health){
                nowH += bandage[1];
                if(nowH > health) nowH = health;
                howLong += 1;
                if(howLong >= bandage[0]){
                    nowH += bandage[2];
                    if(nowH > health) nowH = health;
                    howLong=0;
                }
            } 
        }
    }

    if(nowH>0){
        answer = nowH;
    }else{
        answer = -1;
    }
    return answer;
}
