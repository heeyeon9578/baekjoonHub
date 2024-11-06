function solution(plans) {
    var answer = [];
    let planStack = []; // 2차원 배열로 이름과 남은시간 저장

    // 시간을 분 단위로 변환
    const newPlans = plans.map(v => {
        const [hour, minute] = v[1].split(':').map(Number);
        return [v[0], hour * 60 + minute, parseInt(v[2])];
    });

    // 시작 시간을 기준으로 정렬
    newPlans.sort((a, b) => a[1] - b[1]);

    for (let i = 0; i < newPlans.length; i++) {
        if (i === newPlans.length - 1) {
            answer.push(newPlans[i][0]);
            break;
        }
        
        const currentTask = newPlans[i];
        const nextTask = newPlans[i + 1];
        const availableTime = nextTask[1] - currentTask[1];

        if (availableTime < currentTask[2]) {
            planStack.push([currentTask[0], currentTask[2] - availableTime]);
        } else {
            answer.push(currentTask[0]);
            let remainingTime = availableTime - currentTask[2];

            while (remainingTime > 0 && planStack.length > 0) {
                const lastPausedTask = planStack.pop();

                if (lastPausedTask[1] <= remainingTime) {
                    answer.push(lastPausedTask[0]);
                    remainingTime -= lastPausedTask[1];
                } else {
                    planStack.push([lastPausedTask[0], lastPausedTask[1] - remainingTime]);
                    break;
                }
            }
        }
    }

    // 남아있는 모든 멈춰둔 작업을 추가
    while (planStack.length > 0) {
        answer.push(planStack.pop()[0]);
    }

    return answer;
}
