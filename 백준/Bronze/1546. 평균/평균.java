import java.io.IOException;
import java.util.*;

 
public class Main {
	
	public static void main(String args[]) throws NumberFormatException, IOException{
		
		Scanner scan = new Scanner(System.in);
		int N=scan.nextInt();

		Double testResult[] = new Double[N];
		int count=0;
		Double M=0.0;
		
		Double avg,sum=0.0;
		
		for(int i=0; i<N; i++) {
	
			testResult[i]= scan.nextDouble();					
		
		}
		scan.close();
		
		for(Double value:testResult) {
			count++;
			
			if(value>M) {
				M = value;
			}
			
		}
		for(int i=0; i<N; i++) {
			
			testResult[i] =	testResult[i]/M*100;		
			sum = sum+testResult[i];
			
		}
		
		avg = sum/(count);
		System.out.println(avg);
	
		
	}
		
}					
