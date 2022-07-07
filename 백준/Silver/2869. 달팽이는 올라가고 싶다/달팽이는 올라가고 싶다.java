import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
	public static void main(String[] args) {
		
		BufferedReader bf = new BufferedReader(new InputStreamReader(System.in)); //선언
		String s = null;
		try {
			s = bf.readLine();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} //String
		StringTokenizer st = new StringTokenizer(s); //StringTokenizer인자값에 입력 문자열 넣음
		
		int A = Integer.parseInt(st.nextToken()); //첫번째 호출
		int B = Integer.parseInt(st.nextToken()); //두번째 호출
		int V = Integer.parseInt(st.nextToken()); //세번째 호출
		
		int count = (V-B) / (A-B);
		if((V-B)%(A-B)!= 0) {
			count++;
		}
	
		
		System.out.print(count);
	}
}