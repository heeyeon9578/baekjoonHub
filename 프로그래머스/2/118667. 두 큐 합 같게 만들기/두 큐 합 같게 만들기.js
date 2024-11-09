function solution(queue1, queue2) {

    const total = [...queue1, ...queue2].reduce((a,b)=>a+b, 0);
    if(total % 2 !==0) return -1;
    const half = total / 2;
    const combined = [...queue1, ...queue2];
    let currentSum = queue1.reduce((a, b) => a + b, 0);

    let p1 = 0;
    let p2 = queue1.length;

    const maxOperations = queue1.length * 3;
    let operations = 0;

    while (operations <= maxOperations) {
        if (currentSum === half) {
            return operations;
        } else if (currentSum < half) {
            // currentSum을 늘려야 하므로 p2 위치의 값을 더함
            currentSum += combined[p2 % combined.length];
            p2++;
        } else {
            // currentSum이 너무 크므로 p1 위치의 값을 뺌
            currentSum -= combined[p1 % combined.length];
            p1++;
        }
        operations++;
    }

    return -1; // 목표에 도달할 수 없는 경우
  
}
