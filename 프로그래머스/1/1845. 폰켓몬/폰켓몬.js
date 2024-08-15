function solution(nums) {
    var answer = 0;
    let set = new Set(nums);
    let setSize =  set.size;
    let numsLength  = nums.length / 2;
    if(setSize > numsLength){
        answer = numsLength;
    }else{
        answer = setSize;
    }
    return answer;
}