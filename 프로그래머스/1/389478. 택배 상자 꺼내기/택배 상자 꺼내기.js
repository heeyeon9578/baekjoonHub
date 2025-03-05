function solution(n, w, num) {
    var answer = 0;
    let arrays=[];
    let now = true;
    let cur = 0;
    //w개의 배열만들기
    for(let i=0; i<w; i++){
        arrays.push([]);
    }

    while(cur <= n){

        for(let i=0; i<w; i++){
            cur++;
            if(cur>=n+1) break; 
            arrays[i].push(cur);
           
            
        }

        for(let i=w-1; i>=0; i--){
            cur++;
            if(cur>=n+1) break;
            arrays[i].push(cur);
            
            
        }
        
    }

    for(let i=0; i<w; i++){
        for(let j=0; j<arrays[i].length; j++){
            if(arrays[i][j]=== num){

                answer= arrays[i].length - j;
                break;
            }
            // console.log(arrays[i][j])
        }
        // console.log(`------------`)
    }
    return answer;
}
