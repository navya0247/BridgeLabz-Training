import java.util.*;

 public class primeNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);  // Create Scanner object
        int n = sc.nextInt();   // Read input number
        int count = 0;          // Variable to count factors
        // Numbers less than or equal to 1 are not prime
        if (n <= 1) {
            System.out.println("Not a prime number");
        } else {
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    count++;    
                }
            }
            if (count == 2) {
                System.out.println("Prime number");
            } else {
                System.out.println("Not a prime number");
            }
        }

    }
}
