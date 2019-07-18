import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        while (input.contains("<upcase>") && input.contains("</upcase>")) {
            int start = input.indexOf("<upcase>");
            int end = input.indexOf("</upcase>");

            String lower = input.substring(start, end + 9);
            String target = input.substring(start + 8, end);

            String upper = target.toUpperCase();
            input = input.replace(lower,upper);
        }
        System.out.println(input);
    }
}
