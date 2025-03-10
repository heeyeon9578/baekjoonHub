function solution(players, callings) {
    let rankMap = {}; // 선수 이름 -> 현재 등수를 저장하는 맵

    // 초기 선수 등수 설정
    players.forEach((player, index) => {
        rankMap[player] = index;
    });

    for (const called of callings) {
        let curIdx = rankMap[called];  // 불린 선수의 현재 등수
        if (curIdx > 0) { // 이미 1등이면 변경 X
            let prevPlayer = players[curIdx - 1]; // 앞에 있는 선수
            // 선수 위치 변경
            players[curIdx - 1] = called;
            players[curIdx] = prevPlayer;
            
            // 등수 맵 업데이트
            rankMap[called] = curIdx - 1;
            rankMap[prevPlayer] = curIdx;
        }
    }

    return players;
}