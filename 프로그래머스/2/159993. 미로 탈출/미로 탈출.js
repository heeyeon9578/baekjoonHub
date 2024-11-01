function solution(maps) {
    const n = maps.length;
    const m = maps[0].length;
    const dx = [-1, 0, 1, 0];
    const dy = [0, 1, 0, -1];

    // BFS를 사용하여 시작 위치에서 목표 위치까지의 최단 거리를 찾는 함수
    function bfs(startX, startY, target) {
        const queue = [[startX, startY, 0]]; // x, y, 이동 거리
        const visited = Array.from(Array(n), () => Array(m).fill(false));
        visited[startX][startY] = true;

        while (queue.length > 0) {
            const [x, y, distance] = queue.shift();

            if (maps[x][y] === target) {
  
                return distance;
            }

            for (let i = 0; i < 4; i++) {
                const nx = x + dx[i];
                const ny = y + dy[i];

                if (nx >= 0 && ny >= 0 && nx < n && ny < m && !visited[nx][ny] && maps[nx][ny] !== 'X') {
                    visited[nx][ny] = true;
                    queue.push([nx, ny, distance + 1]);
                }
            }
        }

        return -1;
    }

    let startX, startY, leverX, leverY;
    for (let i = 0; i < n; i++) {
        for (let j = 0; j < m; j++) {
            if (maps[i][j] === 'S') [startX, startY] = [i, j];
            else if (maps[i][j] === 'L') [leverX, leverY] = [i, j];
        }
    }

    // 출발점에서 레버로 가는 거리 계산
    const toLever = bfs(startX, startY, 'L');
    if (toLever === -1) return -1; // 레버에 도달하지 못하는 경우

    // 레버에서 출구로 가는 거리 계산
    const toExit = bfs(leverX, leverY, 'E');
    if (toExit === -1) return -1; // 출구에 도달하지 못하는 경우

    return toLever + toExit;
}