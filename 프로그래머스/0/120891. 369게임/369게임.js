function solution(order) {
    var answer = 0;
    let orderArr = Array.from(order.toString());
    return orderArr.filter(v=> v==='3' || v==='6' || v==='9').length;
}