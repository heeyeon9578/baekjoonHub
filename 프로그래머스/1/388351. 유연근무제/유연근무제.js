function solution(schedules, timelogs, startday) {
    let answer = 0;
    
    for (let i = 0; i < schedules.length; i++) {
        let today = startday; // 직원별로 요일 초기화
        let isOnTime = true; // 지각 여부 체크
        
        for (let j = 0; j < 7; j++) {
            if (today !== 6 && today !== 7) { // 토, 일 제외
                let expectedTime = schedules[i]; // 희망 출근 시간
                let allowedTime = expectedTime + 10; // 희망 시간 + 10분까지 인정
                
                let actualTime = timelogs[i][j]; // 실제 출근한 시간
                
                // 시간과 분을 분리해서 계산 (분 단위 변환)
                let expectedMinutes = Math.floor(expectedTime / 100) * 60 + (expectedTime % 100);
                let allowedMinutes = Math.floor(allowedTime / 100) * 60 + (allowedTime % 100);
                let actualMinutes = Math.floor(actualTime / 100) * 60 + (actualTime % 100);

                // 지각 여부 판단
                if (actualMinutes > allowedMinutes) {
                    isOnTime = false;
                    break; // 한 번이라도 지각하면 중단
                }
            }
            
            today++; // 요일 증가
            if (today > 7) today = 1; // 일요일(7) 이후 월요일(1)로 초기화
        }

        if (isOnTime) {
            answer++;
        }
    }
    
    return answer;
}
