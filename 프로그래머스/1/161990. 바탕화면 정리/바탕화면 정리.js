function solution(wallpaper) {
    var answer = [];
    let x = [];
    let y= [];

    for(let i=0; i<wallpaper.length; i++){
        let now = wallpaper[i].split(''); 
        for(let j=0; j<now.length; j++){
            if(now[j]==='#'){
                x.push(i);
                x.push(i+1);
                y.push(j);
                y.push(j+1);
            }
        }
    }

    x.sort((a,b)=> a-b);
    y.sort((a,b)=> a-b);
    //console.log(x,y)
    answer = [
        x[0],y[0], x[x.length-1], y[y.length-1]
    ]
    return answer;
}