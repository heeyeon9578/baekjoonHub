function solution(today, terms, privacies) {
    var answer = [];
    const splitToday = today.split('.');
    const todayYear = splitToday[0];
    const todayMonth = splitToday[1];
    const todayDate = splitToday[2];

    const termsMap = new Map();
    for(let i=0; i<terms.length; i++){
        const splitTerms = terms[i].split(' ');
        termsMap.set(splitTerms[0], splitTerms[1]);

    }

    for(let i=0; i<privacies.length; i++){
        const splitPrivacy = privacies[i].split(' ');
        const splitPrivacyDate = splitPrivacy[0].split('.');
        const privacyYear = splitPrivacyDate[0];
        const privacyMonth = splitPrivacyDate[1];
        const privacyDate = splitPrivacyDate[2];
        const privacyTerm = splitPrivacy[1];

        let minusYear = todayYear-privacyYear;
        let minusMonth = todayMonth -privacyMonth;

        let minusDate = todayDate - privacyDate;

        let privacyMonths = 0;

        if(minusDate<0) {
            minusMonth -= 1;
            minusDate += 28; 
        }

        if(minusMonth <0){
            minusYear -= 1;
            minusMonth+=12;
        }

        if(minusYear ===0) 
        {
            if(minusMonth>0)  privacyMonths = minusMonth;
            else privacyMonths = 0;
        }else{
            privacyMonths = minusYear*12+minusMonth;
        }
        console.log(`privacyMonths`,privacyMonths);

        console.log('termsMap.get(privacyTerm)',termsMap.get(privacyTerm));

        if(termsMap.get(privacyTerm) <=privacyMonths) {
            answer.push(i+1);
        }
    }





    return answer;
}