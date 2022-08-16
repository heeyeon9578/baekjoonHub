using System;

public class Solution {
    public int solution(int[,] sizes) {
        int width=0;
        int height=0;
        for(int i=0; i<sizes.GetLength(0); i++){
            (int t1, int t2) temp = (sizes[i,0], sizes[i,1]);
            
            if(temp.t2 > temp. t1){
                int t3 = temp.t1;
                temp.t1 = temp.t2;
                temp.t2 = t3;
            }
            if(width <temp.t1)
                width = temp.t1;
            if(height<temp.t2)
                height = temp.t2;
        }
        
        return width*height;
    }
}