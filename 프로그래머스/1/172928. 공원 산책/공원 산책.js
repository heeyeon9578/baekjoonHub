function solution(park, routes) {
    // 공원의 세로 길이(H)와 가로 길이(W)
    let H = park.length;
    let W = park[0].length;
    
    // 시작점 S의 위치 찾기
    let startRow = 0, startCol = 0;
    for (let i = 0; i < H; i++) {
        for (let j = 0; j < W; j++) {
            if (park[i][j] === 'S') {
                startRow = i;
                startCol = j;
                break;
            }
        }
    }
    
    // 현재 위치 초기화
    let curRow = startRow;
    let curCol = startCol;
    
    // 방향별 이동 벡터 설정: N(북), S(남), W(서), E(동)
    const directions = {
        'N': [-1, 0],
        'S': [1, 0],
        'W': [0, -1],
        'E': [0, 1]
    };
    
    // routes 배열의 각 명령어 처리
    for (let command of routes) {
        // 명령어 파싱: "E 2" -> 방향과 거리 추출
        let [dir, stepStr] = command.split(" ");
        let steps = parseInt(stepStr);
        let [dr, dc] = directions[dir];
        
        // 명령어 실행 전, 이동 가능 여부 확인
        let newRow = curRow;
        let newCol = curCol;
        let isValid = true;
        for (let i = 0; i < steps; i++) {
            newRow += dr;
            newCol += dc;
            // 공원 범위를 벗어나는지 체크
            if (newRow < 0 || newRow >= H || newCol < 0 || newCol >= W) {
                isValid = false;
                break;
            }
            // 장애물(X)을 만나는지 체크
            if (park[newRow][newCol] === 'X') {
                isValid = false;
                break;
            }
        }
        // 유효한 이동이면 현재 위치 업데이트
        if (isValid) {
            curRow = newRow;
            curCol = newCol;
        }
    }
    
    return [curRow, curCol];
}