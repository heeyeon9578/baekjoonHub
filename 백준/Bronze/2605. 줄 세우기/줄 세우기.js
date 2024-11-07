const fs = require("fs");
const inputs = fs.readFileSync("/dev/stdin").toString().trim().split("\n")// /dev/stdin 로 바꿔제출
const pick=Array.from(inputs[1].split(' ')).map(Number);
const n = parseInt(inputs[0]);
const now = new Array(n).fill(0).map((v,i)=> i+1);

for(let i=1; i<n; i++){// 현재 번수가 i 번째 학생 
    let temp=0;
    for(let j=i; j>(i- pick[i]); j--){ //i 번째 학생이 뽑은 수만큼 
        temp = now[j-1];
        now[j-1] = now[j];
        now[j] = temp;
    }
}

console.log(now.join(" ").toString());
