import java.util.Scanner;

class Circle {
    private int x;
    private int y;
    private int r;

    public Circle(int x, int y, int r) {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

    public int getR() {
        return r;
    }

    public void setR(int r) {
        this.r = r;
    }
}

public class IntersectionOfCircles {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int x1 = scan.nextInt();
        int y1 = scan.nextInt();
        int r1 = scan.nextInt();
        int x2 = scan.nextInt();
        int y2 = scan.nextInt();
        int r2 = scan.nextInt();

        Circle first = new Circle(x1, y1, r1);
        Circle second = new Circle(x2, y2, r2);

        boolean result = Intersect(first, second);
        if (result) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

    private static boolean Intersect(Circle first, Circle second) {

        double distanceX = first.getX() - second.getX();
        double distanceY = first.getY() - second.getY();
        double distance = Math.sqrt(distanceX * distanceX + distanceY * distanceY);
        double sumRadiuses = first.getR() + second.getR();
        if (distance > sumRadiuses) {
            return false;
        } else {
            return true;
        }
    }
}
