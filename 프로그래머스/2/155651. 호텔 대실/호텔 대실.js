function solution(book_time) {
    // 시간을 분으로 변환하는 함수
    function timeToMinutes(time) {
        const [hours, minutes] = time.split(':').map(Number);
        return hours * 60 + minutes;
    }

    // 시작과 종료 시간을 분으로 변환하여 배열에 저장
    const bookings = book_time.map(([start, end]) => [timeToMinutes(start), timeToMinutes(end)]);
    // 시작 시간을 기준으로 정렬
    bookings.sort((a, b) => a[0] - b[0]);
    console.log(bookings)
    // 각 객실의 종료 시간을 저장하는 배열
    const rooms = [];

    bookings.forEach(([start, end]) => {
        // 청소 시간 포함한 종료 시간 계산
        const cleanEndTime = end + 10;

        // 종료 시간이 빠른 객실 순으로 정렬
        rooms.sort((a, b) => a - b);

        // 가장 빠른 종료 시간이 현재 예약 시작 시간보다 작거나 같으면 해당 객실 사용
        if (rooms.length > 0 && rooms[0] <= start) {
            rooms.shift(); // 기존 객실 갱신
        }

        // 새로운 종료 시간을 배열에 추가
        rooms.push(cleanEndTime);
    });

    // 필요한 최소 객실 수는 배열의 길이
    return rooms.length;
}
