import java.io.IOException;
import java.util.*;

 
public class Main {
	
	public static void main(String args[]) throws NumberFormatException, IOException{
		
		int num=1, count=0, numResult;
		
		HashSet<Integer> set1 = new HashSet<Integer>();
		
		
		for(int i=1; i<10001; i++) {
			set1.add(i);

			
		}

		for(int i=1; i<10001; i++) {

			set1.remove(d(i));
			
		}
		
		for(int numA: set1)
		{
			System.out.println(numA);
		}
	

		

	}
	
	//자신과 자신을 이루는 각 자리수를 더해주는 함수(셀프넘버의 반대개념)
	public static int d(int n){
		
		String s= Integer.toString(n);
		int resN,sum=n;
		
		for(int i=0; i<s.length();i++) {
			resN = n%10;
			sum += resN;
			n=n/10;
		}
		
		return sum;
	
	}
}					
