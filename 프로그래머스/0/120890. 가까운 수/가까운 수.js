function solution(array, n) {
    var answer = 0;
    array.push(n);
    array.sort((a,b)=> a-b);
    if(array.indexOf(n) === array.length-1)  return array[array.indexOf(n)-1];
    if(n - array[array.indexOf(n)-1] <= array[array.indexOf(n)+1] -n ){
        return array[array.indexOf(n)-1]
    }else{
         return array[array.indexOf(n)+1]
    }
    return answer;
}