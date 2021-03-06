import java.util.Random;
import java.util.Scanner;

public class AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int input = scan.nextInt();
        System.out.println();

        String[] phrases = new String[]{"Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
        String[] events = new String[]{"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!”}"};
        String[] author = new String[]{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        String[] cities = new String[]{"Sofia", "Plovdiv", "Varna", "Burgas", "Ruse"};

        for (int i = 0; i < input; i++) {
            Random rand = new Random();
            int randomPhrase = rand.nextInt((phrases.length) + 0);
            int randomEvent = rand.nextInt((events.length) + 0);
            int randomAuthor = rand.nextInt((author.length) + 0);
            int randoCity = rand.nextInt((cities.length) + 0);
            System.out.println(phrases[randomPhrase]+" "+events[randomEvent]+" "+author[randomAuthor]+" - "+cities[randoCity]);
        }
    }
}
