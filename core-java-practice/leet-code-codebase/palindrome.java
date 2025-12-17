import java.util.*;

 public class palindrome {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);    // Create Scanner object
        String str = sc.nextLine();              // Read input string
        String rev = "";                         // Store reversed string
        // Reverse the string
        for (int i = str.length() - 1; i >= 0; i--) {
            rev = rev + str.charAt(i);
        }

        // Check condition
        if (str.equals(rev)) {
            System.out.println("Palindrome string");
        } else {
            System.out.println("Not a palindrome string");
        }

    }
}
