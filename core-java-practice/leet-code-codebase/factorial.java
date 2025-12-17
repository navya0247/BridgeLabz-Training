import java.util.*;

public class factorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);   // Create Scanner object
        int n = sc.nextInt();                   // Read input number
        int fact = 1;                           // Variable to store factorial
        // Loop to calculate factorial
        for (int i = 1; i <= n; i++) {
            fact = fact * i;
        }

        System.out.println("Factorial = " + fact);

    
    }
}
