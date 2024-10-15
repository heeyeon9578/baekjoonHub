function solution(numbers, direction) {
    var answer = [];
    if(direction === "right"){  
        numbers.unshift(numbers[numbers.length-1]);
         numbers.pop(numbers[numbers.length-1]);
    }else{
        numbers.push(numbers[0]);
        numbers.shift(numbers[0]) ;
    }
    return numbers;
}