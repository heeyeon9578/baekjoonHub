function solution(before, after) {
    var answer = 0;
    return Array.from(before).sort().join('')=== Array.from(after).sort().join('')? 1:0;
}