function solution(X, Y) {
    // 0-9 각 숫자의 발생 횟수를 저장할 배열 초기화
    const countX = Array(10).fill(0);
    const countY = Array(10).fill(0);

    // X에서 각 숫자의 발생 횟수 계산
    for (let digit of X) {
        countX[digit]++;
    }

    // Y에서 각 숫자의 발생 횟수 계산
    for (let digit of Y) {
        countY[digit]++;
    }

    // 결과 문자열을 저장할 배열
    let result = [];

    // 9부터 0까지 공통 숫자를 결과에 추가
    for (let i = 9; i >= 0; i--) {
        const commonCount = Math.min(countX[i], countY[i]);
        for (let j = 0; j < commonCount; j++) {
            result.push(i);
        }
    }

    // 결과가 없는 경우 -1 반환
    if (result.length === 0) {
        return "-1";
    }

    // 결과가 0으로만 구성된 경우 0 반환
    if (result[0] === 0) {
        return "0";
    }

    // 결과 배열을 문자열로 변환하여 반환
    return result.join('');
}