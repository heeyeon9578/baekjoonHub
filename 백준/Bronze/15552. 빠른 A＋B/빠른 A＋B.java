//import java.util.Scanner;
import java.io.*;
import java.util.StringTokenizer;

public class Main {
 
	public static void main(String[] args) {
		try {
			
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
			int T = Integer.parseInt(br.readLine());
			int sum=0;
			
			
//			int T = in.nextInt();
		
			
			StringTokenizer st;
			
			for(int i=0; i<T; i++) {
				st = new StringTokenizer(br.readLine());
				int A = Integer.parseInt(st.nextToken());
	            int B = Integer.parseInt(st.nextToken());
	            sum = A+B;
				bw.write(sum+ "\n");		
				
			}
			
			br.close();
			
			
			bw.flush();
			bw.close();
			
		}catch(IOException e) {
			e.printStackTrace();
			
		}
//		Scanner in = new Scanner(System.in);
		
		
		
		
	}
}
