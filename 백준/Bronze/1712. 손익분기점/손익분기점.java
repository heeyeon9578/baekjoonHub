import java.util.Scanner;
//import java.util.StringTokenizer;
 
public class Main {
	
	static Scanner in = new Scanner(System.in);
	public static void main(String[] args) {
		
		int A = in.nextInt();
		int B = in.nextInt();
		int C = in.nextInt();
		
		
		if(C<=B) {
			System.out.println("-1");
		}else {
			System.out.println((A/(C-B))+1);
		}
		
				
	
	}
 
}