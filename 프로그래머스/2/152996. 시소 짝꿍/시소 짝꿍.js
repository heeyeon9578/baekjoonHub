function solution(weights) {
    let answer = 0;
    const weightMap = new Map();

    // 각 무게의 개수를 맵에 저장
    for (const weight of weights) {
        weightMap.set(weight, (weightMap.get(weight) || 0) + 1);

    }

    // 가능한 무게 비율을 비교
    for (const [weight, count] of weightMap) {
        // 1:1 비율 (같은 무게)
        if (count > 1) {
            answer += (count * (count - 1)) / 2;  // 같은 무게끼리의 조합
        }

        // 1:2 비율
        if (weightMap.has(weight * 2)) {
            answer += count * weightMap.get(weight * 2);
        }

        // 2:3 비율
        if (weightMap.has((weight * 3) / 2)) {
            answer += count * weightMap.get((weight * 3) / 2);
        }

        // 3:4 비율
        if (weightMap.has((weight * 4) / 3)) {
            answer += count * weightMap.get((weight * 4) / 3);
        }
    }

    return answer;
}