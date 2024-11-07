const fs = require("fs");
const heights = fs.readFileSync("/dev/stdin").toString().trim().split("\n").map(Number);
const n = heights.length;
const total = heights.reduce((a, b) => a + b, 0);
let answer = [];

// i와 j가 다른 난쟁이를 가리키도록 i와 j의 범위를 설정
for (let i = 0; i < n; i++) {
    for (let j = i + 1; j < n; j++) {  // j는 항상 i보다 큰 값을 가리키도록 설정
        if (total - heights[i] - heights[j] === 100) {
            answer = heights.filter((_, index) => index !== i && index !== j);
            break;
        }
    }
    if (answer.length) break;  // 정답을 찾았으면 반복문 탈출
}

// 오름차순으로 정렬하여 출력
console.log(answer.sort((a, b) => a - b).join('\n'));
