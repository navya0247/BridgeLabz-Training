import java.util.*;

 public class reverseString {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);   // Create Scanner object
        String str = sc.nextLine();             // Read input string
        String rev = "";                        // Variable to store reversed string
        // Loop from last character to first
        for (int i = str.length() - 1; i >= 0; i--) {
            rev = rev + str.charAt(i);          // Add characters in reverse order
        }
        System.out.println("Reversed string: " + rev);

    
    }
}
