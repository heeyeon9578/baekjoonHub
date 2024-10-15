function solution(spell, dic) {
    var answer = 0;
    let sortedSpell = spell.sort().join('');
    for(let i =0; i< dic.length; i++){
      if(sortedSpell===Array.from(dic[i]) .sort().join('')){
          return 1;
      };
    }
    return 2;
}