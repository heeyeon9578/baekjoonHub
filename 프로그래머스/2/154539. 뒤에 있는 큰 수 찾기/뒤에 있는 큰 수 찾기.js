function solution(numbers) {
    var answer = [];
    var stack = [];
    
    for (let i = numbers.length - 1; i >= 0; i--) {
        while (stack.length > 0 && stack[stack.length - 1] <= numbers[i]) {
            stack.pop();
        }
        if (stack.length === 0) {
            answer[i] = -1;
        } else {
            answer[i] = stack[stack.length - 1];
        }
        stack.push(numbers[i]);
    }
    
    return answer;
}

const a = [2, 3, 3, 5];
const b = [9, 1, 5, 3, 6, 2];
console.log(solution(b)); // Output: [ -1, 5, 6, 6, -1, -1 ]
