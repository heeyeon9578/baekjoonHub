function solution(triangle) {
    // 아래에서 위로 거꾸로 올라가며 최댓값 계산
    for (let i = triangle.length - 2; i >= 0; i--) {
        for (let j = 0; j < triangle[i].length; j++) {
            // 아래층의 두 선택지 중 큰 값을 더함
            triangle[i][j] += Math.max(triangle[i + 1][j], triangle[i + 1][j + 1]);
        }
    }

    // 삼각형의 꼭대기 값이 최종 최대 경로의 합
    return triangle[0][0];
}