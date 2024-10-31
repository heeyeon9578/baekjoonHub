function solution(k, d) {
    let count = 0;
    for (let x = 0; x <= d; x += k) {
        // x 값에 대해 가능한 y의 최대값을 계산합니다.
        let maxY = Math.floor(Math.sqrt(d * d - x * x));
        // 가능한 y값의 개수는 0, k, 2k, ..., maxY까지입니다.
        count += Math.floor(maxY / k) + 1;
    }
    return count;
}
