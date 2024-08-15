function solution(skill, skill_trees) {
    let count = 0;
    
    skill_trees.forEach(skill_tree => {
        // 1. 스킬트리에서 skill에 해당하는 스킬들만 추출합니다.
        const filteredSkillTree = skill_tree.split('').filter(s => skill.includes(s));
        
        // 2. 추출된 스킬들이 skill의 순서대로 있는지 확인합니다.
        const isValid = filteredSkillTree.every((s, i) => s === skill[i]);
        
        // 3. 유효한 스킬트리라면 count를 증가시킵니다.
        if (isValid) {
            count++;
        }
    });
    
    return count;
}
